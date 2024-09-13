using Hospital.Core.Abstractions;
using Hospital.Domain.Exceptions;
using Hospital.Domain.Models;
using MediatR;

namespace Hospital.Core.PatientRequests.Commands.CreatePatient
{
    /// <summary>
    /// Обработчик запроса для <see cref="CreatePatientCommand"/>
    /// </summary>
    public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">Единица работы</param>
        public CreatePatientCommandHandler(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        ///<inheritdoc/>
        public async Task<int> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var location = await _unitOfWork.Locations.GetByIdAsync(request.LocationId)
                ?? throw new ApplicationExceptionBase($"Не найдена локация с Id {request.LocationId}");

            var patient = new Patient(
                lastName: request.LastName,
                firstName: request.FirstName,
                address: request.Address,
                birthday: request.Birthday,
                gender: request.Gender,
                location: location);

            _unitOfWork.Patients.Add(patient);

            await _unitOfWork.SaveChangesAsync(cancellationToken: cancellationToken);

            return patient.Id;
        }
    }
}

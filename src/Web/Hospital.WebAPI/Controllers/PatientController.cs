using Hospital.Contracts.Requests.Patient.CreatePatient;
using Hospital.Core.PatientRequests.Commands.CreatePatient;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        /// <summary>
		/// Создать пациента
		/// </summary>
		/// <param name="mediator">Медиатор CQRS</param>
		/// <param name="cancellationToken">Токен отмены</param>
		/// <returns>Идентификатор пациента</returns>
		[HttpPost]
        public async Task<int> CreatePatientAsync(
            [FromBody] CreatePatientRequest request,
            [FromServices] IMediator mediator,
            CancellationToken cancellationToken)
            => await mediator.Send(
                new CreatePatientCommand
                {
                    LastName = request.LastName,
                    FirstName = request.FirstName,
                    Surname = request.Surname,
                    Address = request.Address,
                    Birthday = request.Birthday,
                    Gender = request.Gender,
                    LocationId = request.LocationId,
                },
                cancellationToken);
    }
}

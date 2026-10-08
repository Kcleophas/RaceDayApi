using Microsoft.AspNetCore.Mvc;
using RaceDay.Api.Data;
using RaceDay.Api.DTOs;
using RaceDay.Api.Models;

namespace RaceDay.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrolmentsController : ControllerBase
    {
        private readonly RaceDayDbContext _context;

        public EnrolmentsController(RaceDayDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEnrolments()
        {
            return Ok(_context.Enrolments.ToList());
        }

        [HttpPost]
        public IActionResult CreateEnrolment(EnrolmentDTO dto)
        {
            var enrolment = new Enrolment
            {
                UserID = dto.UserId,
                EventID = dto.EventId,
                CategoryID = dto.CategoryId
            };

            _context.Enrolments.Add(enrolment);
            _context.SaveChanges();

            return Ok(enrolment);
        }
    }
}
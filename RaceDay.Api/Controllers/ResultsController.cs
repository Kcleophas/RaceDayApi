using Microsoft.AspNetCore.Mvc;
using RaceDay.Api.Data;
using RaceDay.Api.DTOs;
using RaceDay.Api.Models;

namespace RaceDay.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResultsController : ControllerBase
    {
        private readonly RaceDayDbContext _context;

        public ResultsController(RaceDayDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetResults()
        {
            return Ok(_context.Results.ToList());
        }

        [HttpPost]
        public IActionResult CreateResult(ResultDTO dto)
        {
            var result = new Result
            {
                EnrolmentId = dto.EnrolmentId,
                FinishTime = TimeSpan.Parse(dto.FinishTime),
                Position = dto.Position
            };

            _context.Results.Add(result);
            _context.SaveChanges();

            return Ok(result);
        }
    }
}
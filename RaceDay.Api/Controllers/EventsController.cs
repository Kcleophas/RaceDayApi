using Microsoft.AspNetCore.Mvc;
using RaceDay.Api.Data;
using RaceDay.Api.DTOs;
using RaceDay.Api.Models;

namespace RaceDay.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly RaceDayDbContext _context;

        public EventsController(RaceDayDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            return Ok(_context.Events.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetEvent(int id)
        {
            var evt = _context.Events.Find(id);

            if (evt == null)
                return NotFound();

            return Ok(evt);
        }

        [HttpPost]
        public IActionResult CreateEvent(EventDTO dto)
        {
            var evt = new Event
            {
                EventName = dto.EventName,
                EventDate = dto.EventDate,
                DistanceKm = dto.DistanceKm,
                EventType = dto.EventType
            };

            _context.Events.Add(evt);
            _context.SaveChanges();

            return Ok(evt);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEvent(int id)
        {
            var evt = _context.Events.Find(id);

            if (evt == null)
                return NotFound();

            _context.Events.Remove(evt);
            _context.SaveChanges();

            return Ok("Event deleted");
        }
    }
}
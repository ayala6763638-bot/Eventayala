using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eventserveraylal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public static List<Event> Events = new List<Event> { new Event { id = 1, description = "Wedding", end = new DateTime(), start = new DateTime() },
                 new Event{ id =3, description = "Bar Miztva", start = new DateTime(), end = new DateTime()} };        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return Events;
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return Events.Find(e => e.id == id);
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event value)
        {
            Events.Add(value);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event value)
        {
            var index = Events.FindIndex(e=> e.id==id);
            Events[index].description = value.description;
            Events[index].id = value.id;
            Events[index].end = value.end;
            Events[index].start = value.start;

        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var element1 = Events.Find(e => e.id == id);
            Events.Remove(element1);
        }
    }
}

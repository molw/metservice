using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace org.molw.metserivce.controllers
{
    [Route("api/[controller]")]
    public class MetController : Controller
    {
        private static List<MarineData> _marineData;
        static MetController()
        {
            _marineData = new List<MarineData>();
        }

        //TODO this methods should never be called bc it will try to return 1.2 gigs of data. We should probably limit this to 100 values or something
        [HttpGet]
        public IEnumerable<MarineData> GetAll()
        {
            return _marineData.AsReadOnly();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _marineData.Find(n => n.marine_observation_id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

/*  I don't need these methods since this endpoint is read only
        [HttpPost]
        public IActionResult Create([FromBody] MarineData item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            item.Id = (_notes.Count + 1).ToString();
            _notes.Add(item);
            return CreatedAtRoute("GetNote", new { controller = "Note", id = item.Id }, item);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _notes.RemoveAll(n => n.Id == id);
        }
 */
   
    }
}

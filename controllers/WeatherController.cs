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


        [HttpGet]
        public IEnumerable<MarineData> GetAll()
        {
            return _marineData.AsReadOnly();
        }

        //TODO this needs to be fixed here. id is fine but I think the interior method needs to be fixed
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

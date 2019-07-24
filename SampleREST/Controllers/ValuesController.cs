using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<string> _values = new List<string>();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return _values.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (_values.Count > id)
            {
                return Ok(_values[id]);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            _values.Add(value);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            if (_values.Count > id)
            {
                _values[id] = value;
                return Ok();
            }
            return NotFound();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_values.Count > id)
            {
                _values.RemoveAt(id);
                return Ok();
            }
            return NoContent();
        }
    }
}

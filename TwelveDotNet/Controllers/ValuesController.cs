using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TwelveDotNet.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private static List<string> _values = new List<string>();

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _values[id];
        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody]string value)
        {
            _values.Add(value);
            return _values.Count - 1;
            // TODO: set Locatin header to new Item URL 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            _values[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _values[id] = null;
        }
    }
}

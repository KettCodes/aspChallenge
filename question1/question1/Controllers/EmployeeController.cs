using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataService _dataService;
        public EmployeeController(IDataService dataService)
        {
            _dataService = dataService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var records = _dataService.Get();
            if (records != null)
                if (records.Count > 0)
                    return Ok(records);
            return NotFound();
        }
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var data = _dataService.GetById(id);
            if (data != null)
                return Ok(data);
            return NotFound();
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO: Write code here to create an employee record.
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO: Write code here to update an employee record.
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO: Write code here to delete an employee record.
        }
    }
}

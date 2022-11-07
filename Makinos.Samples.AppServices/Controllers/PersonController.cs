using Makinos.Samples.AppServices.Response;
using Makinos.Samples.BusinessAccessLayer.Interfaces;
using Makinos.Samples.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Makinos.Samples.AppServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("SavePerson")]
        public IActionResult CreatePerson(Person person)
        {
            List<string> errors = new List<string>();
            bool IsSuccess = false;
            try
            {
                _personService.Save(person);
                IsSuccess = true;
            }
            catch(Exception ex)
            {
                errors.Add("Error occurred while saving record");
            }
            return Ok(new APIResponse<bool>(IsSuccess, IsSuccess, System.Net.HttpStatusCode.OK, errors));
        }
    }
}

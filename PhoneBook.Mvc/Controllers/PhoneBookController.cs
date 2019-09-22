using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Interfaces;
using PhoneBook.Application.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneBook.Mvc.Controllers
{
    [Route("api/[controller]")]
    public class PhoneBookController : Controller
    {
        private readonly IContactService _contactService;

        public PhoneBookController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: api/<controller>        
        [HttpGet]
        public IActionResult Get()
        {
            var result = _contactService.GetAllContacts();
            return Ok(result);
        }

        // GET api/<controller>/5        
        [HttpGet("{id}")]
        public IActionResult Get(int? id)
        {
            if (id == null || id < 1)
                return NotFound();
            
            var result = _contactService.GetContact(id.Value);

            if (result==null)
                return NotFound();

            return Ok(result);
        }

        // POST api/<controller>        
        [HttpPost]
        public IActionResult Post([FromBody]AddContactViewModel addContactViewModels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _contactService.Add(addContactViewModels);
            _contactService.Save();
            return Ok();
            //return Created("api/PhoneBook/"+addContactViewModels.Id, addContactViewModels);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]PutContactViewModel putContactViewModel)
        {
            if (id != putContactViewModel.Id)
            {
                return BadRequest();
            }

            _contactService.UpdateContact(putContactViewModel);
            _contactService.Save();

            return NoContent();            
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int? id)
        {
            if (id==null || id < 1)
            {
                return NotFound();
            }
            _contactService.Delete(id.Value);
            _contactService.Save();
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase {

        private readonly AgendaContext _context;
        public ContactController(AgendaContext context) {
            _context = context;
        }
        
        [HttpPost]
        public IActionResult CreateContact(Contact contact) {
            _context.Add(contact);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetContactById), new {id = contact.Id}, contact);
        }

        [HttpGet("{id}")]
        public IActionResult GetContactById(int id) {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [HttpGet("GetContactByName")]
        public IActionResult GetContactByName(string name) {
            var contacts = _context.Contacts.Where(x => x.Name.Contains(name));

            return Ok(contacts);
        }
        
        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, Contact contact) {
            var contactBd = _context.Contacts.Find(id);

            if (contactBd == null)
                return NotFound();

            contactBd.Name = contact.Name;
            contactBd.Phone = contact.Phone;
            contactBd.Active = contact.Active;

            _context.Contacts.Update(contactBd);
            _context.SaveChanges();

            return Ok(contactBd);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var contactBd = _context.Contacts.Find(id);

            if (contactBd == null)
                return NotFound();

            _context.Contacts.Remove(contactBd);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
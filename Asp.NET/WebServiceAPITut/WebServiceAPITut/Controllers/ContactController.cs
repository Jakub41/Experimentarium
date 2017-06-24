using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceAPITut.Models;

namespace WebServiceAPITut.Controllers
{
    [System.Web.Http.RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {
        Contact[] contacts = new Contact[]
        {
            new Contact() { Id = 0, FirstName = "Jake", LastName = "Lemi"},
            new Contact() { Id = 1, FirstName = "Anna", LastName = "Rita"},
            new Contact() { Id = 2, FirstName = "Oho", LastName = "Aho"}
        };

        [System.Web.Http.Route("")]
        public IEnumerable<Contact> Get()
        {
            return contacts;
        }

        [System.Web.Http.Route("{name}")]
        [System.Web.Http.HttpGet]
        public IEnumerable<Contact> GetContactByName(string name)
        {
            Contact[] contactArray = contacts.Where<Contact>(c => c.FirstName.Contains(name)).ToArray<Contact>();


            return contactArray;
        }

        [System.Web.Http.Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            Contact contact = contacts.FirstOrDefault<Contact>(c => c.Id == id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }
        [System.Web.Http.Route("")]
        public IEnumerable<Contact> Post([FromBody] Contact newContact)
        {
            List<Contact> contactList = contacts.ToList<Contact>();
            newContact.Id = contactList.Count;
            contactList.Add(newContact);
            contacts = contactList.ToArray();

            return contacts;
        }
        [System.Web.Http.Route("{id:int}")]
        public IEnumerable<Contact> Put(int id, [FromBody] Contact changedContact)
        {

            Contact contact = contacts.FirstOrDefault<Contact>(c => c.Id == id);

            if (contact != null)
            {
                contact.FirstName = changedContact.FirstName;
                contact.LastName = changedContact.LastName;
            }

            return contacts;
        }
        [System.Web.Http.Route("{id:int}")]
        public IEnumerable<Contact> Delete(int id)
        {
            contacts = contacts.Where<Contact>(c => c.Id != id).ToArray<Contact>();
            return contacts;
        }
    }
}
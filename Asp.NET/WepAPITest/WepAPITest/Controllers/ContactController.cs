﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepAPITest.Models;

namespace WepAPITest.Controllers
{
    [RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {
        private Contact[] contacts = new Contact[]
        {
            new Contact() {Id = 0, FirstName = "Jake", LastName = "Lemi"},
            new Contact() {Id = 1, FirstName = "Anna", LastName = "Dory"},
            new Contact() {Id = 2, FirstName = "En", LastName = "An"}
        };
        // GET: api/Contact
        [Route("")]
        public IEnumerable<Contact> Get()
        {
            return contacts;
        }

        // GET: api/Contact/name
        [Route("{name}")]
        public IEnumerable<Contact> GetContactByName(string name)
        {
            Contact[] contactArray = contacts.Where<Contact>(c => c.FirstName.Contains(name)).ToArray<Contact>();


            return contactArray;
        }

        // GET: api/Contact/5
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            Contact contact = contacts.FirstOrDefault<Contact>(c => c.Id == id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // POST: api/Contact
        [Route("")]
        public IEnumerable<Contact> Post([FromBody] Contact newContact)
        {
            List<Contact> contactList = contacts.ToList<Contact>();
            newContact.Id = contactList.Count;
            contactList.Add(newContact);
            contacts = contactList.ToArray();

            return contacts;
        }

        // PUT: api/Contact/5
        [Route("{id:int}")]
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

        // DELETE: api/Contact/5
        [Route("{id:int}")]
        public IEnumerable<Contact> Delete(int id)
        {
            contacts = contacts.Where<Contact>(c => c.Id != id).ToArray<Contact>();
            return contacts;
        }
    }
}

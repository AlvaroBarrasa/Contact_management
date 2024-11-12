using Contact_management.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contact_management.Controller
{
    public class ContactController
    {
        private readonly AppDbContext _context;

        public ContactController()
        {
            _context = new AppDbContext();
        }

        public List<Contact> GetContacts()
        {
            return _context.Contacts.ToList();
        }

        public void AddContact(Contact contacto)
        {
            _context.Contacts.Add(contacto);
            _context.SaveChanges();
        }

        public void ModifyContacts(int id, Contact contactoModificado)
        {
            var contactoExistente = _context.Contacts.Find(id);
            if (contactoExistente != null)
            {
                contactoExistente.Name = contactoModificado.Name;
                contactoExistente.Address = contactoModificado.Address;
                contactoExistente.Town = contactoModificado.Town;
                contactoExistente.PostalCode = contactoModificado.PostalCode;
                contactoExistente.Country = contactoModificado.Country;
                contactoExistente.Birthday = contactoModificado.Birthday;
                contactoExistente.ProfilePicture = contactoModificado.ProfilePicture;

                _context.SaveChanges();
            }
        }
        public void DeleteContacts(int id)
        {
            var contacto = _context.Contacts.Find(id);
            if (contacto != null)
            {
                _context.Contacts.Remove(contacto);
                _context.SaveChanges();
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Interfaces;
using PhoneBook.Domain.Models;
using PhoneBook.Infra.Data.Contexts;
using System;
using System.Collections.Generic;

namespace PhoneBook.Infra.Data
{
    public class ContactRepository : IContactRepository
    {
        private readonly PhoneBookDbContext _phoneBookDbContext;
        private readonly DbSet<Contact> _contactsDbSet;
        //private readonly DbSet<TEntity> _dbSet;


        public ContactRepository(PhoneBookDbContext phoneBookDbContext)
        {
            _phoneBookDbContext = phoneBookDbContext;
            _contactsDbSet = _phoneBookDbContext.Contacts;
        }

        public void AddContact(Contact contact)
        {
            _contactsDbSet.Add(contact);
        }

        public void DeleteContact(int id)
        {
            var contact = _contactsDbSet.Find(id);
            _contactsDbSet.Remove(contact);
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _contactsDbSet;
        }

        public Contact GetContactById(int id)
        {
            return _contactsDbSet.Find(id);
        }

        public void UpdateContact(Contact newContact)
        {
            _phoneBookDbContext.Entry(newContact).State = EntityState.Modified;
        }

        public int Save()
        {
            return _phoneBookDbContext.SaveChanges();
        }
    }
}

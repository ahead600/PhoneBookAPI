using PhoneBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Domain.Interfaces
{
    public interface IContactRepository
    {
        Contact GetContactById(int id);
        IEnumerable<Contact> GetAllContacts();
        void AddContact(Contact contact);        
        void DeleteContact(int id);
        void UpdateContact(Contact newContact);
        int Save();
    }
}

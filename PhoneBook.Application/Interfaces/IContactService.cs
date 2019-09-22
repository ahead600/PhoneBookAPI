using PhoneBook.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Application.Interfaces
{
    public interface IContactService
    {
        GetAllContactsViewModel GetAllContacts();
        GetContactViewModel GetContact(int id);
        void Add(AddContactViewModel addContactView);
        void Delete(int id);
        void UpdateContact(PutContactViewModel putContactViewModel);
        int Save();
    }
}

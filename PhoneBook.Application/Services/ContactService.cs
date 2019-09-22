using PhoneBook.Application.Interfaces;
using PhoneBook.Application.ViewModels;
using PhoneBook.Domain.Interfaces;
using PhoneBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void Add(AddContactViewModel addContactViewModel)
        {
            var contact = new Contact()
            {
                FirstName = addContactViewModel.FirstName,
                LastName = addContactViewModel.LastName,
                MobileNumber = addContactViewModel.MobileNunmber,
                PhoneNumber = addContactViewModel.PhoneNunmber,
                Address = addContactViewModel.Address
            };
            _contactRepository.AddContact(contact);
        }

        public void Delete(int id)
        {
            _contactRepository.DeleteContact(id);
        }

        public GetAllContactsViewModel GetAllContacts()
        {
            return new GetAllContactsViewModel()
            {
                Contacts = _contactRepository.GetAllContacts()
            };            
        }

        public GetContactViewModel GetContact(int id)
        {
            return new GetContactViewModel()
            {
                Contact = _contactRepository.GetContactById(id)
            };
        }

        public void UpdateContact(PutContactViewModel putContactViewModel)
        {
            var contact = new Contact()
            {
                ContactId=putContactViewModel.Id,
                FirstName = putContactViewModel.FirstName,
                LastName = putContactViewModel.LastName,
                MobileNumber = putContactViewModel.MobileNunmber,
                PhoneNumber = putContactViewModel.PhoneNunmber,
                Address = putContactViewModel.Address
            };
            _contactRepository.UpdateContact(contact);
        }

        public int Save()
        {
            return _contactRepository.Save();
        }
    }
}

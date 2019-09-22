using PhoneBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Application.ViewModels
{
    public class GetAllContactsViewModel
    {
        public IEnumerable<Contact> Contacts { get; set; }
    }
}

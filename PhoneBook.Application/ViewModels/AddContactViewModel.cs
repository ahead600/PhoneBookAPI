using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhoneBook.Application.ViewModels
{
    public class AddContactViewModel
    {
        //public int Id { get; set; }

        //[Required]
        public string FirstName { get; set; }

        //[Required]
        public string LastName { get; set; }

        //[Required]
        public string MobileNunmber { get; set; }

        //[Required]
        public string PhoneNunmber { get; set; }

        public string Address { get; set; }
    }
}

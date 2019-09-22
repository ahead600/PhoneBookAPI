using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Application.ViewModels
{
    public class PutContactViewModel
    {
        public int Id { get; set; }
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

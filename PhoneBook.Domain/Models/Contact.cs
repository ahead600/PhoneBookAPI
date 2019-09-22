using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhoneBook.Domain.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        //[Required]
        public string FirstName { get; set; }
        //[Required]
        public string LastName { get; set; }
        //[Required]
        public string MobileNumber { get; set; }
        //[Required]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}

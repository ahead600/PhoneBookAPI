using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Infra.Data.Contexts
{
    public class PhoneBookDbContext:DbContext
    {
        public PhoneBookDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}

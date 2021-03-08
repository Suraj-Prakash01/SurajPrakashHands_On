using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountDetailsEntityFramework.Models;

namespace AccountDetailsEntityFramework.Data
{
    public class AccountContext:DbContext
    {
        public AccountContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
    }
}

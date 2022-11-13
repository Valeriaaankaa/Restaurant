using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class AccountDbContext: IdentityDbContext<User>
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

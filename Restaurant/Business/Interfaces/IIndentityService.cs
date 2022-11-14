using Business.Models;
using Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IIndentityService
    {
        public IEnumerable<ApplicationUser> GetAll();

        public ApplicationUser GetById(string id);

        public IEnumerable<IdentityRole> GetRoles();

        public void Update(ApplicationUser user);


    }
}

using Business.Interfaces;
using Business.Validation;
using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class IndentityService : IIndentityService
    {
        private readonly IUnitOfWork _unitOfWork;
        public IndentityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public IEnumerable<IdentityRole> GetRoles()
        {
            var roles = _unitOfWork.RoleRepository.GetRoles();
            return roles;
        }


        public IEnumerable<ApplicationUser> GetAll()
        {
            var users = _unitOfWork.UserRepository.GetUsers();
            return users;
        }

        public ApplicationUser GetById(string id)
        { 
            var user =  _unitOfWork.UserRepository.GetUser(id);
            return user;
        }

        public void Update(ApplicationUser model)
        {
            if (model == null)
            {
                throw new RestaurantException("ApplicationUser is null");
            }  

            _unitOfWork.UserRepository.UpdateUser(model);
            
        }



    }
}

﻿using Business.Interfaces;
using Business.Services;
using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.Models;

namespace Restaurant.ControllersControllers
{
    public class UserController : Controller
    {
        private readonly IIndentityService _identityservice;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserController(IIndentityService identityservice, SignInManager<ApplicationUser> signInManager)
        {
            _identityservice = identityservice;
            _signInManager = signInManager;
        }

        [Authorize(Policy = "RequireAdmin")]
        public IActionResult Index()
        {
            var users = _identityservice.GetAll();
            return View(users);
        }
        [Authorize(Policy = "RequireAdmin")]
        public IActionResult ChangeInfo()
        {
            return View();
        }
        [Authorize(Policy = "RequireAdmin")]
        public async Task<IActionResult> Edit(string id)
        {
            var user = _identityservice.GetById(id);
            var roles = _identityservice.GetRoles();

            var userRoles = await _signInManager.UserManager.GetRolesAsync(user);

            var roleItems = roles.Select(role =>
                new SelectListItem(
                    role.Name,
                    role.Id,
                    userRoles.Any(ur => ur.Contains(role.Name)))).ToList();

            var vm = new EditUserViewModel
            {
                User = user,
                Roles = roleItems
            };

            return View(vm);
        }

        [HttpPost]
        [Authorize(Policy = "RequireAdmin")]
        public async Task<IActionResult> OnPostAsync(EditUserViewModel data)
        {
            var user = _identityservice.GetById(data.User.Id);
            if (user == null)
            {
                return NotFound();
            }

            var userRolesInDb = await _signInManager.UserManager.GetRolesAsync(user);

            //Loop through the roles in ViewModel
            //Check if the Role is Assigned In DB
            //If Assigned -> Do Nothing
            //If Not Assigned -> Add Role

            var rolesToAdd = new List<string>();
            var rolesToDelete = new List<string>();

            foreach (var role in data.Roles)
            {
                var assignedInDb = userRolesInDb.FirstOrDefault(ur => ur == role.Text);
                if (role.Selected)
                {
                    if (assignedInDb == null)
                    {
                        rolesToAdd.Add(role.Text);
                    }
                }
                else
                {
                    if (assignedInDb != null)
                    {
                        rolesToDelete.Add(role.Text);
                    }
                }
            }

            if (rolesToAdd.Any())
            {
                await _signInManager.UserManager.AddToRolesAsync(user, rolesToAdd);
            }

            if (rolesToDelete.Any())
            {
                await _signInManager.UserManager.RemoveFromRolesAsync(user, rolesToDelete);
            }

            user.FirstName = data.User.FirstName;
            user.LastName = data.User.LastName;
            user.Email = data.User.Email;

            _identityservice.Update(user);

            return RedirectToAction("Edit", new { id = user.Id });
        }
    }
}

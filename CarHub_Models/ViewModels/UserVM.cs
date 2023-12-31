﻿using CarHub_Models;

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace CarHub_Models.ViewModels
{
    public class UserVM
    {
        public UserVM()
        {
            ApplicationUser = new ApplicationUserDTO();

            ApplicationUserRole = new ApplicationUserRoleDTO();
        }
        public ApplicationUserDTO ApplicationUser { get; set; }
        public ApplicationUserRoleDTO ApplicationUserRole { get; set; }


        [ValidateNever]
        public List<ApplicationUserRoleDTO> ApplicationUserRoleList { get; set; }

        [ValidateNever]
        public List<ApplicationRoleDTO> ApplicationRoleList { get; set; }
    }
}

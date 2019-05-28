using SimECommerce.BOL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimECommerce.Application.ViewModels.Users
{
    public class NewUserViewModel
    {
        [Required, MaxLength(50)]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        internal AspNetUsers CreateUser() => new AspNetUsers()
        {
            UserName = this.UserName,
            PasswordHash = this.Password
        };
    }
}

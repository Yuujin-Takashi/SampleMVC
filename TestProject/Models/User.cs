using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestProject.Models
{
    public partial class User
    {
        public User()
        {
        }

        public string Username {get; set;}
        public string Firstname {get; set;}
        public string Lastname {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public string CreationTime {get; set;}
    
    }
}

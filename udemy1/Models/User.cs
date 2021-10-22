using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace udemy1.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string password { get; set; }
        public bool isadmin { get; set; }
    }
}
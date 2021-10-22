using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace udemy1.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string catg { get; set; }
        [Required]
        public string Discription { get; set; }
        public Comment Comment { get; set; }// it is known as navigation propertie
        public byte CommentId { get; set; }//forigen key
    }
}
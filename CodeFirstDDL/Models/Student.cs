using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstDDL.Models
{
    public class Student
    {

        public int StudentId { get; set; }

        [Required]
        [DisplayName("Naam van de Student")]
        public string StudentName { get; set; }

        public int StateId { get; set; }
    }
}
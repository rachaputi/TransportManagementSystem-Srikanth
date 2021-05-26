using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystem.Models
{

    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Please enter First Name") ]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }



        [Required(ErrorMessage = "Last Name Cannot be Empty") ]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }



        [Required(ErrorMessage ="Gender is Required") ]
        public string Gender { get; set; }



        [Column(TypeName = "int")]
        [Required(ErrorMessage = "Age Cannot be Null")]
        public int Age { get; set; }



        [Required(ErrorMessage = "please Enter Date of Birth")]
        public DateTime DateOfBirth { get; set; }



        [Required(ErrorMessage = "please enter  your Address")]
        public string Address { get; set; }


       
        [Required(ErrorMessage = "please enter  your Map location")]
        public string Location { get; set; }


        [Required(ErrorMessage = "phone number is required")]
        [Column(TypeName = "nchar(10)")]
        public int PhoneNumber { get; set; }
    }
}

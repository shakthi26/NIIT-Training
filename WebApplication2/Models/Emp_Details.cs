//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using WebApplication2.Validator;
    public partial class Emp_Details
    {
        [Required(ErrorMessage = "Please Enter the ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please Enter the UserName")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter the Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter the Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter the Contact")]
        [StringLength(10)]
        public string Contact { get; set; }
        [Range(20, 50, ErrorMessage = "Age Limit should be from 20 to 50 yrs")]
        public Nullable<int> Age { get; set; }
        [Range(10000, 50000, ErrorMessage = "Salary Limit should be from 10k to 50k")]
        public Nullable<int> Salary { get; set; }
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please Enter the Correct Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter the Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please Enter Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyy}")]

        [DojValidation]
        public Nullable<System.DateTime> DOB { get; set; }
        [Required(ErrorMessage = "Please Enter Date of Joining")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyy}")]
        public Nullable<System.DateTime> DOJ { get; set; }
        [Required(ErrorMessage = "Please Enter the Department")]
        public string Department { get; set; }

    }
 }


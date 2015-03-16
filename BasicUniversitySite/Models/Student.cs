﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BasicUniversitySite.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength=1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage="First name cannot be longer than 50 characters.")]
        [RegularExpression(@"[A-Z]+[a-zA-Z''-'\s]*$")]
        [Column("FirstName")]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        [Display(Name="EnrollmentDate")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name="Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
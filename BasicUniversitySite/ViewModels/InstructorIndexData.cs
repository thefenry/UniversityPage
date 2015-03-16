using BasicUniversitySite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicUniversitySite.ViewModels
{
    public class InstructorIndexData
    {
        //This class will help up load all three properties for entities we need 
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamRoles.Models
{
    public class Course
    {
        public Course()
        {
            this.ApplicationUsers = new HashSet<ApplicationUser>();
            this.Grades = new HashSet<Grade>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CoursePic { get; set; }


        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
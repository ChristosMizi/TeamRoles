﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamRoles.Models
{
    public class Assignment
    {
        public Assignment()
        {
            this.Course = new Course();
        }
        [Key]
        public int AssignmentId { get; set; }
        public string AssignmentName { get; set; }
        public string Filename { get; set; }
        public string Path { get; set; }
        public DateTime DueDate { get; set; }
        public int Points { get; set; }
        [NotMapped]
        public HttpPostedFileBase AssignmentFile { get; set; }

        public virtual Course Course { get; set; }
    }
}
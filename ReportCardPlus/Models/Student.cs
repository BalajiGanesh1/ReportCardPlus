using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReportCardPlus.Models
    {
    public class Student
        {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public long StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double English { get; set; }
        [Required]
        public double Maths { get; set; } 
        public double Science { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }

        }
    }
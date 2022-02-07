using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFArabic.Models
{
    public class StudentModel
    {
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public string StudentDepartment { get; set; }
        public double StudentAVG { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InternEfConsole
{
    class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternEfConsole
{
    class Student
    {
        [Key]
        //[Column(Order =0)]
        public string StudentID { get; set; }
        
        public string StudentName { get; set; }
    }
}

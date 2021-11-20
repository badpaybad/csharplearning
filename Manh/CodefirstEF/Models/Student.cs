using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodefirstEF.Models
{   
   public class Student
    {  
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }

    }
}

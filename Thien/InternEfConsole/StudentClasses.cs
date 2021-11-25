using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternEfConsole
{
    class StudentClasses
    {
        [Key,Column(Order =0)]
        public string ClassID { get; set; }
        [Key,Column(Order = 1)]
        public string StudentID { get; set; }
       
    }
}

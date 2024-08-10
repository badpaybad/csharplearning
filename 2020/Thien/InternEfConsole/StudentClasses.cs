using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InternEfConsole
{
    class StudentClasses
    {
        [Key]
        public string ClassID { get; set; }
        public string StudentID { get; set; }
        public string ID { get; set; }
    }
}

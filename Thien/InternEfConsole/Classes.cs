using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InternEfConsole
{
    class Classes
    {
        [Key]
        public string ClassID { get; set; }
        public string ClassName { get; set; }
    }
}

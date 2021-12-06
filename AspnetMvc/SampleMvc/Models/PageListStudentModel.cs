using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMvc.Models
{
    public class PageListStudentModel:LayoutModel
    {
        public List<StudentDto> students { get; set; }
        public string school_name { get; set; }
    }

    public class StudentDto
    {
        public string Name { get; set; }
    }
}

using System;
using System.Linq;

namespace Efconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRespository addStudent = new StudentRespository();
            addStudent.AddStudent();
        }
    }
}

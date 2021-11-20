using System;
using System.Linq;

namespace Efconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRespository Studentress = new StudentRespository();
            //Studentress.CreateStudent("nam2");
             Studentress.ReadStudent("2ee20-2eff-4b52-9535-d0c3c9cede8a");
            //Studentress.UpdateStudent("6612ee20-2eff-4b52-9535-d0c3c9cede8a", "thien3");
           //Studentress.DeleteStudent("8fe96a65-dd7d-405d-94e4-6ec0bee7b7");

        }
    }
}

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
             //Studentress.ReadStudent("020a7cbb-aedf-4eb4-b4f5-ce72a90e5ef0");
            //Studentress.UpdateStudent("6612ee20-2eff-4b52-9535-d0c3c9cede8a", "thien2");
           Studentress.DeleteStudent("8fe96a65-dd7d-405d-94e4-6ec0bee7b7b6");

        }
    }
}

using CodefirstEF.Models;
using System;

namespace CodefirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            Console.WriteLine("Vui long nhap id hoc vien");
            id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Id ban vua nhap la {id}");

            var Student12 = new StudentRespository();
            //Student12.CreatStudent();
            //Student12.GetStudentInfo(id);

            string name;
            Console.WriteLine("Vui long nhap ten moi hoc vien");
            name =Console.ReadLine();
            string className;
            Console.WriteLine("Vui long nhap ten lop moi hoc vien");
            className = Console.ReadLine();

            Student12.UpdateStudent(id,name,className);
            /*Student12.DeleteStudent();*/
        }
    }
}

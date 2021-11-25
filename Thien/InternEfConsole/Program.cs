using System;

namespace InternEfConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository StuRess = new StudentRepository();
            //StuRess.CreateStudent("id2","name2");
            //StuRess.ReadStudent("id1");
            //StuRess.UpdateStudent("id1ds", "up2");
            // StuRess.DeleteStudent("id111");
            ClassesRepository classRess = new ClassesRepository();
            //classRess.AddStudentToClass("idl1", "idhs1");
            //classRess.DeleteStudentinClass("idl11", "idhs1");
            //classRess.SelectStudentsInClass("idl2");
            classRess.SelectStudentsInClass("idl2");
        }
    }
}

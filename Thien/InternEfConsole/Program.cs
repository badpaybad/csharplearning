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

            ClassesRepository Cl = new ClassesRepository();
            //Cl.CreateClasses("cl1","lop1");
            //Cl.ReadClasses("cl1");
           // Cl.UpdateClasses("cl1", "lop2");
            //Cl.DeleteClasses("cl1");

            StudentClassRepository St = new StudentClassRepository();
            //St.AddStudentToClass("idl1", "idhs1");
           // St.DeleteStudentinClass("idl11", "idhs1");
            St.SelectStudentsInClass("2c0f3005-d7f6-4f2e-904e-bf9f5bc8d563");//loi
        }
    }
}

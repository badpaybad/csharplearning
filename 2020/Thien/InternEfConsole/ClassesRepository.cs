using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace InternEfConsole
{
    class ClassesRepository
    {
        public bool CreateClasses(string IdClass, string NameClass)//them lop
        {
            try
            {
                using (var db = new Context())
                {
                    db.Add(new Classes {ClassID=IdClass,ClassName=NameClass});
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public bool ReadClasses(string IdClass) //in ra lop
        {
            using (var db = new Context())
            {
                var classe = db.classes.Where(i => i.ClassID == IdClass).FirstOrDefault();
                if (classe != null)
                {                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateClasses(string IdClass, string NameClass) //update ten lop
        {
            try
            {
                using (var db = new Context())
                {
                    var classe = db.classes.Where(i => i.ClassID == IdClass).FirstOrDefault();
                    if (classe != null)
                    {
                        classe.ClassName = NameClass;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool DeleteClasses(string IdClass)//xoa lop
        {
            try
            {
                using (var db = new Context())
                {
                    var classe = db.classes.Where(i => i.ClassID == IdClass).FirstOrDefault();
                    db.classes.Remove(classe);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}

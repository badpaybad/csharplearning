using System;
using System.Collections.Generic;
using System.Text;

namespace InternEfConsole
{
    public class StudentRepository
    {
        public bool Create(string id, string  name)
        {
            throw new NotImplementedException();
        }

        public bool Update(string id, string name)
        {
            throw new NotImplementedException();
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }
        public Student Get(string studentid)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get(string studentname, string studentid)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

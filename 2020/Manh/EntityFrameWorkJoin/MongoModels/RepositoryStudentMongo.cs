using EntityFrameWorkJoin.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MongoDB.Driver;

namespace EntityFrameWorkJoin.MongoModels
{
      public class RepositoryStudentMongo
    {
        public bool Create(string name, string sex, int yearOfBirth)
        {
            try
            {
                var student = new StudentInformation
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Sex = sex,
                    YearOfBirth = yearOfBirth
                };
                using (var db = new MongoDBContext())
                { 
                    db.StudentInformation.Collection.InsertOne(student);
                }
                return true;
            }
            catch (Exception E)
            {
                return false;
            }
        }
        public StudentModelsMongo GetStudentInfor(Guid id)
        {
            try
            {
                using (var db = new MongoDBContext())
                {
                    var StudentInfor = db.StudentInformation.Where(x => x.Id == id).FirstOrDefault();
                    if (StudentInfor != null)
                    {
                        return new StudentModelsMongo
                        {
                            Id = id,
                            Name = StudentInfor.Name,
                        };
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool UpdateStudent(Guid id,String name , string sex , int yearofbirth)
        {
            try
            {
                var student = new StudentInformation
                {
                    Id=id,
                    Name=name,
                    Sex=sex,
                    YearOfBirth=yearofbirth
                };
                using (var db = new MongoDBContext())
                {
                    student = db.StudentInformation.Where(x => x.Id == id).FirstOrDefault();
                    if(student!=null)
                    {
                        student.Name = name;
                        student.Sex = sex;
                        student.YearOfBirth = yearofbirth;
                        db.StudentInformation.Update(student);
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeleteStudent(Guid id)
        {
            try
            {
                using(var db = new MongoDBContext())
                {
                    var removeStudent = db.StudentInformation.Where(x => x.Id == id).FirstOrDefault();
                    if(removeStudent!=null)
                    {
                        db.StudentInformation.Delete(removeStudent);
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool AddStudentToClass(Guid studentId ,Guid clasId)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}

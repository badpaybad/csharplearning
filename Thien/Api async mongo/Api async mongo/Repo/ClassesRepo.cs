using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_async_mongo.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Api_async_mongo.Repo
{
    public class ClassesRepo
    {
        public async Task<string> CreateClasses(Classes c)//
        {
            try
            {
                using(var db = new Context())
                {
                    var classes = new Classes();
                    classes.Id = Guid.NewGuid();
                    classes.NameClasses = c.NameClasses;
                    await db.Classess.Collection.InsertOneAsync(classes);
                    return "";
                }    
            }
            catch (Exception)
            {
                return null ;
            }
        }
        public async Task<Classes> ReadClasses (Classes c)//
        {
            try
            {
                using(var db = new Context())
                {
                    var classes = await db.Classess.Where(i => i.Id == c.Id).FirstOrDefaultAsync();
                    return classes;
                }    
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<string> UpdateClasses(Classes c)
        {
            try
            {
                using(var db = new Context())
                {
                    var classess = await db.Classess.Where(i => i.Id == c.Id).FirstOrDefaultAsync();
                    classess.NameClasses = c.NameClasses;
                    await db.Classess.Update(classess);
                    return "";
                }    
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<string> DeleteClasses(Classes c)
        {
            try
            {
                using(var db = new Context())
                {
                    var classes = await db.Classess.Where(i => i.Id == c.Id).FirstOrDefaultAsync();
                    await db.Classess.Delete(classes);
                    return "";
                }    
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}

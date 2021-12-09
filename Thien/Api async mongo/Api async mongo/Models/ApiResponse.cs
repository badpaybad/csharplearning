using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_async_mongo.Models
{
    public class ApiResponse<T>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }

}

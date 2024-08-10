using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace ConsoleApp1
{
    class Program
    {
        static void TestString(string stringin,int numberr)
        {
            bool a1 = string.IsNullOrEmpty(stringin);
            if(a1)
            {
                Console.Write("[]");
            }
            int firstlocalspace = stringin.IndexOf(" ");
            if (firstlocalspace != -1)
            {
                stringin = stringin.Substring(0, firstlocalspace) + " " + (stringin.Substring(firstlocalspace)).Replace(" ", "");               
            }
            if (stringin.Length % 2 == 1)
             {
                 stringin = stringin + "_";
             }
            List<string> sg = new List<string>();
            for (int i = 0; i < stringin.Length; i += numberr)
                sg.Add(stringin.Substring(i, numberr));
            string[] segments = sg.ToArray();
            foreach(var item in segments)
            {
                Console.Write('"'+item+'"'+",");
            }          
        }
        static void Main(string[] args)
        {
            TestString("xin chào ahihi",2);
        }
    }    
}

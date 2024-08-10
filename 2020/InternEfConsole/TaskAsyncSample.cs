using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternEfConsole
{

    public class TaskAsyncSample
    {
        public async Task NauNuoc()
        {
            await Task.Delay(3 * 1000);

            Console.WriteLine("async nau nuoc");

        }

        public async Task XeMi()
        {
            await Task.Delay(1000);

            Console.WriteLine("async xe mi");

        }


        public async Task<bool> XeGiaVi()
        {
            await Task.Delay(1000);

            Console.WriteLine("async xe gia vi");

            return true;
        }

        public async Task TronMi()
        {
            await Task.Delay(1000);

            Console.WriteLine("async tron mi");
        }

        public async Task An()
        {

            await Task.Delay(2000);

            Console.WriteLine("async an mi");
        }
    }
}

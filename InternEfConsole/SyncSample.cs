using System;
using System.Threading;

namespace InternEfConsole
{
    public class SyncSample
    {
        public void NauNuoc()
        {
            Thread.Sleep(3 * 1000);

            Console.WriteLine("nau nuoc");

        }

        public void XeMi()
        {
            Thread.Sleep( 1000);

            Console.WriteLine("xe mi");

        }


        public bool XeGiaVi()
        {
            Thread.Sleep(1000);

            Console.WriteLine("xe gia vi");

            return true;
        }

        public void TronMi()
        {
            Thread.Sleep(1000);

            Console.WriteLine("tron mi");
        }

        public void An()
        {

            Thread.Sleep(2000);

            Console.WriteLine("an mi");
        }
    }
}

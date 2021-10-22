using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace software
{
    class Program
    {
        static void Main(string[] args)
        {
            Produce p = new Produce();
            Thread p1 = new Thread(() => p.Prod(20, "Java"));
            Thread p2 = new Thread(() => p.Prod(15, "C#"));
            Thread p3 = new Thread(() => p.Prod(12, "Javascript"));
            p1.Start();
            p2.Start();
            p3.Start();

            Customer jozsi = new Customer("Józsi");
            Thread c1 = new Thread(jozsi.Buy);

            Customer feri = new Customer("Ferenc");
            Thread c2 = new Thread(feri.Buy);

            Customer fanni = new Customer("Fanni");
            Thread c3 = new Thread(fanni.Buy);

            Customer dominik = new Customer("Dominik");
            Thread c4 = new Thread(dominik.Buy);

            Customer luca = new Customer("Luca");
            Thread c5 = new Thread(luca.Buy);

            c1.Start();
            c2.Start();
            c3.Start();
            c4.Start();
            c5.Start();

            p1.Join();
            p2.Join();
            p3.Join();

            c1.Join();
            c2.Join();
            c3.Join();
            c4.Join();
            c5.Join();

            Console.ReadKey(true);
        }
    }
}

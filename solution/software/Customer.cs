using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace software
{
    class Customer
    {

        private string name;

        List<Software> list = new List<Software>();
        int sum = 0;
        public Customer (string name)
        {
            this.name = name;
        }
        public void Buy()
        {
            while(Manager.counter<47)       //47 programot csinálok összesen, akkor nő ha megvesznek egyet
            {
                Software s;
                lock (Manager.software)
                {
                    if (Manager.software.Count > 0)
                    {
                        
                            s = Manager.Select();
                        

                        //Thread.Sleep(rnd.Next(20, 101));
                        
                            list.Add(s);
                            Manager.Pop(s);

                        
                        lock (Manager.ConsoleWriterLock)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("{0} vásárló megvette a {1} programot {2} $-ért.", name, s.Name, s.Price);
                        }
                        sum += s.Price;
                    }
                }

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} vásárló összesen {1} $-t költött.",name,sum);
        }
    }
}

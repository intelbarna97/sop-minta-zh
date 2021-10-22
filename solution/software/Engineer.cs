using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace software
{
    class Engineer
    {
        public static int java=0;
        public static int c=0;
        public static int javascript=0;
        public static void Selector(int count, string language)
        {
            if(language=="Java")
            {
                Java(count);
            }
            else
                if(language=="C#")
            {
                Csharp(count);
            }
            else
                if(language=="Javascript")
            {
                Javascript(count);
            }
        }
        private static void Javascript(int count)
        {
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                //Thread.Sleep(r.Next(1000, 5000));
                int line = r.Next(5000, 12001);
                javascript += line;
                Software s = new Software("javascript" + i, "Javascript", line, r.Next(10, 101));

                lock (Manager.software)
                {
                    Manager.Add(s);
                }

                lock (Manager.ConsoleWriterLock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A Javascript programozó most adott hozzá a bolthoz egy {0} sorú programot, {1} áron.", s.Line, s.Price);
                    Console.WriteLine("Javascript sorainak száma: {0}", javascript);
                }
            }
        }

        private static void Csharp(int count)
        {
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                //Thread.Sleep(r.Next(1000, 5000));
                int line = r.Next(3000, 9001);
                c += line;
                Software s = new Software("C#" + i, "C#",line, r.Next(10, 101));
                lock (Manager.software)
                {
                    Manager.Add(s);
                }
                lock (Manager.ConsoleWriterLock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A C# programozó most adott hozzá a bolthoz egy {0} sorú programot, {1} áron.", s.Line, s.Price);
                    Console.WriteLine("C# sorainak száma: {0}", c);
                }
            }
        }

        public static void Java(int count)
        {
            Random r = new Random();
            for (int i=0;i<count;i++)
            {
                //Thread.Sleep(r.Next(1000, 5000));
                int line = r.Next(2000, 6001);
                java += line;
                Software s = new Software("java" + i, "Java",line, r.Next(10, 101));

                lock (Manager.software)
                {
                    Manager.Add(s);
                }

                lock (Manager.ConsoleWriterLock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A Java programozó most adott hozzá a bolthoz egy {0} sorú programot, {1} áron.", s.Line, s.Price);
                    Console.WriteLine("Java sorainak száma: {0}", java);
                }
            }
        }
        
    }
}

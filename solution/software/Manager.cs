using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software
{
    static class Manager
    {
        public static List<Software> software = new List<Software>();
        public static readonly object ConsoleWriterLock = new object();     //ezzel lelockolom a konzolra való kiíratást, így nem csúsznak össze a sorok
        public const byte CAPACITY = 20;
        public static int counter = 0;

        public static Software Select()
        {
            
                Random rnd = new Random();            
            
                int n = rnd.Next(0, software.Count);
                return software[n];
            
        }
        public static void Add(Software s)
        {
            while(software.Count == 20)
            { }
            
                software.Add(s);
                counter++;
            
        }

        public static void Pop(Software s)
        {            
            if(software.Count>0)
                {
                    software.Remove(s);
                } 
        }
    }
}

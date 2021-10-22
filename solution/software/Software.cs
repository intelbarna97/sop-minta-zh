using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software
{

    
    class Software
    {
        private string name;
        private string language;
        private int line;
        private int price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public int Line { get => line; set => line = value; }
        public int Price { get => price; set => price = value; }

        public Software(string name,string language, int line, int price)
        {
            this.language = language;
            this.name = name;
            this.line = line;
            this.price = price;
        }
    }
}

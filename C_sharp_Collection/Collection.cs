using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Collection
    {
        public static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();

            obj.Add(2);
            obj.Add("C");
            obj.Add(10.32);

            foreach(object i in obj)
            {
                Console.WriteLine(i);
            }
        }
    }
}

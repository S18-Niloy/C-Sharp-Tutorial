using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class HashTable
    {
        public static void Main(String[] args)
        {
            Hashtable table = new Hashtable();

            table.Add("s1", 34);
            table.Add("s2", 44);
            table.Add("s3", 54);
            table.Add("s4", 64);

            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine(entry.Key + " ," + entry.Value);
            }

            SortedList table_2 = new SortedList();

            table_2.Add("s7", 34);
            table_2.Add("s6", 44);
            table_2.Add("s5", 54);
            table_2.Add("s4", 64);

            foreach (DictionaryEntry entry in table_2)
            {
                Console.WriteLine(entry.Key + " ," + entry.Value);
            }

            Dictionary<String,int> table_3 = new Dictionary<String, int>();

            table_3.Add("s1", 34);
            table_3.Add("s2", 44);
            table_3.Add("s3", 54);
            table_3.Add("s4", 64);

            foreach (KeyValuePair<String,int> entry in table_3)
            {
                Console.WriteLine(entry.Key + " ," + entry.Value);
            }

        }
        

    }
}

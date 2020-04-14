using System;
using System.Collections;
using System.Threading;

namespace hastable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "praveen");
            ht.Add("Job","Developer" );
            ht.Add("city", "Hyd");
            foreach(object key in ht.Keys)
                Console.WriteLine(key+":"+ht[key]);
           // Console.WriteLine(ht["Name"]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customlist
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> builtInList = new List<int>();
            //builtInList.Add(4);

            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list);
            Console.ReadLine();
        
        }
    }
}

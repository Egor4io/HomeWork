using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class Programm
    {
        static void Main(string[] args)
        {
            var list = new Model.Linkedlist<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Console.WriteLine(list);
           
            Console.ReadLine();
        }
    }
}

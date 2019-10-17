using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> BinarySearch = new LinkedList<int>();
            BinarySearch.Add(20);
            BinarySearch.Add(10);
            BinarySearch.Add(5);
            BinarySearch.Add(30);
            BinarySearch.Add(25);
            BinarySearch.Add(40);
            BinarySearch.Add(45);
            BinarySearch.Add(50);

            BinarySearch.Search(20);
            BinarySearch.PrintTree();
            Console.ReadLine();

        }
    }
}

using System;
namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BINARY SEARCH TREE PROGRAMS");
            BinarySearchTree<int> search = new BinarySearchTree<int>(56);//root node 
            search.Insert(30);//left node
            search.Insert(70);//right node
            search.Display();
            search.Insert(22);
            search.Insert(40);
            search.Insert(60);
            search.Insert(95);
            search.Insert(11);
            search.Insert(65);
            search.Insert(3);
            search.Insert(16);
            search.Insert(63);
            search.Insert(67);
            search.Display();
            search.GetSize();
            bool result = search.SearchNode(67, search);
            Console.WriteLine( result);
        }
    }
}

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
        }
    }
}

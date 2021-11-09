// .gitignore generated via: dotnet new gitignore

using AndoBinarySearchTree;
using System;

namespace BinarySearchTreeCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = -1;
            int number = 0;
            string data = null;
            BinarySearchTree bst = new BinarySearchTree();

            while (selection != 0)
            {
                selection = Menu();

                switch (selection)
                {
                    case 1:
                        Console.Write("Enter the data you want to add: ");
                        data = Console.ReadLine();

                        if (!int.TryParse(data, out number))
                        {
                            Console.WriteLine($"Invalid entry: {data}");
                        }
                        else
                        {
                            bst.Add(number);
                        }

                        break;
                    case 2:
                        Console.Write("Enter the data you want to remove: ");
                        data = Console.ReadLine();

                        if (!int.TryParse(data, out number))
                        {
                            Console.WriteLine($"Invalid entry: {data}");
                        }
                        else
                        {
                            bst.Remove(number);
                        }
                        break;
                    case 3:
                        bst.PrintTree();
                        break;
                    default:
                        break;
                }
            }
        }

        static int Menu()
        {
            Console.WriteLine("1. Add data to the tree");
            Console.WriteLine("2. Remove data from the tree");
            Console.WriteLine("3. Display the tree");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your selection: ");

            string selection = Console.ReadLine();

            if (!int.TryParse(selection, out int number))
            {
                Console.WriteLine($"Invalid entry: {selection}");
            }

            return number;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Zadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList listOfIntegers = new IntegerList();
            listOfIntegers.Add(1);
            listOfIntegers.Add(2);
            listOfIntegers.Add(3);
            listOfIntegers.Add(4);
            listOfIntegers.Add(5);

            listOfIntegers.RemoveAt(0);
            listOfIntegers.Remove(5);
            Console.WriteLine(listOfIntegers.Count);
            Console.WriteLine(listOfIntegers.Remove(100));
            Console.WriteLine(listOfIntegers.RemoveAt(5));

            listOfIntegers.Clear();
            Console.WriteLine(listOfIntegers.Count);
            Console.ReadLine();

            IGenericList<string> stringList = new GenericsList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("!");

            Console.WriteLine(stringList.Count);
            Console.WriteLine(stringList.Contains("Hello"));
            Console.WriteLine(stringList.IndexOf("Hello"));
            Console.WriteLine(stringList.GetElement(1));

            IGenericList<double> doublelList = new GenericsList<double>();
            doublelList.Add(0.2);
            doublelList.Add(0.7);
            Console.WriteLine(doublelList.Count);
            Console.WriteLine(doublelList.GetElement(1));
            Console.ReadLine();

            foreach (var x in stringList)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}

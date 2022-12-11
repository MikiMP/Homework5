using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using Homework5.Classes;
using MyLibrary1;
using MyLibrary2;

namespace Homework5
{
    internal class Program
    {
        static void PrintArray(string[] array)
        {
            for(int printCounter = 0; printCounter < array.Length; printCounter++)
            {
                Console.WriteLine(array[printCounter]); 
            }
        }

        static void Main(string[] args)
        {
            //MyLibrary1
            string[] arrayWorkersName = new string[10] { "Tom", "Ted", "Ed", "Eddy", "Karolina", "Ola", "Matt", "Elvie", "Zuzan", "Clay" };
            ArrayWorker arrayWorker = new ArrayWorker();

            arrayWorker.SetArrayWorker(arrayWorkersName);
            PrintArray(arrayWorker.GetInvertedArray());

            //MyLibrary2
            Cone cone = new Cone(3d, 4d);
            Console.WriteLine("Radius of circle is {0}",cone.getCircleArea());
            Console.WriteLine("Radius of cone is {0}", cone.getConeArea());

            Stack stack = new Stack();

            //IsEmpty
            Console.WriteLine("Stack IsEmpty? {0}", stack.IsEmpty());

            //Push
            stack.Push("Tom");
            stack.Push("Ted");
            stack.Push("Ed");

            //Pop
            Console.WriteLine("Pop first value from Stack = {0} ", stack.Pop());
            //Contains
            Console.WriteLine("Is there value \"Ted\" ? {0}", stack.Contains("Ted"));
            Console.WriteLine("Stack IsEmpty? {0}", stack.IsEmpty());
            //Peek
            Console.WriteLine("Peek first value from Stack = {0}", stack.Peek());
            //Clear
            stack.Clear();
            Console.WriteLine("Stack IsEmpty? {0}", stack.IsEmpty());

            Console.ReadKey();
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint arraynum;
            int[] array;
            Console.WriteLine("Сколько будет элементов в массиве?");
            arraynum = uint.Parse(Console.ReadLine());
            array = new int[arraynum];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + "-й элемент массива: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}

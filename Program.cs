using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ARRY
{
    class Program
    {
        public static void targil1()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter num:");
                int num = Convert.ToInt32(Console.ReadLine());
                arr[i] = num;
            }
            Console.WriteLine("\n");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void targil2()
        {
            char[] characters = new char[5];
            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine("Enter char:");
                string str = Console.ReadLine();
                characters[i] = Char.Parse(str);
            }
                Console.WriteLine(characters);
        }
        public static void targil3()
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter num:");
                int num = Convert.ToInt32(Console.ReadLine());
                arr1[i] = num;
                arr2[i] = arr1[i];
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("arr1 " + arr1[i] + "\t arr2 " + arr2[i]);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter num:");
                int num = Convert.ToInt32(Console.ReadLine());
                arr1[i] = num;
                Console.WriteLine("arr1 " + arr1[i] + "\t arr2 " + arr2[i]);
            }
        }
        public static void targil45()
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter num:");
                int num = Convert.ToInt32(Console.ReadLine());
                arr1[i] = num;
            }
            arr2 = arr1;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("arr1 " + arr1[i] + "\t arr2 " + arr2[i]);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter num:");
                int num = Convert.ToInt32(Console.ReadLine());
                arr1[i] = num;
                Console.WriteLine("arr1 " + arr1[i] + "\t arr2 " + arr2[i]);
            }
        }
        public static void targil6()
        {
            int sum = 0;
            Console.WriteLine("Enter student num:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter student grade:");
                int grade = Convert.ToInt32(Console.ReadLine());
                arr[i] = grade;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int memotza = sum / arr.Length;
            Console.WriteLine("memotza " + memotza);
        }
        static void Main(string[] args)
        {
            targil1();
            targil2();
            targil3();
            targil45();
            targil6();
            Console.ReadLine();
        }
    }
}

using System;

namespace DS.LESSON_Dictionaries_and_HashSets.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("array = {3, 4, 4, 2, 3, 3, 4, 3, 2}");
            string str = "3, 4, 4, 2, 3, 3, 4, 3, 2";
            string[] list = str.Split(", ");
            int[] count = new int[10];
            int a = 0;
            while (a < list.Length)
            {
                int b = Convert.ToInt32(list[a]);
                count[b]++;
                a++;
            }
            Console.WriteLine("2 -> " + count[2] + " times");
            Console.WriteLine("3 -> " + count[3] + " times");
            Console.WriteLine("4 -> " + count[4] + " times");
        }
    }
}

using System;

namespace task4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            list.Add("Alex");
            list.Add("Genry");
            list.Add("Roman");

            string[] array = list.GetArray();
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}

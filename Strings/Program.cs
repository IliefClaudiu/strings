using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string MyString = "My awesome string";
            for (int i = 0; i < MyString.Length; i++)
            {
                Console.Write(MyString[i]);
            }
            string MyString1 = "My awesome string";
            Console.Write(MyString1.Length);

            string s = string.Empty;
            string b = s;
            Console.Write($"b:{b}");

            int myInt = 30;
            string myIntAsString = myInt.ToString();
            Console.WriteLine($"myIntAsString:{myIntAsString}");
        }
    }
}

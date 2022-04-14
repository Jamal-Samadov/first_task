using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Vugar", "Camal", "Mirzaur", "Salamtcilig", "Beli", "Dunyamali" };



            foreach(string name in names)
            {
                int counter = 0;
                foreach (char ch in name)
                {
                    counter++;
                }
                
                if (counter > 5 )
                {
                    Console.WriteLine(name + " --> " + counter + " herf");
                }
            }
        }
    }
}

using System;

namespace Mask 
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter in a secret.");
            var mysecret = Console.ReadLine();
            string hiddenletters = "";

            mysecret.ToCharArray();
            for (int i = 0; i < mysecret.Length; i++)
            {
                if (mysecret.Length - 4 > i)
                {
                    hiddenletters += "*";
                } else
                {
                    hiddenletters += mysecret[i];
                }
            }
            Console.WriteLine(hiddenletters);
            Console.Read();
        }
    }
}

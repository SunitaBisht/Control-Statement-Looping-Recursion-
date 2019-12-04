using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCharecterVowalORNot
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the charecter:");
            ch = char.Parse(Console.ReadLine());

            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z') 
            {
                if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                {
                    Console.WriteLine("The charecter is Vowel");
                }
                else
                {
                    Console.WriteLine("This charecter is Consonant");
                }
            }
        
              else
            {
                Console.WriteLine("This is not a charecter");
            }
            Console.ReadKey();
        }
    }
}

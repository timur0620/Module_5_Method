using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Bogus;

namespace Module_5_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker();
            string someString = faker.Lorem.Lines(1);

            if (ScreenText(GetFakeString(someString)).Equals("Finish"))
            {
                Console.WriteLine("_______________________________");
                ScreenText(ReversWorld(GetFakeString(someString)));
            }              
        }
        static string[] GetFakeString(string text)
        {            
            string[] result = text.Split(" ");

            return result;
        }
        static string ScreenText(string[] text)
        { 
            foreach (string s in text)
            {
                Console.WriteLine(s);
                Thread.Sleep(1000);
            }
            return "Finish";
        }
        static string[] ReversWorld(string[] text)
        {
            string[] result = new string[text.Length];
            int count = 0;

            for (int i = text.Length -1; i > -1; i--)
            {           
                result[i] = text[count];

                count++;     
            }
            return result;
        }
    }
}

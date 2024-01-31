using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Module_5_Method
{
    internal class Lessons
    {
        static void Work(string[] args)
        {
            IsTesting(100);
            IsTesting(100, 200);
            IsTesting(10, 20, 30);
            IsTesting("string", 10, 20, 30);

            //Infinity();
            NotInfinity(5);


        }
        static int IsTesting(int num)
        {
            return num;
        }
        static int IsTesting(int num, int num_1)
        {
            return num + num_1;
        }
        static int IsTesting(params int[] Args)
        {
            int result = 0;
            foreach (int i in Args)
            {
                result += i;
            }
            return result;
        }
        static string IsTesting(string str, params int[] Args)
        {
            int result = 0;
            foreach (int i in Args)
            {
                result += i;
            }
            return result.ToString() + str;
        }

        static void Infinity()
        {
            Console.Write("0_-");
            Thread.Sleep(100);
            Infinity();
        }
        static void NotInfinity(int count)
        {
            Console.Write("0_-");
            Thread.Sleep(100);
            count--;
            if (count > 0)
            {
                NotInfinity(count);
            }
        }
    }   
}

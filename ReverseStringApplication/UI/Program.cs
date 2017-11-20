using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] name = "Test Name".ToCharArray();
            string reverse = "";
            for (int i = name.Length -1; i > -1; i--)
            {
                reverse += name[i];    
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}

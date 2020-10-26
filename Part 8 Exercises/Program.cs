using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_8_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            practice();
            Console.ReadLine();

        }
        static void practice()
        {
            string name = "Aldworth";
            string name2;
            string yearString;
            int year = 1982;
            //Exercise variables
            string firstName, lastName, studentNumber, username, email, reverseName, backwards, word;
            //Console.WriteLine(name.Length);
            //.WriteLine(name[name.Length -1]);
            //Console.WriteLine(name.Substring(0, name.Length - 1));
            //Console.WriteLine(name[0] + name.Substring(1, 7));
            //yearString = year + "";
            name = name[name.Length - 1] + name.Substring(1, name.Length - 2) + name[0];
            Console.WriteLine(name);
        }
    }
}

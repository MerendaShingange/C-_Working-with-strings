using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will write \n wrap to the next line");
            Console.WriteLine("This will \" will print out the quatation mark.");
            string firstname = "Merenda";
            String lastname = "Shingange";


            //Concatination
            Console.WriteLine(firstname + " " + lastname);
            //functions with strings
            Console.WriteLine(lastname.Length);
            //methods on strings
            Console.WriteLine(firstname.ToUpper());
            //method with a parameter eg the contains(), its case sensitive
            Console.WriteLine(lastname.Contains("Shi"));
            //acsess characters using index
            Console.WriteLine(firstname[0]);
            //index of will tell you if thw value is there and at what position
            Console.Write("index of a is");
            Console.WriteLine(lastname.IndexOf('a')); // can use double quotes too
            // substrings, to grab frm an index onwards
            Console.WriteLine(firstname.Substring(1));
            // you can also give index and length ie how mant chars you wanna grab
            Console.WriteLine(lastname.Substring(1,2));
            Console.Read();

        }
    }
}

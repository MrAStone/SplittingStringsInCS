using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplittingStringsInCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "This,String,Is,Split,Up,Through,The,Use,Of,Commas";
            string[] inputSplit = input.Split(',');
            foreach (string line in inputSplit)
            {
                Console.WriteLine(line);
            }

        }
    }
}

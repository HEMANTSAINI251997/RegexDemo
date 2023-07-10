using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyRegex myregex = new MyRegex();
            myregex.Check();
            myregex.FirstName("Hemant");

        }
    }
}

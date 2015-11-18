using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class ExpressionBodied
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name => FirstName + " " + LastName;

        public void Print() => Console.WriteLine(FirstName + " " + LastName);

        public int Calc(int value) => value * 2;
    }
}

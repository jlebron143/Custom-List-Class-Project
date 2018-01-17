using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListProperties<int> propertiesOne = new ListProperties<int>();
            ListProperties<int> propertiesTwo = new ListProperties<int>();
            ListProperties<string> propertiesThree = new ListProperties<string>();
        }
    }
}

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fody
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var service = new Service12();
            service.Method1(12,"ewe",new object());
        }
    }
}
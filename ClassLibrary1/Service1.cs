using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Service12
    {
        [MethodInterceptor]
        public void Method1()
        {
            throw new BaseException("error baseexception");
            Console.WriteLine("Method1");
            Console.ReadKey();
        }

        [MethodInterceptor]
        public void Method2()
        {
            Console.WriteLine("Method2");
        }


    }


    public class BaseException  : Exception
    {
        public BaseException(string message):base(message)
        {
            
        }
    }
}

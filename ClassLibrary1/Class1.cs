using MethodDecorator.Fody.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public class MethodInterceptorAttribute : Attribute, IMethodDecorator
    {
        private int a;
        private string b;
        private object c;
        public void Init(object instance, MethodBase method, object[] args)
        {
            a = (int)args[0];
            b = (string)args[1];
            c = (object)args[2];

            Console.WriteLine($"Preparing to call: {method.Name}");
        }

        public void OnEntry()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            //var a =  OperationContext.Current.IncomingMessageHeaders;
            //Console.WriteLine(a);
            Console.WriteLine("Method execution started.");
        }

        public void OnException(Exception exception)
        {
            if (exception is BaseException)
            {
                Console.WriteLine(exception.Message);
            }
            else
            {
                Console.WriteLine("exception");
            }
            Console.WriteLine($"An error occurred: {exception.Message}");
            Console.ReadKey();

        }

        public void OnExit()
        {
            Console.WriteLine("Method execution finished.");
        }
    }



}

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
        public void Init(object instance, MethodBase method, object[] args)
        {
            Console.WriteLine($"Preparing to call: {method.Name}");
        }

        public void OnEntry()
        {
           //var a =  OperationContext.Current.IncomingMessageHeaders;
            //Console.WriteLine(a);
            Console.WriteLine("Method execution started.");
        }

        public void OnException(Exception exception)
        {
            if(exception is BaseException)
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

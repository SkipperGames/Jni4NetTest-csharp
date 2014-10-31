using System;
using System.IO;

using net.sf.jni4net;
using net.sf.jni4net.adaptors;
using com.skipper.test;

namespace Jni4NetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var setup = new BridgeSetup();
            setup.Verbose = true;
            setup.AddAllJarsClassPath("./");

            Bridge.CreateJVM(setup);
            Bridge.RegisterAssembly(typeof(Test).Assembly);

            Test test = new Test();
            test.hello();
            test.repeat("It works!");

            Console.WriteLine("\nPress any key to quit.");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    static class Startup
    {
        public static int Main(string[] args)
        {
            var tests = new Tests();
            tests.AsReadOnlySet();
            tests.ToReadOnlySet();
            Console.WriteLine("All tests passed!");
            return 0;
        }
    }
}

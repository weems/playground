using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyTest
{
    class Test
    {
        int[] _array;
        public Test()
        {
            Console.WriteLine("Test()");
            _array = new int[10];
        }
        public int Length
        {
            get
            {
                return _array.Length;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create Lazy.
            Lazy<Test> lazy = new Lazy<Test>();

            // Show that IsValueCreated is false.
            Console.WriteLine("IsValueCreated = {0}", lazy.IsValueCreated);

            // Get the Value.
            // ... This executes Test().
            Test test = lazy.Value;

            // Show the IsValueCreated is true.
            Console.WriteLine("IsValueCreated = {0}", lazy.IsValueCreated);

            // The object can be used.
            Console.WriteLine("Length = {0}", test.Length);
        }
    }
}

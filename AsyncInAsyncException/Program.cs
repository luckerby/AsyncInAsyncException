using System;
using System.Threading.Tasks;

namespace AsyncInAsyncException
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await new AsyncInAsyncException().CallerMethod();
        }
    }

    class AsyncInAsyncException
    {
        private class InnerType
        {
            public int id;
        }
        public async Task CallerMethod()
        {
            await CalleeMethod(5, "hello");
        }

        public async Task CalleeMethod(int firstParameter, string secondParameter)
        {
            InnerType myType = new InnerType();
            myType = null;
            var myValue = myType.id;
        }
    }

}

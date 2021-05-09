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
            await CalleeMethod();
        }

        public async Task CalleeMethod()
        {
            InnerType myType = new InnerType();
            myType = null;
            var myValue = myType.id;
        }
    }

}

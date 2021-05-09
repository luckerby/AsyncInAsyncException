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
        public async Task CallerMethod()
        {
            await CalleeMethod();
        }

        public async Task CalleeMethod()
        {
            throw (new NotImplementedException());
        }
    }

}

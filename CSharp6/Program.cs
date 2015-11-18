using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>
            {
                [0] = 3,
                [1] = 2,
                [2] = 1
            };

            Console.WriteLine("Completed");
        }

        static async void WriteLog()
        {
            CatchFinallyAwait cfawait = new CatchFinallyAwait();

            await cfawait.InsertArticle(new ArticleModel { Subject = "LogMessage", Content = "MyContent" });
        }
    }
}

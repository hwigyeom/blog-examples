using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    public class CatchFinallyAwait
    {
        private FileLogger Logger { get; } = new FileLogger();
        private ArticleRepository ArticleRepository { get; } = new ArticleRepository();

        public async Task<string> InsertArticle(ArticleModel article)
        {
            string articleKey = null;

            try
            {
                articleKey = await ArticleRepository.InsertArticleAsync(article);
            }
            catch (Exception ex)
            {
                await Logger.WriteErrorLog(ex);
                throw ex;
            }

            return articleKey;
        }
    }

    public class ArticleRepository
    {
        private string Filename { get; } = "Log.txt";

        public async Task<string> InsertArticleAsync(ArticleModel article)
        {
            article.ArticleKey = Guid.NewGuid().ToString("N");

            string articleMessage = $"{article.ArticleKey}|{article.Subject}|{article.Content}" + Environment.NewLine;

            throw new ApplicationException("My Exception");

            await WriteLog(articleMessage);

            return article.ArticleKey;
        }

        private async Task WriteLog(string message)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            using (FileStream sourceStream = new FileStream(Filename, FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo capturedException = null;

                try
                {
                    await sourceStream.WriteAsync(messageBytes, 0, messageBytes.Length);
                }
                catch (Exception ex)
                {
                    capturedException = ExceptionDispatchInfo.Capture(ex);
                }

                if (capturedException != null)
                {
                    capturedException.Throw();
                }
            }
        }
    }

    public class FileLogger
    {
        private string Filename { get; } = "Log.txt";

        public async Task WriteErrorLog(Exception ex)
        {
            string log = ex.Message + Environment.NewLine;

            await WriteLog(log);
        }

        private async Task WriteLog(string message)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            using (FileStream sourceStream = new FileStream(Filename, FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo capturedException = null;

                try
                {
                    await sourceStream.WriteAsync(messageBytes, 0, messageBytes.Length);
                }
                catch (Exception ex)
                {
                    capturedException = ExceptionDispatchInfo.Capture(ex);
                }

                if (capturedException != null)
                {
                    capturedException.Throw();
                }
            }
        }
    }

    public class ArticleModel
    {
        public string ArticleKey { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }
    }
}

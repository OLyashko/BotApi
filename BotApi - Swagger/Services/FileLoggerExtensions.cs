using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotApi.Services
{
    public static class FileLoggerExtensions
    {
        public static ILoggerFactory AddFile(this ILoggerFactory factory,
                                            string FilePath)
        {
            factory.AddProvider(new FileLoggerProvider(FilePath));
            return factory;
        }
    }
}

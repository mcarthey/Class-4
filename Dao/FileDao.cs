using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4.Dao
{
    public class FileDao : IDataDao
    {
        private readonly ILogger<FileDao> _logger;

        public FileDao(ILogger<FileDao> logger)
        {
            _logger = logger;
        }

        public void Read()
        {
            Console.WriteLine("Reading the file!");
            _logger.LogInformation("File has been read");
        }

        public void Write()
        {
            Console.WriteLine("Writing the file!");
        }

        public void Open() { }
    }
}

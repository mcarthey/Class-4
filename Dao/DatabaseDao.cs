using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4.Dao
{
    public class DatabaseDao : IDataDao
    {
        public void Read()
        {
            Console.WriteLine("Reading the database!");
        }

        public void Write()
        {
            Console.WriteLine("Writing the database!");
        }
    }
}

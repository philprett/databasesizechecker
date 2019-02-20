using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSizeCheck
{
    public class Statistics
    {
        public string Host { get; set; }
        public string Database { get; set; }
        public string DataFilename { get; set; }
        public long DataSize { get; set; }
        public long DataMaxSize { get; set; }
        public string TLogFilename { get; set; }
        public long TLogSize { get; set; }
        public long TLogMaxSize { get; set; }
        public long TLogUsed { get; set; }

        public Statistics()
        {
            Host = string.Empty;
            Database = string.Empty;
            DataFilename = string.Empty;
            DataSize = 0;
            DataMaxSize = 0;
            TLogFilename = string.Empty;
            TLogSize = 0;
            TLogMaxSize = 0;
            TLogUsed = 0;
        }

    }
}

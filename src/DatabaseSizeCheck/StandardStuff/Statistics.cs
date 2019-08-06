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
        /// <summary>
        /// The database server for which the statistics is for
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The database for which the statistics is for
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// The path of the file containing the database
        /// </summary>
        public string DataFilename { get; set; }
        /// <summary>
        /// The current size of the database in KB.
        /// </summary>
        public long DataSize { get; set; }
        /// <summary>
        /// The maximum size of the database in KB.
        /// For unlimited returns -1.
        /// </summary>
        public long DataMaxSize { get; set; }

        /// <summary>
        /// The size in KB of the drive containing the database
        /// </summary>
        public long DataDriveSize { get; set; }
        /// <summary>
        /// The spaced used in KB on the the drive containing the database
        /// </summary>
        public long DataDriveUsed { get; set; }

        /// <summary>
        /// The path of the file containing the transaction log.
        /// </summary>
        public string TLogFilename { get; set; }
        /// <summary>
        /// The current size of the transaction log in KB.
        /// </summary>
        public long TLogSize { get; set; }
        /// <summary>
        /// The maximum size of the transaction log in KB.
        /// For unlimited returns -1.
        /// </summary>
        public long TLogMaxSize { get; set; }
        /// <summary>
        /// The amount of space inside the transation log that is used in KB.
        /// </summary>
        public long TLogUsed { get; set; }

        /// <summary>
        /// The size in KB of the drive containing the transaction log
        /// </summary>
        public long TLogDriveSize { get; set; }
        /// <summary>
        /// The spaced used in KB on the the drive containing the transaction log
        /// </summary>
        public long TLogDriveUsed { get; set; }

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
            TLogDriveSize = 0;
            TLogDriveUsed = 0;
        }

    }
}

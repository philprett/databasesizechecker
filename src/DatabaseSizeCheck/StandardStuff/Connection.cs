using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSizeCheck
{
    public class Connection : IDisposable
    {
        public string Host { get; set; }
        public string Database { get; set; }
        public bool IntegratedSecurity { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private SqlConnection connection;

        public Connection()
        {
            Host = string.Empty;
            Database = string.Empty;
            IntegratedSecurity = true;
            Username = string.Empty;
            Password = string.Empty;
            connection = null;
        }

        public string ShortName
        {
            get
            {
                return string.Format(
                    "{0}.{1}",
                    Host.Contains(".") ? Host.Substring(0, Host.IndexOf(".")) : Host,
                    Database);
            }
        }

        public string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
                cs.DataSource = Host;
                cs.InitialCatalog = Database;
                if (string.IsNullOrWhiteSpace(Username) || IntegratedSecurity)
                {
                    cs.IntegratedSecurity = true;
                }
                else
                {
                    cs.IntegratedSecurity = false;
                    cs.UserID = Username;
                    cs.Password = Password;
                }
                return cs.ConnectionString;
            }
        }

        public void Open()
        {
            if (connection == null || connection.State != ConnectionState.Open)
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void Dispose()
        {
            Close();
        }

        public DataTable ExecuteQuery(string sql, Dictionary<string, object> parameters = null)
        {
            Open();
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null && parameters.Count > 0)
                {
                    foreach (string name in parameters.Keys)
                    {
                        command.Parameters.Add(new SqlParameter(name, parameters[name]));
                    }
                }
                using (SqlDataAdapter da = new SqlDataAdapter(command))
                {
                    DataTable d = new DataTable();
                    da.Fill(d);
                    return d;
                }
            }
        }

        public int ExecuteNonQuery(string sql, Dictionary<string, object> parameters = null)
        {
            Open();
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null && parameters.Count > 0)
                {
                    foreach (string name in parameters.Keys)
                    {
                        command.Parameters.Add(new SqlParameter(name, parameters[name]));
                    }
                }
                return command.ExecuteNonQuery();
            }
        }

        private long DatabaseSizeFromStringKB(string str)
        {
            if (str.Equals("unlimited", StringComparison.CurrentCultureIgnoreCase))
            {
                return -1;
            }

            return long.Parse(str.Replace("KB", "").Trim());
        }

        public Statistics Statistics
        {
            get
            {
                const string GetDatabaseFileStatisticsSQL =
                    "SELECT     filename, " +
                    "           'size' = convert(nvarchar(15), convert(bigint, size) * 8) + N' KB', " +
                    "           'maxsize' = (case maxsize when -1 then N'Unlimited' " +
                    "                                     when 2147483648 / 8 then N'Unlimited' " +
                    "                                     else convert(nvarchar(15), convert(bigint, maxsize) * 8) + N' KB' end), " +
                    "           'usage' = (case status & 0x40 when 0x40 then 'TLOG' else 'DATA' end) " +
                    "from       sysfiles " +
                    "order by   fileid ";

                const string GetTransactionLogUsageSQL = "DBCC SQLPERF (LOGSPACE)";

                Statistics ret = new Statistics
                {
                    Host = Host,
                    Database = Database,
                };

                Open();
                DataTable files = ExecuteQuery(GetDatabaseFileStatisticsSQL);
                foreach (DataRow r in files.Rows)
                {
                    string dataSizeStr = (string)r["size"];
                    long dataSize = dataSizeStr == "unlimited" ? -1 : long.Parse(dataSizeStr.Replace("KB", "").Trim());
                    if ((string)r["usage"] == "DATA")
                    {
                        ret.DataFilename = (string)r["filename"];
                        ret.DataSize = DatabaseSizeFromStringKB((string)r["size"]);
                        ret.DataMaxSize = DatabaseSizeFromStringKB((string)r["maxsize"]);
                    }
                    else if ((string)r["usage"] == "TLOG")
                    {
                        ret.TLogFilename = (string)r["filename"];
                        ret.TLogSize = DatabaseSizeFromStringKB((string)r["size"]);
                        ret.TLogMaxSize = DatabaseSizeFromStringKB((string)r["maxsize"]);
                    }
                }

                try
                {
                    DataTable tlogs = ExecuteQuery(GetTransactionLogUsageSQL);
                    foreach (DataRow r in tlogs.Rows)
                    {
                        string databaseName = (string)r["Database Name"];
                        long logSize = (long)((float)r["Log Size (MB)"] * 1024);
                        float logSpaceUsed = (float)r["Log Space Used (%)"];
                        if (databaseName.Equals(Database, StringComparison.CurrentCultureIgnoreCase))
                        {
                            ret.TLogUsed = (long)((double)ret.TLogSize * (double)logSpaceUsed / 100.0);
                        }
                    }
                }
                catch { }
                return ret;
            }
        }

    }
}

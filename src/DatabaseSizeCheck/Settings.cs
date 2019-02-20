using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSizeCheck
{
    class Settings
    {
        private const string SavePasswordEncryptionPassPhrase = "aSs$fkE4jhfwh3eF%povuab&4pEibsda9iF(fdasiouw6f§gUdso2aDifgds";
        private const string SavePasswordEncryptionSalt = "li2jfDlksdk56Njhfe)iuEa3sg/hfdZo7igheo%Gfu8gdiF$ufgsdfhD&dsdaifsSSda";

        private string filename;
        public string Filename
        {
            get
            {
                if (string.IsNullOrWhiteSpace(filename))
                {
                    string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DatabaseSizeChecker");
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    filename = Path.Combine(folder, "settings");
                }
                return filename;
            }
        }

        public List<Connection> Databases { get; set; }

        private Encrypter encrypter;

        public Settings()
        {
            filename = string.Empty;
            Databases = new List<Connection>();
            encrypter = new Encrypter
            {
                PassPhrase = SavePasswordEncryptionPassPhrase,
                Salt = SavePasswordEncryptionSalt,
                HashAlgorithm = Encrypter.HashAlgorithms.SHA1,
            };
            Load();
        }

        public void Load()
        {
            Databases = new List<Connection>();
            if (!File.Exists(Filename)) return;

            string lines = File.ReadAllText(Filename);
            foreach (string line in lines.Split(new[] { '\n' }))
            {
                if (line.StartsWith("db="))
                {
                    string[] bits = line.Substring(3).Trim().Split(new[] { '|' });
                    Connection c = new Connection
                    {
                        Host = bits.Length >= 1 ? bits[0] : string.Empty,
                        Database = bits.Length >= 2 ? bits[1] : string.Empty,
                        Username = bits.Length >= 3 ? encrypter.DecryptString(bits[2]) : string.Empty,
                        Password = bits.Length >= 4 ? encrypter.DecryptString(bits[3]) : string.Empty,
                        IntegratedSecurity = bits.Length >= 5 ? bits[4] == "y" : false,
                    };
                    Databases.Add(c);
                }
            }
        }

        public void Save()
        {
            StringBuilder s = new StringBuilder();
            foreach (Connection db in Databases)
            {
                s.AppendLine(string.Format(
                    "db={0}|{1}|{2}|{3}|{4}",
                    db.Host, db.Database, encrypter.EncryptString(db.Username), encrypter.EncryptString(db.Password), db.IntegratedSecurity ? "y" : "n"));
            }
            File.WriteAllText(Filename, s.ToString());
        }


    }
}

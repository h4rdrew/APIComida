using APIComidaTeste.Lib.Interfaces;
using Simple.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIComidaTeste.DA.Views
{
    public class Database : IDatabase
    {
        private readonly string dbPath;
        private SqliteDB db;
        public Database(string dbPath)
        {
            var fi = new FileInfo(dbPath);
            if (!fi.Directory.Exists) fi.Directory.Create();

            this.dbPath = dbPath;
        }

        public LIB.Interfaces.IAlimento Alimento { get; set; }

        public void Config()
        {
            db = new SqliteDB(dbPath);
            Alimento = new Views.Alimento_SQLite(db);
        }
    }
}

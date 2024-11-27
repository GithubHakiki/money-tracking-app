using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace nyobaprojek
{
    public class DbContext: IDisposable
    {
        private SQLiteConnection _conn;
        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;
            try
            {
                string dbName = @"D:\nyobaprojek\part5\Harus bisa\untuk kesekian kali\nyobaprojek\nyobaprojek\nyobaprojek\database\userreg.db";
                string connectionString = string.Format("Data Source={0};FailIfMissing=True", dbName);
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }
            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }

    }
}

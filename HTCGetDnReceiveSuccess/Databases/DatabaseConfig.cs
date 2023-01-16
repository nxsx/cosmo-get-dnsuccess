using MySql.Data.MySqlClient;

namespace HTCGetDnReceiveSuccess.Databases
{
    internal class DatabaseConfig
    {
        public static string CosmoConnectionString()
        {
            MySqlConnectionStringBuilder _cosmoConnectionStringBuilder = new MySqlConnectionStringBuilder();
            _cosmoConnectionStringBuilder.Server = "Server";
            _cosmoConnectionStringBuilder.UserID = "UserID";
            _cosmoConnectionStringBuilder.Password = "Password";

            string _connectionString = (string.IsNullOrEmpty(CosmoDatabase.ConnectionString())) ? _cosmoConnectionStringBuilder.ToString() : CosmoDatabase.ConnectionString();
            return _connectionString;
        }

        public static string MoldConnectionString()
        {
            MySqlConnectionStringBuilder _cosmoConnectionStringBuilder = new MySqlConnectionStringBuilder();
            _cosmoConnectionStringBuilder.Server = "Server";
            _cosmoConnectionStringBuilder.UserID = "UserID";
            _cosmoConnectionStringBuilder.Password = "Password";

            string _connectionString = (string.IsNullOrEmpty(MoldDatabase.ConnectionString())) ? _cosmoConnectionStringBuilder.ToString() : MoldDatabase.ConnectionString();
            return _connectionString;
        }
    }
}

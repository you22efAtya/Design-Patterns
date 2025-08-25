namespace DbConnectionAfterSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Connection01 = DbConnection.CreateInstance("Server=localhost;Database=MyDb;User Id=myUsername;Password=myPassword;");
            var Connection02 = DbConnection.CreateInstance("Server=localhost;Database=MyDb;User Id=myUsername;Password=myPassword;");
        }
    }
}

namespace DbConnectionBeforeSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Connection01 = new DbConnection("Server=localhost;Database=MyDb;User Id=myUsername;Password=myPassword;");
            var Connection02 = new DbConnection("Server=localhost;Database=MyDb;User Id=myUsername;Password=myPassword;");
        }
    }
}

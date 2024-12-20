using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace CRM.Connection
{
    public class DatabaseContext
    {
        public static DatabaseContext databaseContext = null;
        public IDbConnection connection;

        private DatabaseContext() {

            connection = new SqlConnection("Server=Anis\\SQLEXPRESS; Database=CRM; Trusted_Connection=True; Encrypt=False;");
            Console.WriteLine("Hello");
            connection.Open();

        }

        public static DatabaseContext getInstance()
        {
            if(databaseContext == null)
            {
                databaseContext = new DatabaseContext();
            }
            return databaseContext;
        }
    }
}

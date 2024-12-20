using CRM.Connection;
using CRM.Models;
using CRM.Repository;
using Dapper;
using System.Data;
using System.Data.Common;

namespace CRM.Services
{
    public class PartsMaster : IPartsMaster
    {
        public IDbConnection connection;

        public PartsMaster() 
        {
            connection = DatabaseContext.getInstance().connection;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Parts_Master> getAll()
        {
            IEnumerable<Parts_Master> list = connection.Query<Parts_Master>("get_all_parts", commandType: CommandType.StoredProcedure);
            return list.ToList();
        }

        public Parts_Master getSingle(int id)
        {
            var parameters = new { Id = id };
            Parts_Master part= connection.QueryFirst<Parts_Master>("get_single_part", parameters, commandType: CommandType.StoredProcedure);
            return part;
        }

        public Parts_Master update(Parts_Master entity)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

using demoapi.Models;



namespace demoapi.Data
{
    public class SqlUserRepo : IRepo
    {
        private readonly ConnectionString _context;
        public SqlUserRepo(ConnectionString context)
        {
            _context = context;
        }
     public async Task<IEnumerable<User>> GetAllUsers()
        {
            const string query = @"select top(10) id,full_name,name,emp_num from man.users";
            
            using(var conn = new SqlConnection(_context.Value))
            {
                var result = await conn.QueryAsync<User>(query);
                return result;
            }
        }

    }
}
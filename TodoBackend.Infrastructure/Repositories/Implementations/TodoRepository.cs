using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBackend.Domain.Models;
using TodoBackend.Application.Repositories;
using TodoBackend.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Xml.Linq;

namespace TodoBackend.Infrastructure.Repositories.Implementations
{
    public class TodoReposiroty(IConfiguration configuration) : PackageBase(configuration), ITodoReposiroty
    {

        public bool DeleteTodo(int id, int userId)
        {
            throw new NotImplementedException();
        }


        public List<Todo> GetTodosByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public int SaveTodo(string title, int userId)
        {
            using (var conn = new OracleConnection(connStr))
            {
                conn.Open();
                using (var cmd = new OracleCommand("system.PKG_TODOS.InsertTodo", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_TITLE", OracleDbType.Varchar2).Value = title;
                    cmd.Parameters.Add("p_USER_ID", OracleDbType.Varchar2).Value = userId;
                    cmd.ExecuteNonQuery();

                    int entryId = int.Parse(cmd.Parameters["p_id"].Value.ToString());
                    return entryId;
                }
            }

        }


        public bool ToggleCompleted(int id, int userId)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Reflection;
using Dapper;
using DataAccessLayer.Interfaces;

namespace DapperGenericRepository.Repositories
{
    public abstract class BaseRepository<T>: IRepository<T> where T : class, IEntity
    {
        protected string connectionString = @"Data Source=.;Initial Catalog=School; Integrated Security=true";

        public virtual void Insert(T entity)
        {
            var columns = GetColumns();
            var stringOfColumns = string.Join(", ", columns);
            var stringOfParameters = string.Join(", ", columns.Select(e => "@" + e));
            var query = $"sproc{typeof(T).Name}_INSERT {stringOfParameters}";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, entity);
            }
        }

        public virtual void Delete(T entity)
        {
            var query = $"sproc{typeof(T).Name}_DELETE";
            var p = new DynamicParameters();
            p.Add("@ID", entity.Id);
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, p,commandType: CommandType.StoredProcedure);
            }
        }

        public virtual void Update(T entity)
        {
            var columns = GetColumnsForUpdate();
            var stringOfColumns = string.Join(", ", columns.Select(e => $"{e} = @{e}"));
            var stringOfParameters = string.Join(", ", columns.Select(e => "@" + e));
            var query = $"sproc{typeof(T).Name}_UPDATE {stringOfParameters}";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, entity, commandType: CommandType.StoredProcedure);
            }
        }

        public virtual IEnumerable<T> Query(string where = null)
        {
            var query = $"select * from {typeof(T).Name}";

            //if (!string.IsNullOrWhiteSpace(where))
            //    query += where;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<T>(query);
            }
        }

        private IEnumerable<string> GetColumns()
        {
            return typeof(T)
                    .GetProperties()
                    .Where(e => e.Name != "Id" && !e.PropertyType.GetTypeInfo().IsGenericType)
                    .Select(e => e.Name);
        }
        private IEnumerable<string> GetColumnsForUpdate()
        {
            return typeof(T)
                    .GetProperties()
                    .Where(e => !e.PropertyType.GetTypeInfo().IsGenericType)
                    .Select(e => e.Name);
        }
    }
}
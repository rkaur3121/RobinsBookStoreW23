using RobinsBooks.DataAccess.Repository.IRepository;
using RobinsBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Data;

namespace RobinsBooks.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        //access the database
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = ""; //needed to call the stored procedures.

        //constructor to open a sql connection

        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }

        //implements the ISP_Call Interface

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Execute(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlCon.Open();
                SqlCon.Execute(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null)
        {
            SqlCon.Open();
            return SqlCon.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                var result = SqlMapper.QueryMultiple(sqlCon, procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
                var item1 = result.Read<T1>().ToList(); //make sure to add using statement for LINQ
                var item2 = result.Read<T2>().ToList();

                if (item1 != null && item2 != null)
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(item1, item2);
                }
            }
            return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(new List<T1>(), new List<T2>());
        }

        public T OneRecord<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                var value = sqlCon.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
                return (T)Convert.ChangeType(value.FirstOrDefault(), typeof(T));
            }
        }

        public T Single<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection SQLCon = new SqlConnection(ConnectionString))
            {
                SQLCon.Open();
                return (T)Convert.ChangeType(SQLCon.ExecuteScalar<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));

            }
        }

        private class SqlCon
        {
            internal static void Execute(string procedureName, DynamicParameters param, CommandType commandType)
            {
                throw new NotImplementedException();
            }

            internal static void Open()
            {
                throw new NotImplementedException();
            }

            internal static IEnumerable<T> Query<T>(string procedureName, DynamicParameters param, CommandType commandType)
            {
                throw new NotImplementedException();
            }
        }
    }
}

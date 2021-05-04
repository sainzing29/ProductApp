using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI
{
    public static class DapperORM
    {

        public static bool ExecuteWithoutReturn(string QueryOrProcedure, DynamicParameters param, byte commandType = 0)
        {
            using (SqlConnection dbconn = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    int i = 0;
                    if (dbconn.State == System.Data.ConnectionState.Closed)
                    {
                        dbconn.Open();
                    }
                    if(commandType == 0)
                    {
                        i = dbconn.Execute(QueryOrProcedure, param, commandType: CommandType.StoredProcedure);
                    }
                    else
                    {
                        i = dbconn.Execute(QueryOrProcedure, param, commandType: CommandType.Text);
                    }
             
                    if(i>0)
                    {
                        return true;
                    }
                }

                catch (Exception ex)
                {

                    throw ex;
                }
                return false;
            }
        }


        public static T ExecuteReturnScalar<T>(string procedureName, DynamicParameters param)
        {
            using (SqlConnection dbconn = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    if (dbconn.State == System.Data.ConnectionState.Closed)
                    {
                        dbconn.Open();
                    }
       

                    return (T)Convert.ChangeType(dbconn.ExecuteScalar(procedureName, param, commandType: CommandType.StoredProcedure),typeof(T));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static IEnumerable<T>  ReturnList<T> (string query, DynamicParameters param =null,byte commandType=0) //commandType 0 'StoredProcedure',commandType 1 'Text'
        {
            using (SqlConnection dbconn = new SqlConnection(DbConnection.ConnectionString))
            { 
                try
                {
                    if (dbconn.State == System.Data.ConnectionState.Closed)
                    {
                        dbconn.Open();
                    }
                    if(commandType==0)
                    {
                        return dbconn.Query<T>(query, param, commandType: CommandType.StoredProcedure);
                    }
                    else
                    {
                        return dbconn.Query<T>(query, param, commandType: CommandType.Text);
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public static T ReturnById<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection dbconn = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    if (dbconn.State == System.Data.ConnectionState.Closed)
                    {
                        dbconn.Open();
                    }
                    return dbconn.QuerySingle<T>(procedureName, param, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }


    }
}

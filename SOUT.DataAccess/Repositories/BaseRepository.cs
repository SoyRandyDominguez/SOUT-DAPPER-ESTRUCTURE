using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOUT.DataAccess.Repositories
{
   public abstract class BaseRepository
    {
        private static SqlConnection _cn = null;
        protected static T ExecuteScalar<T>(string sentencia, object parametros = null)
        {
            try
            {
                OpenConnection();
                if (sentencia == null) return default(T);
                var paramList = new DynamicParameters();
                if (parametros != null) paramList.AddDynamicParams(parametros);
                return (_cn.ExecuteScalar<T>(sentencia, paramList));
            }
            catch (Exception e)
            {
                string error = e.Message;
                throw;
            }
        }

        protected static List<T> Query<T>(string sentencia, object parametros = null)
        {
            try
            {
                OpenConnection();
                if (sentencia == null) return default(List<T>);
                var paramList = new DynamicParameters();
                if (parametros != null) paramList.AddDynamicParams(parametros);
                return (_cn.Query<T>(sentencia, paramList)).ToList();
            }
            catch (Exception e)
            {
                string error = e.Message;
                throw;
            }
        }


        protected static Task<IEnumerable<T>> QueryAsync<T>(string sentencia, object parametros = null)
        {
            try
            {
                OpenConnection();
                if (sentencia == null) return default(Task<IEnumerable<T>>);
                var paramList = new DynamicParameters();
                if (parametros != null) paramList.AddDynamicParams(parametros);
                var result = _cn.QueryAsync<T>(sentencia, paramList);

                //await Task.Delay(100000);
                return result;

            }
            catch (Exception e)
            {
                string error = e.Message;
                throw;
            }
        }

        public static void InsertErrorAsync(Exception pE, string MethodName = "", string ClassName = "")
        {
            try
            {
                OpenConnection();
                //if (sentencia == null) return default(Task);
                var paramList = new DynamicParameters();
                var parametros = new Dictionary<string, object>();
                parametros.Add("@DLogSource", pE.Source);
                parametros.Add("@DLogStackTrace", pE.StackTrace);
                parametros.Add("@DLogMessage", pE.Message);
                parametros.Add("@DLogDateTime", DateTime.Now);
                parametros.Add("@DMethodName", MethodName);
                parametros.Add("@DClassName", ClassName);
                if (parametros != null) paramList.AddDynamicParams(parametros);
                var result = _cn.QueryAsync(@"
                INSERT INTO [dbo].[DCSharpErrorLog]  VALUES (@DLogSource  ,@DLogStackTrace ,@DLogMessage  
                 ,@DLogDateTime ,@DMethodName ,@DClassName)", paramList);

            }
            catch (Exception e)
            {
                string error = e.Message;
                throw;
            }
        }

        protected static List<T> QueryStoredProcedure<T>(string StoredPName, object parametros = null)
        {
            try
            {
                OpenConnection();
                if (StoredPName == null) return default(List<T>);
                var paramList = new DynamicParameters();
                if (parametros != null) paramList.AddDynamicParams(parametros);
                return (_cn.Query<T>(StoredPName, paramList, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception e)
            {
                string error = e.Message;
                throw;
            }

        }

        private static void OpenConnection()
        {
            if (_cn != null)
            {
                if (_cn.State == System.Data.ConnectionState.Open)
                {
                    return;
                }
                else
                {
                    _cn.Close();
                    _cn.Dispose();
                    _cn = null;
                }
            }

            _cn = SOUT.DataAccess.Helpers.ConfigHelper.GetSqlConnection();
            //_cn =  new SqlConnection(@"data source=(local);initial catalog=MARCentral;persist security info=True;MultipleActiveResultSets=true;Min Pool Size=10;user id=sa;pwd=st0rpk0qt0z");
            try
            {
                _cn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo la conexion a la base de datos.", ex);
            }
        }

      
    }
}

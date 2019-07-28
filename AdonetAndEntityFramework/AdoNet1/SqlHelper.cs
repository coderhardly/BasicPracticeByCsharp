using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace AdoNet1
{
   public  class SqlHelper<T>
    {
        private static string conn = ConfigurationManager.ConnectionStrings["CodeFirst"].ConnectionString;
        //public string conn = @"data source=DESKTOP-O6EORH9\SQLEXPRESS;initial catalog=CodeFirst;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        /// <summary>
        /// 执行增删改命令，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public static int ExcuteNoQuery(string sql,params SqlParameter[] sqlParameters)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            using(SqlCommand cmd=new SqlCommand(sql, sqlConnection))
            {
                sqlConnection.Open();
                if (sqlParameters != null)
                {
                    cmd.Parameters.AddRange(sqlParameters);
                }
                int num = cmd.ExecuteNonQuery();
                return num;
            }
        }
        /// <summary>
        /// 查询单个值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public static Object ExeCueScalar(string sql, params SqlParameter[] sqlParameters)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                sqlConnection.Open();
                if (sqlParameters != null)
                {
                    cmd.Parameters.AddRange(sqlParameters);
                }
                object num = cmd.ExecuteScalar();
                return num;
            }
        }
        /// <summary>
        /// 获取多行数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public static IDataReader ExeCuteDataReader(string sql,params SqlParameter[] sqlParameters)
        {
            SqlConnection con = new SqlConnection(conn);
            using(SqlCommand cmd=new SqlCommand(sql, con))
            {
                con.Open();
                if (sqlParameters.Length != 0)
                {
                    cmd.Parameters.AddRange(sqlParameters);
                }
               var data= cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return data;
            }
        }

        public static DataTable GetTable(string sql,params SqlParameter[] sqlParameters)
        {
            SqlConnection connection = new SqlConnection(conn);
            DataTable dataTable = new DataTable();
            using(SqlDataAdapter adp=new SqlDataAdapter(sql, connection))
            {
                if (sqlParameters.Length != 0)
                {
                    adp.SelectCommand.Parameters.AddRange(sqlParameters);
                }
                adp.Fill(dataTable);
                return dataTable;
            }
        }

        public static List<T> DataReaderToT(IDataReader dataAdapter)
        {
            var typeName = typeof(T);
            List<T> list = new List<T>();
            while (dataAdapter.Read())
            {
                var entity = (T)Activator.CreateInstance(typeName);
                var poertys = typeName.GetProperties();
                for(int i = 0; i < poertys.Length; i++)
                {
                    //if (poertys.Length == dataAdapter.FieldCount)
                    /* { */
                    var name = poertys[i].Name;
                        poertys[i].SetValue(entity, dataAdapter[name]);
                    //}
                }
                list.Add(entity);
            }
            return list;
        }


    }
}

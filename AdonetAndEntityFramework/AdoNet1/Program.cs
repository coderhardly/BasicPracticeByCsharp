using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;
using EfCodeFirstTest;

namespace AdoNet1
{
    class Program
    {
        private string conn = ConfigurationManager.ConnectionStrings["CodeFirst"].ConnectionString;
        static void Main(string[] args)
        {
            string sql = @"Select * from Blogs";
            //SqlParameter[] parameter =new SqlParameter[2];
           var data= SqlHelper<Blog>.ExeCuteDataReader(sql);
            var list = SqlHelper<Blog>.DataReaderToT(data);
            Console.Read();
        }
    } 
}

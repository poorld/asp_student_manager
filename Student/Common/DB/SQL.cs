using Assets.Common.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Assets.DB
{
    class SQL
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public const string DATABASE_NAME = "student";

        //public const string LocalDB = "student.mdf";
        public const string LocalDB = "Database1.mdf";

        public static SqlConnection getLocalDB()
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                //AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }
            dataDir += "App_Data";
            string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + dataDir + "\\"+ LocalDB + "\"; Integrated Security = True; Connect Timeout = 30";
            return new SqlConnection(connString);
        }


        public static SqlConnection getSqlServerConnection()
        {
            string connectStr = "Data Source=PC-913135;Initial Catalog=Student;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectStr);
            return sqlCon;
        }

        public static SqlConnection getConnectionByLocal(string dbName)
        {
            startMSSQLSERVER();

            string localHostName = Tool.getLocalHostName();
            string connectStr = "Data Source={0};Initial Catalog={1};Integrated Security=True";
            connectStr = String.Format(connectStr, localHostName, dbName);
            SqlConnection sqlCon = new SqlConnection(connectStr);
            Console.WriteLine(sqlCon.State);
            try
            {
                sqlCon.Open();
                sqlCon.Close();
                //MessageBox.Show("数据库连接成功!");
                return sqlCon;
            }
            catch (SqlException e)
            {

            }
            finally
            {
                
            }

            return null;
        }

        public static bool startMSSQLSERVER()
        {
            ServiceController sc = new ServiceController("MSSQLSERVER");
            //判断服务是否已经关闭
            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                sc.Start();
                return true;
            }

            return false;
        }

        public static bool stopMSSQLSERVER()
        {
            ServiceController sc = new ServiceController("MSSQLSERVER");
            //判断服务是否已经开启
            if (sc.Status != ServiceControllerStatus.Stopped)
            {
                sc.Stop();
                return true;
            }
            return false;
        }


        public static void getMysqlConnection()
        {

        }

    }
}

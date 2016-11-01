using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// create by chenzhaoquan
/// </summary>
namespace DAL
{
    public class DBOperater
    {
        private static OleDbConnection DBconnection()
        {
            LoadDBInfo dbinfo = new LoadDBInfo();
            dbinfo.loadDBInfo();
            string connString = @"Provider=" + LoadDBInfo.provider + ";Data Source =" + LoadDBInfo.data_source + ";initial catalog=" + LoadDBInfo.initial_catalog + ";User Id = " + LoadDBInfo.user_id + ";Password = " + LoadDBInfo.password;
            OleDbConnection conn = new OleDbConnection(connString);
            return conn;
        }

        private static void DBConnOpen(OleDbConnection conn)
        {
            conn.Open();
        }

        private static void DBConnClose(OleDbConnection conn)
        {
            conn.Close();
        }

        public static DataSet selectSql(string _sql)
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = DBconnection();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                DBConnOpen(conn);
                cmd.Connection = conn;
                cmd.CommandText = _sql;
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(ds);
                

            }
            catch (Exception e)
            {
                MessageBox.Show("select error message:" + e.Message);
                
            }
            finally
            {
                DBConnClose(conn);
            }
            return ds;
        }

        public static int executeSql(String _sql)
        {
            OleDbConnection conn = DBconnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbTransaction trans = null;
            int flag = 0;
            try
            {
                DBConnOpen(conn);
                cmd.Connection = conn;
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;
                cmd.CommandText = _sql;
                int result = cmd.ExecuteNonQuery();
                trans.Commit();
                flag = 1;
                
            }
            catch (Exception e)
            {
                MessageBox.Show("insert/update/delete error message:" + e.Message);
                
                flag = -1;
            }
            finally
            {
                DBConnClose(conn);
            }
            return flag;
        }
    }
}

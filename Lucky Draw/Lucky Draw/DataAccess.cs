/*版权声明
 * 
 * 由于学院需要本随机抽奖系统由 
 * 河北大学管理学院05信息管理与信息系统 朱胜贤 
 * 根据黑闪(http://blog.csdn.net/fjp813/)幸运999软件改编
 * 功能基本上全部重写，借用了原软件的界面
 * 
 * 如有任何疑问请联系开发人员
 * 
 * 开发者：神在人间(Zagelover)
 * Email：zagelover@163.com   QQ:214535911
 * http://hi.baidu.com/zagelover
 * http://www.cnblogs.com/zagelover/
 * 
 * CopyRight (c) 河北大学管理学院05信管神仙 2008~2010
 */

using System;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.Text;

/// <summary>
/// DataAccess 为数据库操作等全局定义的一些类
/// </summary>
public class DataAccess
{
    public DataAccess()
    {
    }
    public static bool DataIsChange;

    #region 配置数据库连接字符串
    /// <summary>
    /// 配置数据库连接字符串
    /// </summary>
    private static string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Environment.CurrentDirectory + "\\data\\LD.mdb;Persist Security Info=False;Jet OLEDB:Database Password=shiyanexperiment;";
    #endregion

    #region  执行SQL语句，返回Bool值
    /// <summary>
    /// 执行SQL语句，返回Bool值
    /// </summary>
    /// <param name="sql">要执行的SQL语句</param>
    /// <returns>返回BOOL值，True为执行成功</returns>
    public bool ExecuteSQL(string sql)
    {
        OleDbConnection con = new OleDbConnection(ConnectionString);
        OleDbCommand cmd = new OleDbCommand(sql, con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            con.Close();
            con.Dispose();
            cmd.Dispose();
        }
    }
    #endregion

    #region  执行SQL语句，返回DataTable
    /// <summary>
    /// 执行SQL语句，返回DataTable
    /// </summary>
    /// <param name="sql">要执行的SQL语句</param>
    /// <returns>返回DataTable类型的执行结果</returns>
    public DataTable GetDataTable(string sql)
    {
        DataSet ds = new DataSet();
        OleDbConnection con = new OleDbConnection(ConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
        try
        {
            da.Fill(ds, "tb");
        }
        catch (Exception ex)
        {
            // throw new Exception(ex.ToString());
        }
        finally
        {
            con.Close();
            con.Dispose();
            da.Dispose();
        }
        DataTable result = ds.Tables["tb"];
        return result;
    }
    #endregion

    #region  导入Excel表，返回DataTable
    /// <summary>
    /// 导入Excel表，返回DataTable
    /// </summary>
    /// <param name="strFilePath">要导入的Excel表</param>
    /// <returns>返回DataTable类型的执行结果</returns>
    public DataTable LendInDT(string strFilePath)
    {
        if (strFilePath == null)
        {
            throw new ArgumentNullException("filename string is null!");
        }

        if (strFilePath.Length == 0)
        {
            throw new ArgumentException("filename string is empty!");
        }

        string oleDBConnString = String.Empty;
        oleDBConnString = "Provider=Microsoft.Jet.OLEDB.4.0;";
        oleDBConnString += "Data Source=";
        oleDBConnString += strFilePath;
        oleDBConnString += ";Extended Properties=Excel 8.0;";


        OleDbConnection oleDBConn = null;
        OleDbDataAdapter da = null;
        DataTable m_tableName = new DataTable(); ;
        DataSet ds = new DataSet();
        oleDBConn = new OleDbConnection(oleDBConnString);
        oleDBConn.Open();
        m_tableName = oleDBConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

        if (m_tableName != null && m_tableName.Rows.Count > 0)
        {

            m_tableName.TableName = m_tableName.Rows[0]["TABLE_NAME"].ToString();

        }
        string sqlMaster = " SELECT * FROM [" + m_tableName + "]";
        da = new OleDbDataAdapter(sqlMaster, oleDBConn);
        try
        {
            da.Fill(ds, "tb");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.ToString());
        }
        finally
        {
            oleDBConn.Close();
            oleDBConn.Dispose();
            da.Dispose();
        }
        DataTable result = ds.Tables["tb"];
        return result;

    }
    #endregion
}


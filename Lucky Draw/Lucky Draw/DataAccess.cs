/*��Ȩ����
 * 
 * ����ѧԺ��Ҫ������齱ϵͳ�� 
 * �ӱ���ѧ����ѧԺ05��Ϣ��������Ϣϵͳ ��ʤ�� 
 * ���ݺ���(http://blog.csdn.net/fjp813/)����999����ı�
 * ���ܻ�����ȫ����д��������ԭ����Ľ���
 * 
 * �����κ���������ϵ������Ա
 * 
 * �����ߣ������˼�(Zagelover)
 * Email��zagelover@163.com   QQ:214535911
 * http://hi.baidu.com/zagelover
 * http://www.cnblogs.com/zagelover/
 * 
 * CopyRight (c) �ӱ���ѧ����ѧԺ05�Ź����� 2008~2010
 */

using System;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.Text;

/// <summary>
/// DataAccess Ϊ���ݿ������ȫ�ֶ����һЩ��
/// </summary>
public class DataAccess
{
    public DataAccess()
    {
    }
    public static bool DataIsChange;

    #region �������ݿ������ַ���
    /// <summary>
    /// �������ݿ������ַ���
    /// </summary>
    private static string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Environment.CurrentDirectory + "\\data\\LD.mdb;Persist Security Info=False;Jet OLEDB:Database Password=shiyanexperiment;";
    #endregion

    #region  ִ��SQL��䣬����Boolֵ
    /// <summary>
    /// ִ��SQL��䣬����Boolֵ
    /// </summary>
    /// <param name="sql">Ҫִ�е�SQL���</param>
    /// <returns>����BOOLֵ��TrueΪִ�гɹ�</returns>
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

    #region  ִ��SQL��䣬����DataTable
    /// <summary>
    /// ִ��SQL��䣬����DataTable
    /// </summary>
    /// <param name="sql">Ҫִ�е�SQL���</param>
    /// <returns>����DataTable���͵�ִ�н��</returns>
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

    #region  ����Excel������DataTable
    /// <summary>
    /// ����Excel������DataTable
    /// </summary>
    /// <param name="strFilePath">Ҫ�����Excel��</param>
    /// <returns>����DataTable���͵�ִ�н��</returns>
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


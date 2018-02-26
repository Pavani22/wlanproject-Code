using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Windows.Forms;

/// <summary>
/// Summary description for DAO
/// </summary>
public class DAL
{
    private static SqlConnection con = Database.Connection;
    public static Admin Login(string uname,string pwd) {
        con.Open();
        try
        {
            string query = "select uname,pwd from admin where uname=@uname and pwd=@pwd ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uname",uname);
            cmd.Parameters.AddWithValue("@pwd",pwd);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = new Admin();
            if (reader.Read())
            {
                admin.Uname = (string)reader["uname"];
                admin.Pwd = (string)reader["pwd"];
                return admin;
            }
            else
            {
              return null;
            }
        }
        catch (Exception ex)
        {
           
            HttpContext.Current.Trace.Write("Exception in DAO.ChPwd : " + ex.Message);
            return null;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }
       }
    public static bool ChPwd(string opwd, string npwd)
    {
        con.Open();
        SqlTransaction trans = con.BeginTransaction();
        try
        {
            String update = "update admin set pwd=@npwd where pwd=@opwd";
            SqlCommand cmd= new SqlCommand(update, con);
            cmd.Transaction = trans;
            cmd.Parameters.AddWithValue("@opwd", opwd);
            cmd.Parameters.AddWithValue("@npwd", npwd);
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                trans.Commit();
                return true;
            }
            else
            {
                trans.Rollback();
                return false;
            }
        }
        catch (Exception ex)
        {
            trans.Rollback();
            HttpContext.Current.Trace.Write("Exception in DAO.ChPwd : " + ex.Message);
            return false;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
    public static bool AddNode(NodeModel node)
    {
        con.Open();
        SqlTransaction trans = con.BeginTransaction();
        try
        {
            /*SqlCommand cmd1 = new SqlCommand("select count(*) from nodes where mac=@mac");
            SqlDataReader sdr = cmd1.ExecuteReader();
            if (sdr[0].Equals("1"))
            {
                MessageBox.Show(" MAC address is already existing. Enter new address...");
                i = 1;
                return false;
            }
            SqlCommand cmdd = new SqlCommand("select count(*) from nodes where ip=@ip");
            SqlDataReader dr = cmdd.ExecuteReader();
            if (dr[0].Equals(1))
            {
                MessageBox.Show(" IP address is already existing. Enter new address...");
                i = 2;
                return false;
            }*/

            String insert = "insert into nodes(mac,ip,node,auth)values(@mac,@ip,@node,@auth)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Transaction = trans;
            cmd.Parameters.AddWithValue("@mac", node.Mac);
            cmd.Parameters.AddWithValue("@ip", node.Ip);
            cmd.Parameters.AddWithValue("@node", node.Node);
            cmd.Parameters.AddWithValue("@auth", "n");
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                trans.Commit();
            //    i = 3;
                return true;
            }
           else
            {
                trans.Rollback();
                return false;
            }
        }
        catch (Exception ex)
        {
            trans.Rollback();
            HttpContext.Current.Trace.Write("Exception in DAO.AddNode : " + ex.Message + " ----> " + ex.StackTrace);
            //i = 4;
            return false;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }
        //i = 5;
        return true;
    }
    public static bool ConnNode(string node)
    {
        HttpContext.Current.Trace.Write("Connecting to node  "+node);
        con.Open();
        SqlTransaction trans = con.BeginTransaction();
        try
        {
            String update = "update nodes set auth='y' where node=@node";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.Transaction = trans;
            cmd.Parameters.AddWithValue("@node", node);
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                trans.Commit();
                return true;
            }
            else
            {
                trans.Rollback();
                HttpContext.Current.Trace.Write("Could not connect node : ");
                return false;
            }
        }
        catch (Exception ex)
        {
            trans.Rollback();
            HttpContext.Current.Trace.Write("Exception in DAO.ConnNode : " + ex.Message);
            return false;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
    public static bool DeleteNodes()
    {
        con.Open();
        SqlTransaction trans = con.BeginTransaction();
        try
        {
            String delete = "delete from nodes";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.Transaction = trans;
            int count = cmd.ExecuteNonQuery();
            trans.Commit();
            return true;
        }
        catch (Exception ex)
        {
            trans.Rollback();
            HttpContext.Current.Trace.Write("Exception in DAO.DeleteNode : " + ex.Message);
            return false;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
    public static bool Send(Info info) {
        con.Open();
        SqlTransaction trans = con.BeginTransaction();
        try
        {
            String delete = "delete info";
            String insert = "insert into info(src,cipher,datakey,dest)values(@src,@cipher,@dataKey,@dest)";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(insert, con);
            cmd.Transaction = trans;
            cmd.Parameters.AddWithValue("@src",info.Src);
            cmd.Parameters.AddWithValue("@cipher",info.Cipher);
            cmd.Parameters.AddWithValue("@dataKey",info.Key);
            cmd.Parameters.AddWithValue("@dest",info.Dest);
            cmd.ExecuteNonQuery();
            trans.Commit();
            return true;
        }
        catch (Exception ex)
        {
            trans.Rollback();
            HttpContext.Current.Trace.Write("Exception in DAO.Send : " + ex.Message);
            return false;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }


 
    }
    public static Info Recieve(String dest) {
        try
        {
            con.Open();
            String query = "select src,cipher,datakey,dest from info";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            Info info = new Info();
            if (reader.Read())
            {
                info.Src = (string)reader["src"];
                info.Cipher = (string)reader["cipher"];
                info.Key = (string)reader["dataKey"];
                info.Dest = (string)reader["dest"];
            }

            if (!info.Dest.Contains("A"))
            {
                return null;
            }
            return info;
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Exception in DAO.Receive : " + ex.Message);
            return null;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }

    }
}
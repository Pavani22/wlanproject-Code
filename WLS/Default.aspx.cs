using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
       
                try
                {

                    string mac = TextBoxMAC.Text;
                    string ip = TextBoxIP.Text;
                    string node = DropDownListNodes.SelectedItem.Text;
                    NodeModel nm = new NodeModel();
                    nm.Mac = mac;
                    nm.Ip = ip;
                    nm.Node = node;
                    //int i = 0;
                    bool add = DAL.AddNode(nm);
                    if (add)
                    {
                        LabelACK.Text = "Node Added";
                    }
                    else
                    {
                        LabelACK.Text = "Could not add node.";
                    }
                }

                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            
        
    }
    protected void TextBoxMAC_TextChanged(object sender, EventArgs e)
    {
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select mac from nodes where mac='" + TextBoxMAC.Text + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label1.Visible = true;
                Label1.Text = "the mac address already existed";
                // Response.Write("<script>alert('the mac address already exist')</script>");
            }
            else
            {
                Label1.Visible = false;
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }
    protected void TextBoxIP_TextChanged(object sender, EventArgs e)
    {
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select ip from nodes where ip='" + TextBoxIP.Text + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label2.Visible = true;
                Label2.Text = "the IP address already existed";
                // Response.Write("<script>alert('the mac address already exist')</script>");
            }
            else
            {
                Label2.Visible = false;
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }
}

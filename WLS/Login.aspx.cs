using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        string uname=TextBoxUname.Text;
        string pwd = TextBoxPwd.Text;
        Admin admin=DAL.Login(uname,pwd);
        if (admin != null)
        {
            Session.Add(admin.Uname, admin.Pwd);
            DAL.DeleteNodes();
            Response.Redirect("Default.aspx");
        }
        else {
            LabelACK.Text = "Invalid Login......";
        }
    }
}
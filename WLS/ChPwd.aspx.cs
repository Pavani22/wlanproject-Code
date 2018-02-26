using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChPwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonChPwd_Click(object sender, EventArgs e)
    {
        string opwd=TextBoxOPwd.Text;
        string npwd=TextBoxNPwd.Text;
        bool change = DAL.ChPwd(opwd, npwd);
        if (change)
        {
            LabelACK.Text = "Changed Successfully.............";
        }
        else {
            LabelACK.Text = "Could not change password...............";
        }
    }
}
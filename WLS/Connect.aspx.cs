using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Connect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string node = (string)Request.QueryString["node"];
        bool conn=DAL.ConnNode(node);
        if (conn)
        {
            Response.Redirect("Ausers.aspx?ack=Connected successfully.....");
        }
        else {
            Response.Redirect("Ausers.aspx?ack=Could not connect.......");
        }
    }
}
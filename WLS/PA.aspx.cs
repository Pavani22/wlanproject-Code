using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PA : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ack =(string)Request.QueryString["ack"];
        if (ack != null) {
            LabelACK.Text = ack;
          }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class Start : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = "";
        string node =(String)Request.QueryString["node"];
        if (node.Contains("A")) {
            path = @"E:\pramodProject\Transmission\NodeA.exe";
        }
        else if (node.Contains("B")) {
            path = @"E:\pramodProject\Transmission\Node B.exe";
       }
        else if(node.Contains("C")){
            path = @"E:\pramodProject\Transmission\NodeC.exe";
        }
        else if (node.Contains("D")) {
            path = @"E:\pramodProject\Transmission\NodeD.exe";
        }
        if (String.Empty == path)
        {
            Response.Redirect("PA.aspx?ack=Could not start ........");
        }
        else {
            Process.Start(path);
                    }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.SetCurrentContentPageName = "Home";
        ////Button btnH = (Button)Master.FindControl("btnHome");
        //Button btnA = (Button)Master.FindControl("btnAboutUs");
        //Button btnL = (Button)Master.FindControl("btnLogin");
        ////btnH.CssClass = "btndisabled";
        //btnA.CssClass = "btn";
        //btnL.CssClass = "btn";

    }
}
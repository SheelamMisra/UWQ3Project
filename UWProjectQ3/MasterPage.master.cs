using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string SetCurrentContentPageName
    {
        get { return (String)ViewState["CurrentContentPage"]; }
        set { ViewState["CurrentContentPage"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //lblCurrentPage.Text = SetCurrentContentPageName;
    }
    void Page_Init(Object sender, EventArgs e)
    {
        // activate deactivate buttons 
        if (Session != null)
        {
            btnRegister.Enabled = true;
                
        }
        else
        {
            btnRegister.Enabled = false;
            
        }

    }


    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

    protected void btnAboutUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("AboutUs.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void btnNewLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginRequest.aspx");
    }
    protected void btnAllClasses_Click(object sender, EventArgs e)
    {
        Response.Redirect("AllClasses.aspx");
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void btnMyClasses_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyClasses.aspx");
    }
}

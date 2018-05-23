using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UWProjectQ3;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void ValidateUserLogin(object sender, EventArgs e)
    {
        SqlHelper sql = new SqlHelper();
        User u = new UWProjectQ3.User(txtLogin.Text, txtPassword.Text);
        sql.GetStudentId(u);
        if (u.StudentId > 0)
        {
            Session["UserLogin"] = u.UserLogin;
            Session["StudentId"] = u.StudentId;
            Response.Redirect("MyClasses.aspx");

        }

        


    }
}
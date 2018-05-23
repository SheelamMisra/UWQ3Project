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
        User u = new User();
        SqlHelper sql = new SqlHelper();

        if (Session != null)
        {
            u.UserLogin = Session["UserLogin"].ToString();
            u.StudentId = (int)Session["StudentId"];
            sql.GetUserClasses(u);

            lstvMyClasses.DataSource = u.RegisteredClasses;
            lstvMyClasses.DataBind();

            // Add Unregiter Functionality

        }




    }
}
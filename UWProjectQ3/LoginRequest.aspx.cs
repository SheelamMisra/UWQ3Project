using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UWProjectQ3;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Master.SetCurrentContentPageName = "Login";
        //Button btnH = (Button)Master.FindControl("btnHome");
        //Button btnA = (Button)Master.FindControl("btnAboutUs");
        //Button btnL = (Button)Master.FindControl("btnLogin");
        //btnH.CssClass = "btn";
        //btnA.CssClass = "btn";
        //btnL.CssClass = "btndisabled";
    }
    public void GetUserLoginData(object sender, EventArgs e)
    {
        txtName.ID = "in the function";
        User u = new User(txtName.Text, txtLogin.Text, txtEmail.Text, txtReasonForAccess.Text);
        SqlHelper sql = new SqlHelper();
        //u.StoreUserCredentialsInFile();
        txtMessage.Text = sql.InsertLoginRequest(u);

        //Clear controls
        txtName.Text = String.Empty;
        txtLogin.Text = String.Empty;
        txtEmail.Text = String.Empty;
        txtReasonForAccess.Text = String.Empty;

    }
}
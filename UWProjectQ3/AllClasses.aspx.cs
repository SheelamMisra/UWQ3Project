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
        UWProjectQ3.SqlHelper sqlHlpr = new UWProjectQ3.SqlHelper();
        List<Clss> allClasses = new List<Clss>();
        allClasses = sqlHlpr.GetAllClasses();

        gvAllClasses.DataSource = allClasses;
        gvAllClasses.DataBind();
        //if(gvAllClasses.SelectedRow != null)
    }
    
}
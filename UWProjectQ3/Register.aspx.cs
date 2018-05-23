using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using UWProjectQ3;
public partial class _Default : System.Web.UI.Page
{
    User u;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get Seesion Values WIP Sheelam 
        //if (Session != null)
        //{
        //    u = new User(Session["UserName"].ToString(), (int)Session["StudentId"]);
        //}
        // Sheelam Debug only
        u  = new User("Sue Jones", 2);
        UWProjectQ3.SqlHelper sqlHlpr = new UWProjectQ3.SqlHelper();
        List<Clss> allClasses = new List<Clss>();
        allClasses = sqlHlpr.GetAllClasses();
        sqlHlpr.GetUserClasses(u);

        DataView dv = CreateDataSource(allClasses, u.RegisteredClasses);
        foreach (DataRowView dr in dv)
            if ((bool)dr["Registered"] == false)
                rblRegister.Items.Add(new ListItem { Text = (string)dr["Name"] + ": " + (string)dr["Descritpion"], Value = dr["Class Id"].ToString() });
            else
                rblUnregister.Items.Add(new ListItem { Text = (string)dr["Name"] + ": " + (string)dr["Descritpion"], Value = dr["Class Id"].ToString() });
        //ListItem li = new ListItem()
        //CheckBoxList1.DataSource = CreateDataSource(allClasses, u.RegisteredClasses);
        //CheckBoxList1.DataTextField ="Name";
        //CheckBoxList1.DataValueField = "Class Id";
        //CheckBoxList1.DataBind();

    }
    DataView CreateDataSource(List<Clss> lst, Dictionary<int, Clss> registeredLst)
    {
        DataTable dt = new DataTable();
        DataRow dr;

        dt.Columns.Add(new DataColumn("Class Id", typeof(Int32)));
        dt.Columns.Add(new DataColumn("Name", typeof(string)));
        dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
        dt.Columns.Add(new DataColumn("Descritpion", typeof(string)));
        dt.Columns.Add(new DataColumn("Registered", typeof(bool)));
        foreach(Clss c in lst)
        {
            dr = dt.NewRow();

            dr[0] = c.Id;
            dr[1] = c.ClassName;
            dr[2] = c.ClassDate;
            dr[3] = c.ClassDesc;
            if (registeredLst.ContainsKey(c.Id))
                dr[4] = 1;// registered
            else
                dr[4] = 0; // not yet registered
            dt.Rows.Add(dr);
        }

        DataView dv = new DataView(dt);
        return dv;
    }
    public void Index_Changed_register(Object sender, EventArgs e)
    {
        int ClassId =Convert.ToInt16(rblRegister.SelectedValue);
        //ListItem UpdatedClass = new ListItem(rblRegister.SelectedItem.Text, rblRegister.SelectedItem.Value);
        SqlHelper sql = new SqlHelper();
        sql.RegisterForClass(u, ClassId);
        //rblUnregister.Items.Add(UpdatedClass);
        // Page_Load(sender, e);
        rblRegister.ClearSelection();
        rblUnregister.ClearSelection();

        rblRegister.Items.Clear();
        rblUnregister.Items.Clear();
        Page_Load(sender, e);

    }
    public void Index_Changed_unregister(Object sender, EventArgs e)
    {
        int ClassId = Convert.ToInt16(rblUnregister.SelectedValue);
        //ListItem UpdatedClass = new ListItem(rblUnregister.SelectedItem.Text, rblUnregister.SelectedItem.Value);

        SqlHelper sql = new SqlHelper();
        sql.UnRegisterForClass(u, ClassId);
        //rblRegister.Items.Add(UpdatedClass);
        // Page_Load(sender, e);

        rblRegister.ClearSelection();
        rblUnregister.ClearSelection();

        rblRegister.Items.Clear();
        rblUnregister.Items.Clear();
        Page_Load(sender, e);

    }
}
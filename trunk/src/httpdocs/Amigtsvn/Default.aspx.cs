using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DbLinq.Data.Linq;
using DbLinq.Data.Linq.Mapping;

public partial class Administrator_Login : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        txtStatus.Text = "";
    }
    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        var result = from t in data.Users
                     join l in data.UserRole
                     on (int)t.UserID equals l.UserID
                     where t.UserNm == txtId.Text && t.Pwd == txtPass.Text && l.RoleID == 1 && t.IsActived == true && l.IsActived == true select t;
        if (result.Count() > 0)
        {
            Session["adminnm"] = txtId.Text;
            Response.Redirect("Users.aspx");
        }
        else
        {
            txtStatus.Text = "ID hoặc mật khẩu không chính xác";
        }
    }
}
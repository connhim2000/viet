using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Amigtsvn_Users : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetddRole();
            SetGridMain();
            SetlbRole();
            lblStatus.Text = "";
            lblStUserNm.Text = "";
            lblStsEmail.Text = "";
        }
    }
    protected void SetGridMain()
    {
        DataTable dtMain;
        var result = from t in data.Users
                     join l in data.UserRole
                     on (int)t.UserID equals l.UserID
                     where l.RoleID == Int32.Parse(ddRole.SelectedValue)
                     orderby t.UserID descending
                     select t;
        dtMain = Linqtodataset.LINQToDataTable(result);
        gridMain.DataSource = dtMain;
        gridMain.DataBind();
    }
    protected void SetddRole()
    {
        var result = from t in data.Role where t.IsActived == true select t;
        ddRole.DataSource = result;
        ddRole.DataTextField = "RoleNm";
        ddRole.DataValueField = "RoleId";
        ddRole.DataBind();
    }
    protected void ddRole_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetGridMain();
    }

    protected void SetlbRole()
    {
        var result = from t in data.Role where t.IsActived == true select t;
        lbRole.DataSource = result;
        lbRole.DataTextField = "RoleNm";
        lbRole.DataValueField = "RoleId";
        lbRole.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblStUserNm.Text = "";
        lblStsEmail.Text = "";
        if (CheckValid())
        {
            gtsvn.Users users = new gtsvn.Users
            {
                UserNm = txtUserName.Text,
                Pwd = txtPassword.Text,
                FullNm = txtFullNm.Text,
                Address1 = txtAddress.Text,
                Email = txtEmail.Text,
                IsActived = false,
                LastUpdt = DateTime.Now
            };
            data.Users.InsertOnSubmit(users);
            try
            {
                //submit changes to get new identity userid
                data.SubmitChanges();
                //insert into role
                int newuserid = (int)users.UserID;
                for (int i = 0; i <= lbRole.Items.Count - 1; i++)
                {
                    if (lbRole.Items[i].Selected)
                    {
                        //insert into UserRole table
                        gtsvn.UserRole userrole = new gtsvn.UserRole
                        {
                            UserID = newuserid,
                            RoleID = Int32.Parse(lbRole.Items[i].Value),
                            IsActived = true
                        };
                        data.UserRole.InsertOnSubmit(userrole);
                    }
                }
                data.SubmitChanges();
                lblStatus.Text = "Thêm thành công user <b>" + txtUserName.Text + "</b>";
                SetGridMain();
                //reset input field
                txtUserName.Text = "";
                txtFullNm.Text = "";
                txtAddress.Text = "";
                txtEmail.Text = "";
                lbRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.ToString();
            }
        }
    }
    protected void gridMain_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            Response.Redirect("UsersEdit.aspx?userid=" + e.CommandArgument.ToString());
        }
        else if (e.CommandName == "SetStatus")
        {
            var result = (from t in data.Users where t.UserID == Int32.Parse(e.CommandArgument.ToString()) && t.UserID != 1 select t).First();
            result.IsActived = result.IsActived == true ? false : true;
            try
            {
                data.SubmitChanges();
                SetGridMain();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.ToString();
            }
        }
    }

    protected bool CheckValid()
    {
        var result = from t in data.Users where t.UserNm == txtUserName.Text select t;
        var result1 = from t in data.Users where t.Email == txtEmail.Text select t;
        if (result.Count() > 0)
        {
            lblStUserNm.Text = "Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác";
            return false;
        }
        else if (result1.Count() > 0)
        {
            lblStsEmail.Text = "Email đã tồn tại. Vui lòng chọn Email khác";
            return false;
        }
        else
        {
            return true;
        }
    }
    protected void gridMain_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridMain.PageIndex = e.NewPageIndex;
        SetGridMain();
    }
}
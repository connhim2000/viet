using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Amigtsvn_UsersEdit : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetlbRole();
            LoadUser();
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtId.Text != "")
        {
            var result = (from t in data.Users where (int)t.UserID == Int32.Parse(txtId.Text) select t).First();
            result.Pwd = txtPassword.Text == "" ? result.Pwd : txtPassword.Text;
            result.FullNm = txtFullNm.Text;
            result.Address1 = txtAddress.Text;
            result.IsActived = ckActived.Checked;
            try
            {
                data.SubmitChanges();
                if(txtId.Text != "1")
                {
                    //delete old role
                    var result1 = from t in data.UserRole where t.UserID == Int32.Parse(txtId.Text) select t;
                    foreach (var res in result1)
                    {
                        data.UserRole.DeleteOnSubmit(res);
                    }
                    data.SubmitChanges();
                    //insert new role
                    for (int i = 0; i <= lbRole.Items.Count - 1; i++)
                    {
                        if (lbRole.Items[i].Selected)
                        {
                            //insert into UserRole table
                            gtsvn.UserRole userrole = new gtsvn.UserRole
                            {
                                UserID = Int32.Parse(txtId.Text),
                                RoleID = Int32.Parse(lbRole.Items[i].Value),
                                IsActived = true
                            };
                            data.UserRole.InsertOnSubmit(userrole);
                        }
                    }
                    data.SubmitChanges();
                }
                lblStatus.Text = "Thay đổi thông tin người dùng <b>" + txtUserName.Text + "</b> thành công";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Có lỗi xảy ra. Chi tiết lỗi: " + ex.ToString();
            }
        }
    }
    protected void SetlbRole()
    {
        var result = from t in data.Role where t.IsActived == true select t;
        lbRole.DataSource = result;
        lbRole.DataTextField = "RoleNm";
        lbRole.DataValueField = "RoleId";
        lbRole.DataBind();
    }
    protected void LoadUser()
    {
        if (Request.QueryString["userid"] != null)
        {
            int userid = Int32.Parse(Request.QueryString["userid"]);
            var result = (from t in data.Users where (int)t.UserID == userid select t).Single();
            {
                txtId.Text = result.UserID.ToString();
                txtUserName.Text = result.UserNm;
                txtFullNm.Text = result.FullNm;
                txtAddress.Text = result.Address1;
                txtEmail.Text = result.Email;
                ckActived.Checked = (bool)result.IsActived;
                if ((int)result.UserID == 1)
                {
                    ckActived.Enabled = false;
                }
                else
                {
                    ckActived.Enabled = true;
                }
                txtUN.Text = result.UserNm;
            }

            //fill listbox Role
            var result1 = from t in data.UserRole where t.UserID == userid select t;
            DataTable dtresult1 = Linqtodataset.LINQToDataTable(result1);
            for (int i = 0; i < dtresult1.Rows.Count; i++)
            {
                if (lbRole.Items.FindByValue(dtresult1.Rows[i]["RoleId"].ToString()) != null) // must have
                {
                    lbRole.Items.FindByValue(dtresult1.Rows[i]["RoleId"].ToString()).Selected = true;
                }
            }
        }
    }
}
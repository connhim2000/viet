using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Amigtsvn_RoleEdit : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadMain();
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblNmStatus.Text = "";
        if(CheckValid()){
            if (txtId.Text != "")
            {
                var result = (from t in data.Role where (int)t.RoleID == Int32.Parse(txtId.Text) select t).First();
                result.RoleNm = txtNm.Text;
                result.Description = txtDesc.Text;
                try
                {
                    data.SubmitChanges();
                
                    lblStatus.Text = "Thay đổi thông tin nhóm <b>" + txtNm.Text + "</b> thành công";
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Có lỗi xảy ra. Chi tiết lỗi: " + ex.ToString();
                }
            }
        }
    }

    protected void LoadMain()
    {
        if (Request.QueryString["roleid"] != null)
        {
            int roleid = Int32.Parse(Request.QueryString["roleid"]);
            var result = (from t in data.Role where (int)t.RoleID == roleid select t).Single();
            {
                txtId.Text = result.RoleID.ToString();
                txtNm.Text = result.RoleNm;
                txtDesc.Text = result.Description;
                txtUN.Text = result.RoleNm;
            }
        }
    }

    protected bool CheckValid()
    {
        var result = from t in data.Role where t.RoleNm == txtNm.Text && (int)t.RoleID != Int32.Parse(txtId.Text) select t;
        if (result.Count() > 0)
        {
            lblNmStatus.Text = "Tên nhóm đã tồn tại. Vui lòng chọn tên khác";
            return false;
        }
        else
        {
            return true;
        }
    }
}
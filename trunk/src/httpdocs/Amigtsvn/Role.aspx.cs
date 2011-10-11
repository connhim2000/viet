using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Amigtsvn_Role : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetGridMain();
        }
    }
    protected void SetGridMain()
    {
        DataTable dtMain;
        var result = from t in data.Role orderby t.RoleID descending select t;
        dtMain = Linqtodataset.LINQToDataTable(result);
        gridMain.DataSource = dtMain;
        gridMain.DataBind();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblNmStatus.Text = "";
        if (CheckValid())
        {

            gtsvn.Role roles = new gtsvn.Role
            {
                RoleNm = txtNm.Text,
                Description = txtDesc.Text,
                IsActived = true
            };
            data.Role.InsertOnSubmit(roles);
            try
            {
                //submit changes to get new identity userid
                data.SubmitChanges();
                lblStatus.Text = "Thêm thành công nhóm " + txtNm.Text;
                SetGridMain();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.ToString();
            }
            //reseet field
            txtNm.Text = "";
            txtDesc.Text = "";
        }
    }
    protected void gridMain_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            Response.Redirect("RoleEdit.aspx?roleid=" + e.CommandArgument.ToString());
        }
        else if (e.CommandName == "SetStatus")
        {
            //update Role
            var result = (from t in data.Role where t.RoleID == Int32.Parse(e.CommandArgument.ToString()) && t.RoleID != 1 select t).First();
            result.IsActived = result.IsActived == true ? false : true;
            //update UserRole
            var result1 = from t in data.UserRole where t.RoleID == Int32.Parse(e.CommandArgument.ToString()) && t.RoleID != 1 select t;
            foreach (var resl in result1)
            {
                resl.IsActived = resl.IsActived == true ? false : true;
            }
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
        var result = from t in data.Role where t.RoleNm == txtNm.Text select t;
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
    protected void gridMain_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridMain.PageIndex = e.NewPageIndex;
        SetGridMain();
    }
}
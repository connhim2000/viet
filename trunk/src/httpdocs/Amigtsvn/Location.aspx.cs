using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Amigtsvn_Location : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetddCountry();
            SetGridMain();
        }
    }
    protected void SetGridMain()
    {
        DataTable dtMain;
        var result = from t in data.Location where t.CountryID == Int32.Parse(ddCountry.SelectedValue) orderby t.LocaID descending select t;
        dtMain = Linqtodataset.LINQToDataTable(result);
        gridMain.DataSource = dtMain;
        gridMain.DataBind();
    }
    protected void SetddCountry()
    {
        var result = from t in data.Country select t;
        ddCountry.DataSource = result;
        ddCountry.DataTextField = "CountryNm";
        ddCountry.DataValueField = "CountryId";
        ddCountry.DataBind();
        //dd 1
        ddCountry1.DataSource = result;
        ddCountry1.DataTextField = "CountryNm";
        ddCountry1.DataValueField = "CountryId";
        ddCountry1.DataBind();
    }
    protected void ddCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetGridMain();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblNmStatus.Text = "";
        if (CheckValid())
        {
            gtsvn.Location loca = new gtsvn.Location
            {
                LocaNm = txtNm.Text,
                Description = txtDesc.Text,
                CountryID = Int32.Parse(ddCountry1.SelectedValue),
                Idx = txtIdx.Text == "" ? 99 : double.Parse(txtIdx.Text),
                IsActived = true
            };
            data.Location.InsertOnSubmit(loca);
            try
            {
                //submit changes to get new identity userid
                data.SubmitChanges();
                lblStatus.Text = "Thêm thành công địa điểm " + txtNm.Text;
                ddCountry.SelectedValue = ddCountry1.SelectedValue;
                SetGridMain();
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
            Response.Redirect("LocationEdit.aspx?locaid=" + e.CommandArgument.ToString());
        }
        else if (e.CommandName == "SetStatus")
        {
            var result = (from t in data.Location where t.LocaID == Int32.Parse(e.CommandArgument.ToString()) select t).First();
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

    protected void gridMain_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridMain.PageIndex = e.NewPageIndex;
        SetGridMain();
    }

    protected bool CheckValid()
    {
        var result = from t in data.Location where t.LocaNm == txtNm.Text select t;
        if (result.Count() > 0)
        {
            lblNmStatus.Text = "Tên địa điểm đã tồn tại. Vui lòng chọn tên khác";
            return false;
        }
        else
        {
            return true;
        }
    }
}
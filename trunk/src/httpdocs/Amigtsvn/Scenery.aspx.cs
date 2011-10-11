using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Amigtsvn_Scenery : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetddLoca();
            SetGridMain();
        }
    }
    protected void SetGridMain()
    {
        DataTable dtMain;
        var result = from t in data.Scenery where t.LocaID == Int32.Parse(ddLoca.SelectedValue)
                     orderby t.ScenID descending
                     select t;
        dtMain = Linqtodataset.LINQToDataTable(result);
        gridMain.DataSource = dtMain;
        gridMain.DataBind();
    }
    protected void SetddLoca()
    {
        var result = from t in data.Location where t.IsActived == true select t;
        ddLoca.DataSource = result;
        ddLoca.DataTextField = "LocaNm";
        ddLoca.DataValueField = "LocaId";
        ddLoca.DataBind();

        //set ddloca1
        ddLoca1.DataSource = result;
        ddLoca1.DataTextField = "LocaNm";
        ddLoca1.DataValueField = "LocaId";
        ddLoca1.DataBind();
    }
    protected void ddLoca_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetGridMain();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        gtsvn.Scenery scen = new gtsvn.Scenery
        {
            ScenNm = txtNm.Text,
            DescReview = txtDescRev.Text,
            Description = CKEditor1.Text,
            LocaID = Int32.Parse(ddLoca1.SelectedValue),
            IsActived = true,
        };
        data.Scenery.InsertOnSubmit(scen);
        try
        {
            data.SubmitChanges();
            lblStatus.Text = "Thêm thành công địa điểm du lịch " + txtNm.Text;
            ddLoca.SelectedValue = ddLoca1.SelectedValue;
            SetGridMain();
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.ToString();
        }
    }
    protected void gridMain_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            Response.Redirect("SceneryEdit.aspx?scenid=" + e.CommandArgument.ToString());
        }
        else if (e.CommandName == "SetStatus")
        {
            var result = (from t in data.Scenery where t.ScenID == Int32.Parse(e.CommandArgument.ToString()) select t).First();
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
        else if (e.CommandName == "Picture")
        {
            Response.Redirect("Pictures.aspx?kind=scen&id=" + e.CommandArgument.ToString());
        }
    }
    protected void gridMain_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridMain.PageIndex = e.NewPageIndex;
        SetGridMain();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Amigtsvn_Tour : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetddGroup();
            SetGridMain();
            SetlbKind();
            lblStatus.Text = "";
        }
    }
    protected void SetGridMain()
    {
        DataTable dtMain;
        var result = from t in data.Tour
                     where t.TourGroup == Int32.Parse(ddGroup.SelectedValue)
                     orderby t.TourID descending
                     select t;
        dtMain = Linqtodataset.LINQToDataTable(result);
        gridMain.DataSource = dtMain;
        gridMain.DataBind();
    }
    protected void SetddGroup()
    {
        var result = from t in data.TourGroup where t.IsActived == true select t;
        ddGroup.DataSource = result;
        ddGroup.DataTextField = "TourGroupNm";
        ddGroup.DataValueField = "TourGroupId";
        ddGroup.DataBind();

        //set dd group 1
        ddGroup1.DataSource = result;
        ddGroup1.DataTextField = "TourGroupNm";
        ddGroup1.DataValueField = "TourGroupId";
        ddGroup1.DataBind();
    }
    protected void ddGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetGridMain();
    }

    protected void SetlbKind()
    {
        var result = from t in data.TourKind where t.IsActived == true select t;
        lbKind.DataSource = result;
        lbKind.DataTextField = "TourKindNm";
        lbKind.DataValueField = "TourKindId";
        lbKind.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        if (CheckValid())
        {
            gtsvn.Tour tour = new gtsvn.Tour
            {
                TourNm = txtNm.Text,
                DescReview = txtDescRev.Text,
                TourReview = CKEditor1.Text,
                Description = CKEditor2.Text,
                TourGroup = Int32.Parse(ddGroup1.SelectedValue),
                IsPromotion = cbPromotion.Checked,
                IsProminent = cbProminent.Checked,
                IsActived = true,
                InsDate = DateTime.Now
            };
            data.Tour.InsertOnSubmit(tour);
            try
            {
                //submit changes to get new identity userid
                data.SubmitChanges();
                //insert into role
                int newtourid = (int)tour.TourID;
                for (int i = 0; i <= lbKind.Items.Count - 1; i++)
                {
                    if (lbKind.Items[i].Selected)
                    {
                        //insert into UserRole table
                        gtsvn.TourTourKind tourtourkind = new gtsvn.TourTourKind
                        {
                            TourID = newtourid,
                            TourKindID = Int32.Parse(lbKind.Items[i].Value)
                        };
                        data.TourTourKind.InsertOnSubmit(tourtourkind);
                    }
                }
                data.SubmitChanges();
                lblStatus.Text = "Thêm thành công tour <b>" + txtNm.Text + "</b>";
                ddGroup.SelectedValue = ddGroup1.SelectedValue;
                SetGridMain();
                //reset input field
                txtNm.Text = "";
                txtDescRev.Text = "";
                CKEditor1.Text = "";
                CKEditor2.Text = "";
                ddGroup1.SelectedIndex = 0;
                cbPromotion.Checked = false;
                cbProminent.Checked = false;
                lbKind.SelectedIndex = -1;
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
            Response.Redirect("TourEdit.aspx?tourid=" + e.CommandArgument.ToString());
        }
        else if (e.CommandName == "SetStatus")
        {
            var result = (from t in data.Tour where t.TourID == Int32.Parse(e.CommandArgument.ToString()) select t).First();
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
            Response.Redirect("Pictures.aspx?kind=tour&id=" + e.CommandArgument.ToString());
        }
    }

    protected bool CheckValid()
    {
        return true;
    }
    protected void gridMain_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridMain.PageIndex = e.NewPageIndex;
        SetGridMain();
    }
}
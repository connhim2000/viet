using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Amigtsvn_Pictures : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["kind"] != null && Request.QueryString["id"] != null)
            {
                lblKind.Text = Request.QueryString["kind"].ToString();
                lblId.Text = Request.QueryString["id"].ToString();
            }
            //upload cac loai anh khac, click truc tiep tren menu
            else
            {
                lblKind.Text = "misc";
                lblId.Text = "";
            }
            lblLoadSts.Text = "";

            if (lblKind.Text == "tour")
            {
                var result = from t in data.Tour where (int)t.TourID == Int32.Parse(lblId.Text) select t;
                if (result.Count() > 0)
                {
                    lblKindNm.Text = "tour";
                    lblNm.Text = result.Single().TourNm;
                    lblLoadSts.Text = "True";
                }
                else
                {
                    Response.Redirect("../FileNotFound.aspx");
                }
            }
            else if (lblKind.Text == "hotel")
            {
                var result = from t in data.Hotel where (int)t.HotelID == Int32.Parse(lblId.Text) select t;
                if (result.Count() > 0)
                {
                    lblKindNm.Text = "khách sạn";
                    lblNm.Text = result.Single().HotelNm;
                    lblLoadSts.Text = "True";
                }
                else
                {
                    Response.Redirect("../FileNotFound.aspx");
                }
            }
            else if (lblKind.Text == "scen")
            {
                var result = from t in data.Scenery where (int)t.ScenID == Int32.Parse(lblId.Text) select t;
                if (result.Count() > 0)
                {
                    lblKindNm.Text = "địa điểm du lịch";
                    lblNm.Text = result.Single().ScenNm;
                    lblLoadSts.Text = "True";
                }
                else
                {
                    Response.Redirect("../FileNotFound.aspx");
                }
            }
            else if (lblKind.Text == "event")
            {
                var result = from t in data.Event where (int)t.EventID == Int32.Parse(lblId.Text) select t;
                if (result.Count() > 0)
                {
                    lblKindNm.Text = "sự kiện";
                    lblNm.Text = result.Single().EventNm;
                    lblLoadSts.Text = "True";
                }
                else
                {
                    Response.Redirect("../FileNotFound.aspx");
                }
            }
            else if (lblKind.Text == "misc")
            {
                lblKindNm.Text = "website";
                lblNm.Text = "";
                lblLoadSts.Text = "True";
            }
        } //end postback
        //load table
        LoadGridMain(lblId.Text, lblKind.Text);
    }

    protected void LoadGridMain(string id, string kind)
    {
        DataTable dtMain;
        if (id != "")
        {
            var result = from t in data.Pictures where t.PicKind == kind && t.ItemsID == Int32.Parse(id) select t;
            dtMain = Linqtodataset.LINQToDataTable(result);
        }
        else
        {
            var result = from t in data.Pictures where t.PicKind == kind select t;
            dtMain = Linqtodataset.LINQToDataTable(result);
        }
        gridMain.DataSource = dtMain;
        gridMain.DataBind();
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        /*String status = "";
        try
        {
            // Get the HttpFileCollection
            HttpFileCollection hfc = Request.Files;
            for (int i = 0; i < hfc.Count; i++)
            {
                HttpPostedFile hpf = hfc[i];
                if (hpf.ContentLength > 0 && hpf.ContentLength < 2097152)  //<2Mb
                {
                    //Save to database
                    gtsvn.Pictures pic = new gtsvn.Pictures
                    {
                        
                    };
                    data.Users.InsertOnSubmit(users);
                    data.SubmitChanges();
                    //Save to disk
                    hpf.SaveAs(Server.MapPath("~/Customer-Ecard/customer_pics/") + "\\" + dateul + System.IO.Path.GetFileName(hpf.FileName));
                    status = status + "<b>Tên: </b>" + hpf.FileName + " <b>Độ lớn:</b> " +
                        hpf.ContentLength + " <b>Loại:</b> " + hpf.ContentType + " <span style='color: blue'>Upload thành công</span> <br/>";
                }
                else
                {
                    status = status + "<b>Tên: </b>" + hpf.FileName + " <b>Độ lớn:</b> " +
                        hpf.ContentLength + " <b>Loại:</b> " + hpf.ContentType + " <span style='color: red'>Upload không thành công</span> <br/>";
                }
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.ToString();
        }
        lblStatus.Text = status;*/
    }
    protected void gridMain_RowCommand(object sender, GridViewCommandEventArgs e)
    {
    }

    protected void gridMain_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridMain.PageIndex = e.NewPageIndex;
        //SetGridMain();
    }
}
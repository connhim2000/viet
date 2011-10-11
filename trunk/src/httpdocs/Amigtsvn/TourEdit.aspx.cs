using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Amigtsvn_TourEdit : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetlbKind();
            SetddGroup();
            LoadMain();
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtId.Text != "")
        {
            var result = (from t in data.Tour where (int)t.TourID == Int32.Parse(txtId.Text) select t).First();
            result.TourNm = txtNm.Text;
            result.DescReview = txtDescRev.Text;
            result.TourReview = CKEditor1.Text;
            result.Description = CKEditor2.Text;
            result.TourGroup = Int32.Parse(ddGroup1.SelectedValue);
            result.IsPromotion = (bool)cbPromotion.Checked;
            result.IsProminent = (bool)cbProminent.Checked;
            result.InsDate = DateTime.Now;
            try
            {
                data.SubmitChanges();
                //delete old tour tourkind
                var result1 = from t in data.TourTourKind where t.TourID == Int32.Parse(txtId.Text) select t;
                foreach (var res in result1)
                {
                    data.TourTourKind.DeleteOnSubmit(res);
                }
                data.SubmitChanges();
                //insert new tour tourkind
                for (int i = 0; i <= lbKind.Items.Count - 1; i++)
                {
                    if (lbKind.Items[i].Selected)
                    {
                        //insert into TourTourKind table
                        gtsvn.TourTourKind tourtourkind = new gtsvn.TourTourKind
                        {
                            TourID = Int32.Parse(txtId.Text),
                            TourKindID = Int32.Parse(lbKind.Items[i].Value)
                        };
                        data.TourTourKind.InsertOnSubmit(tourtourkind);
                    }
                }
                data.SubmitChanges();
                lblStatus.Text = "Thay đổi thông tin tour <b>" + txtNm.Text + "</b> thành công";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Có lỗi xảy ra. Chi tiết lỗi: " + ex.ToString();
            }
        }
    }

    protected void SetlbKind()
    {
        var result = from t in data.TourKind where t.IsActived == true select t;
        lbKind.DataSource = result;
        lbKind.DataTextField = "TourKindNm";
        lbKind.DataValueField = "TourKindId";
        lbKind.DataBind();
    }

    protected void SetddGroup()
    {
        var result = from t in data.TourGroup where t.IsActived == true select t;
        ddGroup1.DataSource = result;
        ddGroup1.DataTextField = "TourGroupNm";
        ddGroup1.DataValueField = "TourGroupId";
        ddGroup1.DataBind();
    }

    protected void LoadMain()
    {
        if (Request.QueryString["tourid"] != null)
        {
            int tourid = Int32.Parse(Request.QueryString["tourid"]);
            var result = (from t in data.Tour where (int)t.TourID == tourid select t).Single();
            {
                txtId.Text = result.TourID.ToString();
                txtNm.Text = result.TourNm;
                txtDescRev.Text = result.DescReview;
                CKEditor1.Text = result.TourReview;
                CKEditor2.Text = result.Description;
                ddGroup1.SelectedValue = result.TourGroup.ToString();
                cbPromotion.Checked = (bool)result.IsPromotion;
                cbProminent.Checked = (bool)result.IsProminent;
            }

            //fill listbox Role
            var result1 = from t in data.TourTourKind where t.TourID == tourid select t;
            DataTable dtresult1 = Linqtodataset.LINQToDataTable(result1);
            for (int i = 0; i < dtresult1.Rows.Count; i++)
            {
                if (lbKind.Items.FindByValue(dtresult1.Rows[i]["TourKindId"].ToString()) != null) // must have
                {
                    lbKind.Items.FindByValue(dtresult1.Rows[i]["TourKindId"].ToString()).Selected = true;
                }
            }
        }
    }
}
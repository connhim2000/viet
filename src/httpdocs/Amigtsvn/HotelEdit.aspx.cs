using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Amigtsvn_HotelEdit : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetddLoca();
            LoadMain();
        }
    }

    protected void SetddLoca()
    {
        var result = from t in data.Location select t;
        ddLoca1.DataSource = result;
        ddLoca1.DataTextField = "LocaNm";
        ddLoca1.DataValueField = "LocaId";
        ddLoca1.DataBind();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (CheckValid())
        {
            if (txtId.Text != "")
            {
                var result = (from t in data.Hotel where (int)t.HotelID == Int32.Parse(txtId.Text) select t).First();
                result.HotelNm = txtNm.Text;
                result.Star = Int32.Parse(txtStar.Text);
                result.Price = txtPrice.Text;
                result.DescReview = txtDescRev.Text;
                result.Description = CKEditor1.Text;
                result.LocaID = Int32.Parse(ddLoca1.SelectedValue);
                try
                {
                    data.SubmitChanges();

                    lblStatus.Text = "Thay đổi thông tin khách sạn <b>" + txtNm.Text + "</b> thành công";
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
        if (Request.QueryString["hotelid"] != null)
        {
            int hotelid = Int32.Parse(Request.QueryString["hotelid"]);
            var result = (from t in data.Hotel where (int)t.HotelID == hotelid select t).Single();
            {
                txtId.Text = result.HotelID.ToString();
                txtNm.Text = result.HotelNm;
                txtStar.Text = result.Star.ToString();
                txtPrice.Text = result.Price;
                txtDescRev.Text = result.DescReview;
                CKEditor1.Text = result.Description;
                ddLoca1.SelectedValue = result.LocaID.ToString();
                txtUN.Text = result.HotelNm;
            }
        }
    }

    protected bool CheckValid()
    {
        return true;
    }
}
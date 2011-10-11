using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Amigtsvn_LocationEdit : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetddCountry();
            LoadMain();
        }
    }

    protected void SetddCountry()
    {
        var result = from t in data.Country select t;
        ddCountry1.DataSource = result;
        ddCountry1.DataTextField = "CountryNm";
        ddCountry1.DataValueField = "CountryId";
        ddCountry1.DataBind();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblNmStatus.Text = "";
        if (CheckValid())
        {
            if (txtId.Text != "")
            {
                var result = (from t in data.Location where (int)t.LocaID == Int32.Parse(txtId.Text) select t).First();
                result.LocaNm = txtNm.Text;
                result.Description = txtDesc.Text;
                result.Idx = txtIdx.Text == "" ? 99 : double.Parse(txtIdx.Text);
                result.CountryID = Int32.Parse(ddCountry1.SelectedValue);
                try
                {
                    data.SubmitChanges();

                    lblStatus.Text = "Thay đổi thông tin địa điểm <b>" + txtNm.Text + "</b> thành công";
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
        if (Request.QueryString["locaid"] != null)
        {
            int locaid = Int32.Parse(Request.QueryString["locaid"]);
            var result = (from t in data.Location where (int)t.LocaID == locaid select t).Single();
            {
                txtId.Text = result.LocaID.ToString();
                txtNm.Text = result.LocaNm;
                txtDesc.Text = result.Description;
                txtIdx.Text = result.Idx.ToString();
                ddCountry1.SelectedValue = result.CountryID.ToString();
                txtUN.Text = result.LocaNm;
            }
        }
    }

    protected bool CheckValid()
    {
        var result = from t in data.Location where t.LocaNm == txtNm.Text && (int)t.LocaID != Int32.Parse(txtId.Text) select t;
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
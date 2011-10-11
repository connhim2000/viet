using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Amigtsvn_SceneryEdit : System.Web.UI.Page
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
                var result = (from t in data.Scenery where (int)t.ScenID == Int32.Parse(txtId.Text) select t).First();
                result.ScenNm = txtNm.Text;
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
        if (Request.QueryString["scenid"] != null)
        {
            int scenid = Int32.Parse(Request.QueryString["scenid"]);
            var result = (from t in data.Scenery where (int)t.ScenID == scenid select t).Single();
            {
                txtId.Text = result.ScenID.ToString();
                txtNm.Text = result.ScenNm;
                txtDescRev.Text = result.DescReview;
                CKEditor1.Text = result.Description;
                ddLoca1.SelectedValue = result.LocaID.ToString();
                txtUN.Text = result.ScenNm;
            }
        }
    }

    protected bool CheckValid()
    {
        return true;
    }
}
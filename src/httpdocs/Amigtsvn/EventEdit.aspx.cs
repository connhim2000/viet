using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Amigtsvn_EventEdit : System.Web.UI.Page
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
                var result = (from t in data.Event where (int)t.EventID == Int32.Parse(txtId.Text) select t).First();
                result.EventNm = txtNm.Text;
                result.Description = CKEditor1.Text;
                result.LocaID = Int32.Parse(ddLoca1.SelectedValue);
                result.FromDate = DateTime.ParseExact(txtFrom.Text, CalendarExtender1.Format, null);
                result.ToDate = DateTime.ParseExact(txtTo.Text, CalendarExtender2.Format, null);
                try
                {
                    data.SubmitChanges();

                    lblStatus.Text = "Thay đổi thông tin sự kiện <b>" + txtNm.Text + "</b> thành công";
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
        if (Request.QueryString["eventid"] != null)
        {
            int eventid = Int32.Parse(Request.QueryString["eventid"]);
            var result = (from t in data.Event where (int)t.EventID == eventid select t).Single();
            {
                txtId.Text = result.EventID.ToString();
                txtNm.Text = result.EventNm;
                CKEditor1.Text = result.Description;
                ddLoca1.SelectedValue = result.LocaID.ToString();
                txtUN.Text = result.EventNm;
                txtFrom.Text = result.FromDate.Value.ToString("dd/MM/yyyy");
                txtTo.Text = result.ToDate.Value.ToString("dd/MM/yyyy");
            }
        }
    }

    protected bool CheckValid()
    {
        return true;
    }
}
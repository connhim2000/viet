using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KhachSan : System.Web.UI.Page
{
    DataClassesDataContext data = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Page.MaintainScrollPositionOnPostBack = false;
            GetLoca();
            GetHotel();
        }
    }
    protected void GetLoca()
    {
        var result = from t in data.Locations where t.IsActive == true select t;
        RepLoca.DataSource = result;
        RepLoca.DataBind();
    }
    protected void GetHotel()
    {
        if (Request.QueryString["LocaId"] != null)
        {
            int LocaId = Int32.Parse(Request.QueryString["LocaId"]);
            var result = from t in data.Hotels where t.LocaId == LocaId && t.IsActive == true select t;
            RepHotel.DataSource = result;
            RepHotel.DataBind();
        }
        else
        {
            var result = from t in data.Hotels where t.IsActive == true select t;
            RepHotel.DataSource = result;
            RepHotel.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TourTuChon : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));

    protected void Page_Load(object sender, EventArgs e)
    {
        //Page.MaintainScrollPositionOnPostBack = false;
        if (!IsPostBack)
        {
            GetTourKind();
        }
        GetTuChon();
    }

    protected void GetTourKind()
    {
        var result = from t in data.TourKind where t.IsActived == true select t;
        RepTourKind.DataSource = result;
        RepTourKind.DataBind();
    }

    protected void GetTuChon()
    {
        DataTable dtTronGoi;
        if (Request.QueryString["TourKindId"] != null)
        {
            int TourKindId = Int32.Parse(Request.QueryString["TourKindId"]);
            var result = from t in data.Tour
                         join l in data.TourTourKind
                         on (int)t.TourID equals l.TourID
                         where l.TourKindID == TourKindId && t.IsActived == true && t.TourGroup == 2
                         select t;
            dtTronGoi = Linqtodataset.LINQToDataTable(result);
        }
        else
        {
            var result = from t in data.Tour where t.IsActived == true && t.TourGroup == 2 select t;
            dtTronGoi = Linqtodataset.LINQToDataTable(result);
        }
        CollectionPager1.PageSize = 4;
        CollectionPager1.DataSource = dtTronGoi.DefaultView;
        CollectionPager1.BindToControl = RepTronGoi;
        RepTronGoi.DataSource = CollectionPager1.DataSourcePaged;
    }
}
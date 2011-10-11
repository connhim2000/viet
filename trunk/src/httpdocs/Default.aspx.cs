using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        //Page.MaintainScrollPositionOnPostBack = false;
        if (!IsPostBack)
        {
        }
        GetPromotion();
        GetProminent();
    }

    protected void GetPromotion()
    {
        DataTable dtPromotion;
        var result = from t in data.Tour where t.IsActived == true && t.IsPromotion == true orderby t.TourID descending select t;
        dtPromotion = Linqtodataset.LINQToDataTable(result);
        CollectionPager1.PageSize = 4;
        CollectionPager1.DataSource = dtPromotion.DefaultView;
        CollectionPager1.BindToControl = RepPromotion;
        RepPromotion.DataSource = CollectionPager1.DataSourcePaged;
    }

    protected void GetProminent()
    {
        DataTable dtProminent;
        var result = from t in data.Tour where t.IsActived == true && t.IsProminent == true orderby t.TourID descending select t;
        dtProminent = Linqtodataset.LINQToDataTable(result);
        CollectionPager2.PageSize = 4;
        CollectionPager2.DataSource = dtProminent.DefaultView;
        CollectionPager2.BindToControl = dlProminent;
        dlProminent.DataSource = CollectionPager2.DataSourcePaged;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SuKien : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
        GetEvent();
    }

    protected void GetEvent()
    {
        DataTable dtMain;
        var result = from t in data.Event
                     join l in data.Location
                     on t.LocaID equals (int)l.LocaID
                     where t.IsActived == true
                     orderby t.FromDate descending
                     select new
                     {
                         t.EventID,
                         t.EventNm,
                         t.Description,
                         t.FromDate,
                         t.ToDate,
                         t.LocaID,
                         l.LocaNm
                     };
        dtMain = Linqtodataset.LINQToDataTable(result);
        CollectionPager1.PageSize = 4;
        CollectionPager1.DataSource = dtMain.DefaultView;
        CollectionPager1.BindToControl = repMain;
        repMain.DataSource = CollectionPager1.DataSourcePaged;
    }
}
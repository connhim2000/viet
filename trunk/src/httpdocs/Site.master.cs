using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DbLinq.Data.Linq;
using DbLinq.Data.Linq.Mapping;

public partial class Site : System.Web.UI.MasterPage
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.MaintainScrollPositionOnPostBack = false;
        if (!IsPostBack)
        {
            GetRep();
        }
    }

    protected void GetRep()
    {
        var result = from t in data.TourKind where t.IsActived == true select t;
        repTronGoi.DataSource = result;
        repTronGoi.DataBind();
        repTuChon.DataSource = result;
        repTuChon.DataBind();
    }
}

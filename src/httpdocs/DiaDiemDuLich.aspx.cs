﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DbLinq.Data.Linq;
using DbLinq.Data.Linq.Mapping;

public partial class DiaDiemDuLich : System.Web.UI.Page
{
    gtsvn.GTSdB data = new gtsvn.GTSdB(new MySql.Data.MySqlClient.MySqlConnection(AppConfig.DbConnectionString));
    protected void Page_Load(object sender, EventArgs e)
    {
        //Page.MaintainScrollPositionOnPostBack = false;
        if (!IsPostBack)
        {
            GetLoca();
        }
        GetScen();
    }
    protected void GetLoca()
    {
        var result = from t in data.Location where t.IsActived == true orderby t.Idx select t;
        RepLoca.DataSource = result;
        RepLoca.DataBind();
    }
    protected void GetScen()
    {
        DataTable dtScen;
        if (Request.QueryString["LocaId"] != null)
        {
            int LocaId = Int32.Parse(Request.QueryString["LocaId"]);
            var result = from t in data.Scenery where t.LocaID == LocaId && t.IsActived == true select t;
            dtScen = Linqtodataset.LINQToDataTable(result);
            //RepHotel.DataSource = result;
            //RepHotel.DataBind();
        }
        else
        {
            var result = from t in data.Scenery where t.IsActived == true select t;
            dtScen = Linqtodataset.LINQToDataTable(result);
            //RepHotel.DataSource = result;
            //RepHotel.DataBind();
        }
        CollectionPager1.PageSize = 4;
        CollectionPager1.DataSource = dtScen.DefaultView;
        CollectionPager1.BindToControl = RepScen;
        RepScen.DataSource = CollectionPager1.DataSourcePaged;
    }
}
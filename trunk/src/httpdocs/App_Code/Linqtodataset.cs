using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;

/// <summary>
/// Summary description for Linqtodataset
/// </summary>
public class Linqtodataset
{
    public static DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
    {
        DataTable dtReturn = new DataTable();

        // column names 
        System.Reflection.PropertyInfo[] oProps = null; 

        if (varlist == null) return dtReturn;

        foreach (T rec in varlist)
        {
             // Use reflection to get property names, to create table, Only first time, others 
             //will follow 
             if (oProps == null)
             {
                  oProps = ((Type)rec.GetType()).GetProperties();
                  foreach (System.Reflection.PropertyInfo pi in oProps)
                  {
                       Type colType = pi.PropertyType;

                       if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()      
                       ==typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                       dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                  }
             }

             DataRow dr = dtReturn.NewRow();

             foreach (System.Reflection.PropertyInfo pi in oProps)
             {
                  dr[pi.Name] = pi.GetValue(rec, null) == null ?DBNull.Value :pi.GetValue
                  (rec,null);
             }

             dtReturn.Rows.Add(dr);
        }
        return dtReturn;
    }

}

using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MedicalRecordStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsMedicalRecord clsmedicalRecord = new clsMedicalRecord();
        DataTable dT = clsmedicalRecord.StatisticsGroupedByDob();
        GridViewStGroupByDob.DataSource = dT;
        GridViewStGroupByDob.DataBind();

        GridViewStGroupByDob.HeaderRow.Cells[0].Text = "Total";

        dT = clsmedicalRecord.StatisticsGroupedBySex();
        GridViewStGroupBySex.DataSource = dT;
        GridViewStGroupBySex.DataBind();
        GridViewStGroupBySex.HeaderRow.Cells[0].Text = "Total";

    }
}
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DoctorManagementStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsDoctor clsdoctor = new clsDoctor();

        //retrieve the data from the database
        DataTable dT = clsdoctor.StatisticsGroupedByDepartment();

        //upload dT into the GridView
        GridViewGroupByDepartment.DataSource = dT;
        GridViewGroupByDepartment.DataBind();

        //change the header text of the first column
        GridViewGroupByDepartment.HeaderRow.Cells[0].Text = " Total ";

        //retrieve the data from the database
        dT = clsdoctor.StatisticsGroupedContactDate();

        //upload dT into the GridView
        GridViewGroupByContractDate.DataSource = dT;
        GridViewGroupByContractDate.DataBind();

        //change the header text of the first column
        GridViewGroupByContractDate.HeaderRow.Cells[0].Text = " Total ";


    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        //redirect to the data entry page
        Response.Redirect("DoctorDataEntry.aspx");
    }
}
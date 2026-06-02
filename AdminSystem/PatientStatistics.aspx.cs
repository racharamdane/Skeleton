using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;  
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {ClsPatient Clspatient = new ClsPatient();
        //retrieve the data from the database 
        DataTable dt = Clspatient.StaticsGroupedByPatientgender();
        // upload the data to the gridview
        GridViewStGroupByPatientgender.DataSource = dt;
        GridViewStGroupByPatientgender.DataBind();

        //change the header of the first column
        GridViewStGroupByPatientgender.HeaderRow.Cells[0].Text = "Total";

        //retrieve the data from the database
        dt = Clspatient.StaticsGroupedByPatientregistrationdate();
        //upload dT into GridView
        GridViewStGroupByPatientregistrationdate.DataSource = dt;
        GridViewStGroupByPatientregistrationdate.DataBind();

        //change the header of the first column
        GridViewStGroupByPatientregistrationdate.HeaderRow.Cells[0].Text = "Total";


    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        //redirect to the data entry page
        Response.Redirect("PatientDataEntry.aspx");
    }
}
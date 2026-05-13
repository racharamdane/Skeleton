using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
                if (IsPostBack == false)
                {
                    // update the list box
                    DisplayPatients();
        }

    }
    void DisplayPatients()
    {         // create an instance of the patient collection
        ClsPatientCollection Patients = new ClsPatientCollection();
        // set the data source to the list of patients in the collection
        lstPatientList.DataSource = Patients.PatientList;
        // set the name of the primary key
        lstPatientList.DataValueField = "PatientID";
        // set the data field to display
        lstPatientList.DataTextField = "FullName";
        // bind the data to the list
        lstPatientList.DataBind();
    }
}
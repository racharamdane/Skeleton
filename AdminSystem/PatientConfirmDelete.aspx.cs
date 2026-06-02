using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 PatientID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the patients to be deleted from the session object
        PatientID = Convert.ToInt32(Session["PatientID"]);


    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the patient collection
        ClsPatientCollection Patient = new ClsPatientCollection();
        //find the record to delete
        Patient.ThisPatient.Find(PatientID);
        //delete the record
        Patient.Delete();
        //redirect back to the main page
        Response.Redirect("PatientList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("PatientList.aspx");
    }
}
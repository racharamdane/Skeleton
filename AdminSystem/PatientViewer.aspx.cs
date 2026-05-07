using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create an instance of the patient class
        ClsPatient APatient = new ClsPatient();
        // get the data from the session object
        APatient = (ClsPatient)Session["APatient"];
        // display the patient data for this entry
        Response.Write(APatient.FullName + "<br/>");
        Response.Write(APatient.DateAdded + "<br/>");
        Response.Write(APatient.Email + "<br/>");
        Response.Write(APatient.PatientGender + "<br/>");
        Response.Write(APatient.PatientPassword + "<br/>");
        Response.Write(APatient.Treatment + "<br/>");
    }
}
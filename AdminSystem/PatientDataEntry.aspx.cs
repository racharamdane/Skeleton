using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsPatient
        ClsPatient APatient = new ClsPatient();
        // Get the data entered by the user
        APatient.FullName = txtPatientfullname.Text;
        //Store the data in the session object
        Session["APatient"] = APatient;
        // capture the patient date of birth
          APatient.DateAdded = Convert.ToDateTime(txtPatientdateofbirth.Text);
        // capture the patient email
        APatient.Email = txtPatientemail.Text;
        // capture the patient gender
        APatient.PatientGender = txtPatientgender.Text;
        // capture the patient password
         APatient.PatientPassword = txtPatientpassword.Text;
        // capture the patient treatment status
        APatient.Treatment = chkPatienttreatment.Checked;
        //Navigate to the next page
        Response.Redirect("PatientViewer.aspx");
    }
}
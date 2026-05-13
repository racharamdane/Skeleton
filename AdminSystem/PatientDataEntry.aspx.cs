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

        // capture the patient full name
        string FullName = txtPatientfullname.Text;
        // capture the patient date of registration
        string DateAdded = txtPatientregistrationdate.Text;
        // capture the patient email
        string Email = txtPatientemail.Text;
        // capture the patient gender
        string PatientGender = txtPatientgender.Text;
        // capture the patient password
        string PatientPassword = txtPatientpassword.Text;
        // capture the patient treatment status
        string Treatment = chkPatienttreatment.Text;
        // variable to store any error messages
        string Error = "";
        // validate the data
        Error = APatient.Valid(FullName, Email, PatientGender, PatientPassword, DateAdded);
        if (Error == "")
        {
            // capture the patient full name
            APatient.FullName = FullName;
            // capture the patient date of registration
            APatient.DateAdded = Convert.ToDateTime(DateAdded);
            // capture the patient email
            APatient.Email = Email;
            // capture the patient gender
            APatient.PatientGender = PatientGender;
            // capture the patient password
            APatient.PatientPassword = PatientPassword;
           

            //Navigate to the next page
            Response.Redirect("PatientViewer.aspx");

        }
        else
        {
            // display the error message
            lblError.Text = Error;
        }   
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
     
        // Create a new instance of clsPatient
        ClsPatient APatient = new ClsPatient();
        // Variable to store the primary key
        Int32 PatientID;
        // Variable to store the result of the find operation
        Boolean Found = false;
        // Get the primary key entered by the user
        PatientID = Convert.ToInt32(txtPatientID.Text);
        // Find the record with the primary key
        Found = APatient.Find(PatientID);
        // If found
        if (Found == true)
        {
            // Display the values of the properties in the form
            txtPatientfullname.Text = APatient.FullName;
            txtPatientregistrationdate.Text = APatient.DateAdded.ToString("dd/MM/yyyy");
            txtPatientemail.Text = APatient.Email;
            txtPatientgender.Text = APatient.PatientGender;
            txtPatientpassword.Text = APatient.PatientPassword;
            chkPatienttreatment.Checked = APatient.Treatment;
        }
    }

}
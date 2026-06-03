using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    Int32 PatientID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the patient to be processed
        PatientID = Convert.ToInt32(Session["PatientID"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (PatientID != -1)
            {
                // display the current data for the record
                DisplayPatient();
            }
        }   
    }

    private void DisplayPatient()
    {
      //create an instance of the patient 
      ClsPatientCollection Patient = new ClsPatientCollection();
        //find the record to update
        Patient.ThisPatient.Find(PatientID);
        //display the data for this record
        txtPatientfullname.Text = Convert.ToString(Patient.ThisPatient.PatientID);
        txtPatientEmail.Text = Convert.ToString(Patient.ThisPatient.Email);
        txtPatientgender.Text = Convert.ToString(Patient.ThisPatient.PatientGender);
        txtPatientpassword.Text = Convert.ToString(Patient.ThisPatient.PatientPassword);
        txtPatientregistrationdate.Text = Convert.ToString(Patient.ThisPatient.DateAdded);
        chkPatienttreatment.Checked = Patient.ThisPatient.Treatment;
        txtPatientID.Text = Convert.ToString(Patient.ThisPatient.PatientID);

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
        string Email = txtPatientEmail.Text;
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
            // capture the patient id
            APatient.PatientID = PatientID;
            // capture the patient date of registration
            APatient.DateAdded = Convert.ToDateTime(DateAdded);
            // capture the patient email
            APatient.Email = Convert.ToString(Email);
            // capture the patient gender
            APatient.PatientGender = PatientGender;
            // capture the patient password
            APatient.PatientPassword = PatientPassword;
            // capture the patient treatment status
            APatient.Treatment = chkPatienttreatment.Checked;
            //create a new instance of the patient collection
             ClsPatientCollection PatientList = new ClsPatientCollection();
            //if this is a new record i.e. PatientID = -1 then add the data
            if (PatientID == -1)
            {
                // set the ThisPatient property
                PatientList.ThisPatient = APatient;
                // add the new record
                PatientList.Add();
            }
            //otherwise it must be an update
            else
            {
                // find the record to update
                PatientList.ThisPatient.Find(PatientID);
                // set the ThisPatient property
                PatientList.ThisPatient = APatient;
                // update the record
                PatientList.Update();
            }

            // redirect back to the list page
            Response.Redirect("PatientList.aspx");

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
            txtPatientEmail.Text = APatient.Email;
            txtPatientgender.Text = APatient.PatientGender;
            txtPatientpassword.Text = APatient.PatientPassword;
            chkPatienttreatment.Checked = APatient.Treatment;
        }
    }


    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // redirect back to Main Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect back to list page
        Response.Redirect("PatientList.aspx");
    }
}
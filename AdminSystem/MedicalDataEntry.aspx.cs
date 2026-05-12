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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create new class of clsMedicalRecord
        clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
        //take patientId
        AMedicalRecord.PatientId= Convert.ToInt32(txtPatientId.Text);

        //take dob
        AMedicalRecord.Dob = Convert.ToDateTime(txtDob.Text);

        //take sex
        AMedicalRecord.Sex = chkSex.Checked;

        //take meds, diags and notes
        AMedicalRecord.Medications = txtMedications.Text;
        AMedicalRecord.Diagnoses = txtDiagnoses.Text;
        AMedicalRecord.ClinicalNotes = txtClinicalNotes.Text;



        //store id in session object
        Session["AMedicalRecord"] = AMedicalRecord;
        //navigate to view page
        Response.Redirect("MedicalViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
        Int32 PatientId;
        Boolean Found = false;
        PatientId = Convert.ToInt32(txtPatientId.Text);
        Found = AMedicalRecord.Find(PatientId);
        if(Found == true)
        {
            txtDob.Text = AMedicalRecord.Dob.ToString();
            chkSex.Checked = AMedicalRecord.Sex;
            txtMedications.Text = AMedicalRecord.Medications;
            txtDiagnoses.Text = AMedicalRecord.Diagnoses;
            txtClinicalNotes.Text = AMedicalRecord.ClinicalNotes;  

        }

    }
}
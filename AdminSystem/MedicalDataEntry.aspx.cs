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
        AMedicalRecord.IdAdded= Convert.ToInt32(txtPatientId.Text);

        //take dob
        AMedicalRecord.DateAdded = Convert.ToDateTime(txtDob.Text);

        //take sex
        AMedicalRecord.SexAdded = chkSex.Checked;

        //take meds, diags and notes
        AMedicalRecord.MedsAdded = txtMedications.Text;
        AMedicalRecord.DiagsAdded = txtDiagnoses.Text;
        AMedicalRecord.NotesAdded = txtClinicalNotes.Text;



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
            txtDob.Text = AMedicalRecord.DateAdded.ToString();
            chkSex.Checked = AMedicalRecord.SexAdded;
            txtMedications.Text = AMedicalRecord.MedsAdded;
            txtDiagnoses.Text = AMedicalRecord.DiagsAdded;
            txtClinicalNotes.Text = AMedicalRecord.NotesAdded;  

        }

    }
}
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsRoomManagement
        clsRoomManagement AnRoomManagement = new clsRoomManagement();
        //capture the RoomID
        AnRoomManagement.RoomID = Convert.ToInt32(txtRoomID.Text);
        //capture the room name
        string RoomName = txtRoomName.Text;
        //capture the patientID
        string PatientID = txtPatientID.Text;
        //capture the room entry date
        string RoomEntryDate = txtRoomEntryDate.Text;
        //capture the clical notes
        string ClinicalNotes = txtClinicalNotes.Text;
        //capture the treatment over
        AnRoomManagement.TreatmentOver = chkTreatmentOver.Checked;
        //varible to store any error messages
        string Error = "";
        //validate the data
        Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
        if (Error == "")
        {
            //capture the room id
            AnRoomManagement.RoomID = Convert.ToInt32(txtRoomID.Text);
            //capture the room name
            AnRoomManagement.RoomName = txtRoomName.Text;
            //capture the patientID
            AnRoomManagement.PatientID = Convert.ToInt32(txtPatientID.Text);
            //capture the room entry date
            AnRoomManagement.RoomEntryDate = Convert.ToDateTime(txtRoomEntryDate.Text);
            //capture the clical notes
            AnRoomManagement.ClinicalNotes = txtClinicalNotes.Text;
            //capture the treatment over
            AnRoomManagement.TreatmentOver = chkTreatmentOver.Checked;
            //store the room in the session object
            Session["AnRoomManagement"] = AnRoomManagement;
            //navigate to the view page
            Response.Redirect("RoomViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the room management class
        clsRoomManagement AnRoomManagement = new clsRoomManagement();
        //create a variable to store the primary key
        Int32 RoomID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        RoomID = Convert.ToInt32(txtRoomID.Text);
        //find the record
        Found = AnRoomManagement.Find(RoomID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtRoomName.Text = AnRoomManagement.RoomName;
            txtPatientID.Text = AnRoomManagement.PatientID.ToString();
            txtRoomEntryDate.Text = AnRoomManagement.RoomEntryDate.ToString();
            txtClinicalNotes.Text = AnRoomManagement.ClinicalNotes;
            chkTreatmentOver.Checked = AnRoomManagement.TreatmentOver;
        }
    }
}
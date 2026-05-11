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
}
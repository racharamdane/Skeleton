using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an new instance of clsRoomManagement
        clsRoomManagement AnRoomManagement = new clsRoomManagement();
        //get the data from the session object
        AnRoomManagement = (clsRoomManagement)Session["AnRoomManagement"];
        //display the roomID for this entry
        Response.Write(AnRoomManagement.RoomID);
        //display the room name for this entry
        Response.Write(AnRoomManagement.RoomName);
        //display the patientID for this entry
        Response.Write(AnRoomManagement.PatientID);
        //display the room entry date for this entry
        Response.Write(AnRoomManagement.RoomEntryDate);
        //display the clinical notes for this entry
        Response.Write(AnRoomManagement.ClinicalNotes);
        //display the treatment over for this entry
        Response.Write(AnRoomManagement.TreatmentOver);
    }
}
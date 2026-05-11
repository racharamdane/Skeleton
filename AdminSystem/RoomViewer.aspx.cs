using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
        Console.WriteLine("");
        //display the room name for this entry
        Response.Write(AnRoomManagement.RoomName);
        Console.WriteLine("");
        //display the patientID for this entry
        Response.Write(AnRoomManagement.PatientID);
        Console.WriteLine("");
        //display the room entry date for this entry
        Response.Write(AnRoomManagement.RoomEntryDate);
        Console.WriteLine("");
        //display the clinical notes for this entry
        Response.Write(AnRoomManagement.ClinicalNotes);
        Console.WriteLine("");
        //display the treatment over for this entry
        Response.Write(AnRoomManagement.TreatmentOver);
        Console.WriteLine("");
    }
}
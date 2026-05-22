using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
        Int32 AppointmentID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the patients to be deleted from the session object
        AppointmentID = Convert.ToInt32(Session["AppointmentID"]);


    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the patient collection
        clsAppointmentSchedulingCollection Appointment = new clsAppointmentSchedulingCollection();
        //find the record to delete
        Appointment.ThisAppointmentScheduling.Find(AppointmentID);
        //delete the record
        Appointment.Delete();
        //redirect back to the main page
        Response.Redirect("AppointmentList.aspx");
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("AppointmentList.aspx");
    }

}
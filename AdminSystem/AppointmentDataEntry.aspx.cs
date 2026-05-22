using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 AppointmentId;
    private object txtDoctorId;
    private object txtPatientId;
    private object txtAppointmentNotes;
    private object txtAppointmentTime;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the appointment to be processed
        AppointmentId = Convert.ToInt32(Session["AppointmentId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (AppointmentId != -1)
            {
                //display the current data for the record
                DisplayAppointment();
            }
        }

    }

    private void DisplayAppointment()
    {
        //create an instance of the appointment
        clsAppointmentScheduling Appointment = new clsAppointmentScheduling();
        //find the record to update
        Appointment.Find(AppointmentId);
        //display the data for this record
        txtAppointmentId.Text = Appointment.AppointmentId.ToString();
        txtDoctorId = Appointment.DoctorId.ToString();
        txtPatientId = Appointment.PatientId.ToString();
        txtAppointmentNotes = Appointment.AppointmentNotes.ToString();
        txtAppointmentDate.Text = Appointment.AppointmentDate.ToString();
        txtAppointmentTime = Appointment.AppointmentTime.ToString();
        chkAvailability.Checked = Appointment.Availability;
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsAppointmentScheduling
        clsAppointmentScheduling AAppointment = new clsAppointmentScheduling();
        // capture the doctor id
        string DoctorId = (string)txtDoctorId;
        // capture the patient id
        string PatientId = (string)txtPatientId;
        // capture the appointment notes
        string AppointmentNotes = (string)txtAppointmentNotes;
        // capture the appointment date
        string AppointmentDate = txtAppointmentDate.Text;
        // capture the appointment time
        string AppointmentTime = (string)txtAppointmentTime;
        // capture the appointment availability
        string Availability = chkAvailability.Text;
        // variable to store any error messages
        string Error = "";
        // validate the data
        Error = AAppointment.Valid(DoctorId, PatientId, AppointmentNotes, AppointmentDate, AppointmentTime, Availability);
        if (Error == "")
        {
            // capture the doctor id
            AAppointment.DoctorId = Convert.ToInt32(DoctorId);
            // capture the patient id
            AAppointment.PatientId = Convert.ToInt32(PatientId);
            // capture the appointment notes
            AAppointment.AppointmentNotes = AppointmentNotes;
            // capture the appointment date
            AAppointment.AppointmentDate = Convert.ToDateTime(AppointmentDate);
            // capture the appointment time
            AAppointment.AppointmentTime = Convert.ToDateTime(AppointmentTime);
            // capture the appointment availability
            AAppointment.Availability = Convert.ToBoolean(Availability);
            // capture the appointment id
            AAppointment.AppointmentId = AppointmentId;
            //create a new instance of the appointment scheduling collection
            clsAppointmentSchedulingCollection AppointmentList = new clsAppointmentSchedulingCollection();
            //if this is a new record i.e. AppointmentId = -1 then add the data
            if (AppointmentId == -1)
            {
                //set the ThisAppointment property
                AppointmentList = AAppointment;
                //add the record
                AppointmentList.Add();
            }
            else //otherwise it must be an update
            {
                //find the record to update
                AppointmentList.ThisAppointmentScheduling.Find(AppointmentId);
                //set the ThisAppointment property
                AppointmentList.ThisAppointmentScheduling = AAppointment;
                //update the record
                AppointmentList.Update();
            }
            //redirect back to the list page
            Response.Redirect("AppointmentList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the appointment class
        clsAppointmentScheduling AnAppointment = new clsAppointmentScheduling();
        //variable to store the primary key
        Int32 AppointmentId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AppointmentId = Convert.ToInt32(txtAppointmentId.Text);
        //find the record
        Found = AnAppointment.Find(AppointmentId);
        if (Found == true) {
            //display the values of the properties in the form
            txtDoctorId = AnAppointment.DoctorId.ToString();
            txtPatientId = AnAppointment.PatientId.ToString();
            txtAppointmentNotes = AnAppointment.AppointmentNotes;
            txtAppointmentDate.Text = AnAppointment.AppointmentDate.ToString();
            txtAppointmentTime = AnAppointment.AppointmentTime.ToString();
            chkAvailability.Checked = AnAppointment.Availability;
        }

    }
}

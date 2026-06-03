using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Nothing required on load; add session/auth checks here if needed.
    }

    // ── Navigation button handlers ─────────────────────────────

    /// <summary>Navigates to the Patient Records module.</summary>
    protected void btnPatients_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatientDataEntry.aspx");
    }

    /// <summary>Navigates to the Doctor Directory module.</summary>
    protected void btnDoctors_Click(object sender, EventArgs e)
    {
        Response.Redirect("DoctorDataEntry.aspx");
    }

    /// <summary>Navigates to the Medical Records module.</summary>
    protected void btnMedicalRecords_Click(object sender, EventArgs e)
    {
        Response.Redirect("MedicalDataEntry.aspx");
    }

    /// <summary>Navigates to the Appointment Scheduling module.</summary>
    protected void btnAppointments_Click(object sender, EventArgs e)
    {
        Response.Redirect("AppointmentDataEntry.aspx");
    }

    /// <summary>Navigates to the Room Booking module.</summary>
    protected void btnRoomBooking_Click(object sender, EventArgs e)
    {
        Response.Redirect("RoomDataEntry.aspx");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Execute only on the initial container rendering pass
        if (!IsPostBack)
        {
            // Verify structural session data safely to avoid NullReference exceptions
            if (Session["APatient"] != null)
            {
                // Unpack type definition cast from contextual session state storage memory
                ClsPatient APatient = (ClsPatient)Session["APatient"];

                // Map logical properties straight to front-end layout labels
                lblFullName.Text = APatient.FullName;
                lblDateAdded.Text = APatient.DateAdded.ToString("dd/MM/yyyy");
                lblEmail.Text = APatient.Email;
                lblGender.Text = APatient.PatientGender;
                lblTreatment.Text = APatient.Treatment.ToString();

            }
            else
            {
                // Fallback exception visual safety state initialization
                lblFullName.Text = "No patient data found in the active context session.";
                lblFullName.Style.Add("color", "var(--brand-gold)");

                lblDateAdded.Text = "—";
                lblEmail.Text = "—";
                lblGender.Text = "—";
                lblTreatment.Text = "—";
            }
        }
    }

    /// <summary>
    /// Router Event handler responsible for navigating the user back safely to the primary view deck.
    /// </summary>
    protected void btnReturnToMain_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatientList.aspx");
    }
}

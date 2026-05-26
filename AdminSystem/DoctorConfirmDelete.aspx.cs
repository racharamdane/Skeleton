using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 DoctorId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the doctor to be deleted from the session object
        DoctorId = Convert.ToInt32(Session["DoctorId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the doctor collection
        clsDoctorCollection Doctor = new clsDoctorCollection();
        //find the record to delete
        Doctor.ThisDoctor.Find(DoctorId);
        //delete the record
        Doctor.Delete();
        //redirect back to the main page
        Response.Redirect("DoctorList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("DoctorList.aspx");
    }
}
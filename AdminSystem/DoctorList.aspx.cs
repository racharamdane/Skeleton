using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayDoctors();
        }
    }

    void DisplayDoctors()
    {
        //create an inmstance of the Doctor collection
        clsDoctorCollection Doctors = new clsDoctorCollection();
        //set the data source to list of doctors in the collection
        lstDoctorList.DataSource = Doctors.DoctorList;
        //set the name of the primary key
        lstDoctorList.DataValueField = "DoctorId";
        //set the data field to display
        lstDoctorList.DataTextField = "FullName";
        //bind the data to the list
        lstDoctorList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["DoctorId"] = -1;
        //redirect to the data entry page
        Response.Redirect("DoctorDataEntry.aspx");

    }
}
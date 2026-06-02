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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 DoctorId;
        //if a record has been selected from the list
        if (lstDoctorList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            DoctorId = Convert.ToInt32(lstDoctorList.SelectedValue);
            //store the data in the session object
            Session["DoctorId"] = DoctorId;
            //redirect to the edit page
            Response.Redirect("DoctorDataEntry.aspx");
        }

        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 DoctorId;
        //if a record has been selected from the list
        if (lstDoctorList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            DoctorId = Convert.ToInt32(lstDoctorList.SelectedValue);
            //store the data in the session object
            Session["DoctorId"] = DoctorId;
            //redirect to the delete page
            Response.Redirect("DoctorConfirmDelete.aspx");
        }

        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Doctor object
        clsDoctorCollection ADoctor = new clsDoctorCollection();
        //retrieve the value of the full name from the presentation layer
        ADoctor.ReportByFullName(txtFilter.Text);
        //set the data source to list of doctors in the collection
        lstDoctorList.DataSource = ADoctor.DoctorList;
        //set the name of the primary key
        lstDoctorList.DataValueField = "DoctorId";
        //set the data field to display
        lstDoctorList.DataTextField = "FullName";
        //bind the data to the list
        lstDoctorList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Doctor object
        clsDoctorCollection ADoctor = new clsDoctorCollection();
        //set an empty string 
        ADoctor.ReportByFullName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to list of doctors in the collection
        lstDoctorList.DataSource = ADoctor.DoctorList;
        //set the name of the primary key
        lstDoctorList.DataValueField = "DoctorId";
        //set the data field to display
        lstDoctorList.DataTextField = "FullName";
        //bind the data to the list
        lstDoctorList.DataBind();
    }

    protected void btnStatisticsPage_Click(object sender, EventArgs e)
    {

    }
}
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
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayPatients();
        }

    }
    void DisplayPatients()
    {         // create an instance of the patient collection
        ClsPatientCollection Patients = new ClsPatientCollection();
        // set the data source to the list of patients in the collection
        lstPatientList.DataSource = Patients.PatientList;
        // set the name of the primary key
        lstPatientList.DataValueField = "PatientID";
        // set the data field to display
        lstPatientList.DataTextField = "FullName";
        // bind the data to the list
        lstPatientList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["PatientID"] = -1;
        //redirect to the data entry page
        Response.Redirect("PatientDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 PatientID;
        //if a record has been selected from the list
        if (lstPatientList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            PatientID = Convert.ToInt32(lstPatientList.SelectedValue);
            //store the data in the session object
            Session["PatientID"] = PatientID;
            //redirect to the edit page
            Response.Redirect("PatientDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store  the primary ket value of the record to be delted
        Int32 PatientID;
        //if a record has been selected from the list
        if (lstPatientList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            PatientID = Convert.ToInt32(lstPatientList.SelectedValue);
            //store the data in the session object
            Session["PatientID"] = PatientID;
            //redirect to the delete page
            Response.Redirect("PatientConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the patient object
        ClsPatientCollection APatient = new ClsPatientCollection();
        //retrievethe full name from the presentation layer
        APatient.ReportByFullName(txtFilter.Text);
        //set the data source to the list of patients in the collection
        lstPatientList.DataSource = APatient.PatientList;
        //set the name of the primary key
        lstPatientList.DataValueField = "PatientID";
        //set the data field to display
        lstPatientList.DataTextField = "FullName";
        //bind the data to the list
        lstPatientList.DataBind();

    }




    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the patient object
        ClsPatientCollection APatient = new ClsPatientCollection();
        //set an empty string
        APatient.ReportByFullName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of patients in the collection
        lstPatientList.DataSource = APatient.PatientList;
        //set the name of the primary key
        lstPatientList.DataValueField = "PatientID";
        //set the name of the field to display
        lstPatientList.DataTextField = "FullName";
        //bind the data to the list
        lstPatientList.DataBind();


    }
}

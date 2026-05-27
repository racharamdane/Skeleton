using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    //if first time pl]age displayed
    //    if (IsPostBack == false)
    //    {
    //        DisplayRecords();
    //    }
    //}
    //void DisplayRecords()
    //{
    //    clsRecordCollection Records = new clsRecordCollection();

    //    lstRecordList.DataSource = Records.RecordList;

    //    lstRecordList.DataValueField = "PatientId";
    //    lstRecordList.DataTextField = "Dob";

    //    lstRecordList.DataBind();

    //}
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayRecords();
        }

    }
    void DisplayRecords()
    {         // create an instance of the patient collection
        ClsPatientCollection Patients = new ClsPatientCollection();
        // set the data source to the list of patients in the collection
        lstRecordList.DataSource = Patients.PatientList;
        // set the name of the primary key
        lstRecordList.DataValueField = "PatientID";
        // set the data field to display
        lstRecordList.DataValueField = "Dob";
        // bind the data to the list
        lstRecordList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
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
        //if first time pl]age displayed
        if (IsPostBack == false)
        {
            DisplayRecords();
        }
    }
    void DisplayRecords()
    {
        clsRecordCollection Records = new clsRecordCollection();

        lstRecordList.DataSource = Records.RecordList;

        lstRecordList.DataValueField = "PatientId";
        lstRecordList.DataTextField = "Dob";

        lstRecordList.DataBind();

    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PatientId"] = -1;
        Response.Redirect("MedicalDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 PatientId;
        if (lstRecordList.SelectedIndex != -1)
        {
            PatientId = Convert.ToInt32(lstRecordList.SelectedValue);
            Session["PatientId"] = PatientId;
            Response.Redirect("MedicalConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
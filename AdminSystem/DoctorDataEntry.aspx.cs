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
    Int32 DoctorId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the doctor to be processed
        DoctorId = Convert.ToInt32(Session["DoctorId"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //if we are not adding a new record
            if (DoctorId != -1)
            {
                //display the current data for the record
                DisplayDoctor();
            }
        }
    }

    void DisplayDoctor()
    {
        //create an instance of the doctor collection
        clsDoctorCollection Doctor = new clsDoctorCollection();
        //find the record to update
        Doctor.ThisDoctor.Find(DoctorId);
        //display the data for this record
        txtDoctorId.Text = Doctor.ThisDoctor.DoctorId.ToString();
        txtFullName.Text = Doctor.ThisDoctor.FullName.ToString();
        txtPassword.Text = Doctor.ThisDoctor.Password.ToString();
        txtEmail.Text = Doctor.ThisDoctor.Email.ToString();
        txtDepartment.Text = Doctor.ThisDoctor.Department.ToString();
        txtContractDate.Text = Doctor.ThisDoctor.ContractDate.ToString();
        chkAvailability.Checked = Doctor.ThisDoctor.Available;
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create an new instance of clsDoctor
        clsDoctor ADoctor = new clsDoctor();
        //capture the full name
        string FullName = txtFullName.Text;
        //capture the password
        string Password = txtPassword.Text;
        //capture the email
        string Email = txtEmail.Text;
        //capture the department
        string Department = txtDepartment.Text;
        //capture the contract date
        string ContractDate = txtContractDate.Text;
        //capture the availability
        string Available = chkAvailability.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
        if (Error == "")
        {   //capture the doctor id
            ADoctor.DoctorId = DoctorId;
            //capture the full name
            ADoctor.FullName = txtFullName.Text;
            //capture the password
            ADoctor.Password = txtPassword.Text;
            //capture the email
            ADoctor.Email = txtEmail.Text;
            //capture the department
            ADoctor.Department = txtDepartment.Text;
            //capture the contract date
            ADoctor.ContractDate = Convert.ToDateTime(DateTime.Now);
            //capture the availability
            ADoctor.Available = chkAvailability.Checked;
            //create a new instance of the doctor collection
            clsDoctorCollection DoctorList = new clsDoctorCollection();
            //if this is a new record i.e. DoctorId = -1 then add the data
            if (DoctorId == -1)
            {
                //set the ThisDoctor property
                DoctorList.ThisDoctor = ADoctor;
                //add the new record
                DoctorList.Add();
            }

            //otherwise it must be an update
            else
            {
                //find the record to update
                DoctorList.ThisDoctor.Find(DoctorId);
                //set the ThisDoctor property
                DoctorList.ThisDoctor = ADoctor;
                //update the new record
                DoctorList.Update();
            }

            //redirect back to the list page
            Response.Redirect("DoctorList.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the new address class
        clsDoctor ADoctor = new clsDoctor();
        //create a variable to store the primary key
        int DoctorId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        DoctorId = Convert.ToInt32(txtDoctorId.Text);
        //find the record
        Found = ADoctor.Find(DoctorId);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFullName.Text = ADoctor.FullName;
            txtPassword.Text = ADoctor.Password;
            txtEmail.Text = ADoctor.Email;
            txtDepartment.Text = ADoctor.Department;
            txtContractDate.Text = ADoctor.ContractDate.ToString();
            chkAvailability.Checked = ADoctor.Available;
        }
    }
}
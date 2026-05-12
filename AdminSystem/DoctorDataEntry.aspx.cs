using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create an new instance of clsDoctor
        clsDoctor ADoctor = new clsDoctor();
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
        //get the data from the session object
        Session["ADoctor"] = ADoctor;
        //navigate to the view page
        Response.Redirect("DoctorViewer.aspx");
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
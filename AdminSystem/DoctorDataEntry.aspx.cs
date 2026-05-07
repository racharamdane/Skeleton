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
}
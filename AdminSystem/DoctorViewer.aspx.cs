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
        //create an instance of the doctor class
        clsDoctor ADoctor = new clsDoctor();
        //get the data from the session object
        ADoctor = (clsDoctor)Session["ADoctor"];
        //display the doctor data for this entry
        Response.Write(ADoctor.FullName + "<br/>");
        Response.Write(ADoctor.Password + "<br/>");
        Response.Write(ADoctor.Email + "<br/>");
        Response.Write(ADoctor.Department + "<br/>");
        Response.Write(ADoctor.ContractDate + "<br/>");
        Response.Write(ADoctor.Available + "<br/>");
    }
}
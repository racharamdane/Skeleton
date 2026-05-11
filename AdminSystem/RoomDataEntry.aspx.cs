using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsRoomManagement
        clsRoomManagement AnRoomManagement = new clsRoomManagement();
        //capture the RoomID
        AnRoomManagement.RoomID = Convert.ToInt32(txtRoomID.Text);
        //store the room in the session object
        Session["AnRoomManagement"] = AnRoomManagement;
        //navigate to the view page
        Response.Redirect("RoomViewer.aspx");
    }
}
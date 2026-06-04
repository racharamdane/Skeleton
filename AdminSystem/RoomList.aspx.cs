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
            DisplayRooms();
        }
    }

    void DisplayRooms()
    {
        //create an instance of the room collection
        clsRoomManagementCollection Rooms = new clsRoomManagementCollection();
        //set the data source to the list of rooms in the collection
        lstRoomList.DataSource = Rooms.RoomList;
        //set the name of the primary key
        lstRoomList.DataValueField = "RoomID";
        //set the data field to display
        lstRoomList.DataTextField = "RoomName";
        //bind the data to the list
        lstRoomList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["RoomID"] = -1;
        //redirect to the data entry page
        Response.Redirect("RoomDataEntry.aspx");
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        //varible to store the primary key value of the record to be deleted
        Int32 RoomID;
        //if a record has been selected from the list
        if (lstRoomList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            RoomID = Convert.ToInt32(lstRoomList.SelectedValue);
            //store the data in the session object
            Session["RoomID"] = RoomID;
            //redirect to the delete page
            Response.Redirect("RoomConfirmDelete.aspx");
        }
         else
        {
            string Error = "Please select a record to delete from the list";
        }
    }
}
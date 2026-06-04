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
}
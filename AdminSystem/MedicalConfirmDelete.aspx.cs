using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 PatientId;
    protected void Page_Load(object sender, EventArgs e)
    {
        PatientId = Convert.ToInt32(Session["PatientId"]);  
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsRecordCollection RecordList = new clsRecordCollection();
        RecordList.ThisRecord.Find(PatientId);
        RecordList.Delete();
        Response.Redirect("MedicalList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("MedicalList.aspx");
    }
}
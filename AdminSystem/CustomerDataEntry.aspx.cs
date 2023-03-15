using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sener, EventArgs e)
    {

    }
 
    protected void btnOK_Click1(object sender, EventArgs e)
    {
       clsCustomer aCustomer = new clsCustomer();
        //TOOO DOOO
        aCustomer.ID = Convert.ToInt32(txtCustomerID.Text);
        aCustomer.Name = txtName.Text;
        aCustomer.Email = txtEmail.Text;
        aCustomer.Pass = txtPassword.Text;
        aCustomer.DateAdded = Convert.ToDateTime(txtDate.Text);
        aCustomer.Active = chkActive.Checked;

        
        Session["aCustomer"] = aCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }
}
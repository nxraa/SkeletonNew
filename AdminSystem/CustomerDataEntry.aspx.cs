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
        string ID = txtCustomerID.Text;
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string DateAdded = txtDate.Text;
        string Pass = txtPassword.Text;
        aCustomer.Active = chkActive.Checked;
        string Error = "";
        Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
        if (Error == "")
        {
            aCustomer.ID = Convert.ToInt32(txtCustomerID.Text);
            aCustomer.Name = Name;
            aCustomer.Email = Email;
            aCustomer.Pass = Pass;
            aCustomer.Active = chkActive.Checked;
            aCustomer.DateAdded = Convert.ToDateTime(DateAdded);

            Session["aCustomer"] = aCustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            Label3.Text = Error;
        }
    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }
}
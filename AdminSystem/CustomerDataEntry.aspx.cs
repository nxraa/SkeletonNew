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
      
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string DateAdded = txtDate.Text;
        string Pass = txtPassword.Text;
        string Error = "";
        Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
        if (Error == "")
        {
            
            aCustomer.Name = Name;
            aCustomer.Email = Email;
            aCustomer.Pass = Pass;
            aCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            aCustomer.Active = chkActive.Checked;

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = aCustomer;
            CustomerList.Add();

            
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            Label3.Text = Error;
        }
    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer aCustomer = new clsCustomer();
        Int32 ID;
        Boolean Found = false;
        ID = Convert.ToInt32(txtCustomerID.Text);
        Found = aCustomer.Find(ID);

        if (Found == true)
        {
            txtName.Text = aCustomer.Name;
            txtEmail.Text = aCustomer.Email;
            txtPassword.Text = aCustomer.Pass;
            txtDate.Text = aCustomer.DateAdded.ToString();
            chkActive.Checked = aCustomer.Active;
        }
    }
}
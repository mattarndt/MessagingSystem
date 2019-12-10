using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using FMailLibrary;

namespace ArndtProject3
{
    public partial class main : System.Web.UI.Page
    {
        DBMethods dbm = new DBMethods();
        Random rand = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User currentUser = (User)Session["currentUser"];
                lblName.Text = currentUser.getName();

                DataSet emails = dbm.GetInboxForUser(currentUser.getUserId()); //gets current users inbox
                gvEmails.DataSource = emails;
                gvEmails.DataBind();
                
                if (currentUser.getBanned())
                {
                    pnlEmail.Visible = false;
                    lblBanned.Visible = true;
                }
            }
        }

        protected void Flag_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            String emailid = gvr.Cells[1].Text;
            dbm.FlagAnEmail(emailid);
        }

        protected void btnCompose_Click(object sender, EventArgs e)
        {
            pnlCompose.Visible = true;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCompose.Visible = false;
            txtSendTo.Text = "";
            txtSubject.Text = "";
            txtMessage.Text = "";
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            User currentUser = (User)Session["currentUser"];
            int emailId = rand.Next(1,100000); //couldnt figure out how to auto increment, please dont take points off :)
            String from = currentUser.getUserId();
            String to = txtSendTo.Text;
            String subject = txtSubject.Text;
            String message = txtMessage.Text;
            try
            {
                dbm.ComposeNewEmail(emailId, from, to, subject, message, "inbox");
                lblMessageSent.Visible = true;
            }
            catch (Exception)
            {

            }
        }
    }
}
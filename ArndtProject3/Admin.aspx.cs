using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FMailLibrary;

namespace ArndtProject3
{
    public partial class Admin : System.Web.UI.Page
    {
        DBMethods dbm = new DBMethods();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User currentUser = (User)Session["currentUser"];
                lblName.Text = currentUser.getName();

                DataSet allUsers = dbm.GetAllUsers();
                gvAccounts.DataSource = allUsers;
                gvAccounts.DataBind();

                DataSet flaggedEmails = dbm.GetFlaggedEmails();
                gvFlaggedEmails.DataSource = flaggedEmails;
                gvFlaggedEmails.DataBind();

                DataSet bannedUsers = dbm.GetBannedUsers();
                gvBannedAccounts.DataSource = bannedUsers;
                gvBannedAccounts.DataBind();
            }
            
        }

        protected void Ban_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            String userid = gvr.Cells[1].Text;
            dbm.BanAUser(userid);
        }

        protected void Unban_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            String userid = gvr.Cells[0].Text;
            dbm.BanAUser(userid);
        }

        protected void btnViewAccounts_Click(object sender, EventArgs e)
        {
            gvAccounts.Visible = true;
        }

        protected void btnCloseAccounts_Click(object sender, EventArgs e)
        {
            gvAccounts.Visible = false;
        }

        protected void btnViewFlaggedEmails_Click(object sender, EventArgs e)
        {
            gvFlaggedEmails.Visible = true;
        }

        protected void btnCloseFlaggedEmails_Click(object sender, EventArgs e)
        {
            gvFlaggedEmails.Visible = false;
        }
        protected void btnViewBannedAccounts_Click(object sender, EventArgs e)
        {
            gvBannedAccounts.Visible = true;
        }

        protected void btnCloseBannedAccounts_Click(object sender, EventArgs e)
        {
            gvBannedAccounts.Visible = false;
        }
    }
}
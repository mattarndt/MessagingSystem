  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FMailLibrary;
using Utilities;
using System.IO;
using System.Collections;
using System.Data;

namespace ArndtProject3
{
    public partial class Login : System.Web.UI.Page
    {
        DBMethods dbm = new DBMethods();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DirectoryInfo di = new DirectoryInfo(MapPath("~/avatars/"));
                FileInfo[] imagenames = di.GetFiles();
                ArrayList al = new ArrayList();
                foreach (FileInfo info in imagenames)
                {
                    al.Add(info);
                }
                ddlAvatar.DataSource = al;
                ddlAvatar.DataBind();
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            DataSet data = dbm.GetUserByIdAndPassword(txtUsrname.Text, txtPssword.Text);
            DataRow dRow;
            try
            {
                dRow = data.Tables[0].Rows[0];
                String userId = dRow.ItemArray.GetValue(0).ToString();
                String userType = dRow.ItemArray.GetValue(1).ToString();
                String name = dRow.ItemArray.GetValue(2).ToString();
                String phone = dRow.ItemArray.GetValue(3).ToString();
                String street = dRow.ItemArray.GetValue(4).ToString();
                String city = dRow.ItemArray.GetValue(5).ToString();
                int zipcode = Convert.ToInt32(dRow.ItemArray.GetValue(6).ToString());
                String state = dRow.ItemArray.GetValue(7).ToString();
                String secondary = dRow.ItemArray.GetValue(8).ToString();
                String avatar = dRow.ItemArray.GetValue(9).ToString();
                String password = dRow.ItemArray.GetValue(10).ToString();
                Boolean banned = dbm.CheckBannedByUserId(userId);
                Response.Write(banned);
                User user = new User(userId, password, userType, name, phone, street, city, zipcode, state, secondary, avatar, banned);
                Session["currentUser"] = user;

                if (userType=="regular")
                {
                    Response.Redirect("~/FMail.aspx");
                }
                if (userType == "admin")
                {
                    Response.Redirect("~/Admin.aspx");   
                }
            } catch (Exception)
            {
                Response.Write("Unable to find account. Please enter a valid username and password");
            }
            
        }

        protected void CreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                int zip = Convert.ToInt32(txtZip.Text);
                dbm.NewUser(txtUserId.Text, txtPassword.Text, rblist1.SelectedValue, txtName.Text,
                    txtPhone.Text, txtStreet.Text, txtCity.Text, zip, txtState.Text, txtSecondary.Text, ddlAvatar.SelectedValue);
                lblAccountSuccessful.Visible = true;

            } catch (Exception)
            {
                Response.Write("Error, you must enter a number for the zip code");
            }
            
        }

        protected void BackToLogin_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = true;
            lblUsrname.Visible = true;
            txtUsrname.Visible = true;
            lblPssword.Visible = true;
            txtPssword.Visible = true;
            btnCreateNew.Visible = true;
            btnLogin.Visible = true;

            btnBackToLogin.Visible = false;
            lblSelectAccount.Visible = false;
            rblist1.Visible = false;
            lblUserId.Visible = false;
            txtUserId.Visible = false;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            lblName.Visible = false;
            txtName.Visible = false;
            lblPhone.Visible = false;
            txtPhone.Visible = false;
            lblStreet.Visible = false;
            txtStreet.Visible = false;
            lblCity.Visible = false;
            txtCity.Visible = false;
            lblZip.Visible = false;
            txtZip.Visible = false;
            lblState.Visible = false;
            txtState.Visible = false;
            lblSecondary.Visible = false;
            txtSecondary.Visible = false;
            lblAvatar.Visible = false;
            btnCreateAccount.Visible = false;
            pnlAvatar.Visible = false;
            ddlAvatar.Visible = false;
            lblAccountSuccessful.Visible = false;
        }

        protected void CreateNewAccount_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            lblUsrname.Visible = false;
            txtUsrname.Visible = false;
            lblPssword.Visible = false;
            txtPssword.Visible = false;
            btnCreateNew.Visible = false;
            btnLogin.Visible = false;
            lblAccountSuccessful.Visible = false;

            btnBackToLogin.Visible = true;
            lblSelectAccount.Visible = true;
            rblist1.Visible = true;
            lblUserId.Visible = true;
            txtUserId.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            lblName.Visible = true;
            txtName.Visible = true;
            lblPhone.Visible = true;
            txtPhone.Visible = true;
            lblStreet.Visible = true;
            txtStreet.Visible = true;
            lblCity.Visible = true;
            txtCity.Visible = true;
            lblZip.Visible = true;
            txtZip.Visible = true;
            lblState.Visible = true;
            txtState.Visible = true;
            lblSecondary.Visible = true;
            txtSecondary.Visible = true;
            lblAvatar.Visible = true;
            btnCreateAccount.Visible = true;
            pnlAvatar.Visible = true;
            ddlAvatar.Visible = true;
        }

        
    }
}
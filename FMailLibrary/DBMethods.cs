using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

namespace FMailLibrary
{
    public class DBMethods
    {
        DataValidation dv = new DataValidation();
        
        
        public void NewUser(String userID, String password, String userType, String name, String phoneNumber, 
            String street, String city, int zipCode, String state, String secondaryEmail, String avatar)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "NewUser"; // name of the Stored Procedure 

            // Pass an input parameter value to the Stored Procedure that is used for the 
            // @theName built-in parameter

            objCommand.Parameters.AddWithValue("@UserID", userID + "@fmail.com");
            objCommand.Parameters.AddWithValue("@Password", password);
            objCommand.Parameters.AddWithValue("@UserType", userType);
            objCommand.Parameters.AddWithValue("@Name", name);
            objCommand.Parameters.AddWithValue("@Phone", phoneNumber);
            objCommand.Parameters.AddWithValue("@Street", street);
            objCommand.Parameters.AddWithValue("@City", city);
            objCommand.Parameters.AddWithValue("@ZipCode", zipCode);
            objCommand.Parameters.AddWithValue("@State", state);
            objCommand.Parameters.AddWithValue("@SecondaryEmail", secondaryEmail);
            objCommand.Parameters.AddWithValue("@Avatar", avatar);

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }

        public DataSet GetUserByIdAndPassword(String userid, String password)
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetUserByIdAndPassword";

            objCommand.Parameters.AddWithValue("@theUser", userid);
            objCommand.Parameters.AddWithValue("@password", password);

            DBConnect objDB = new DBConnect();
            DataSet myDataSet = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDataSet;
        }

        public DataSet GetInboxForUser(String user)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();
            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetInboxForUser";

            objCommand.Parameters.AddWithValue("@user", user);

            objDB.GetConnection();
            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            objDB.CloseConnection();
            if (dv.CheckForData(ds))
            {
                return ds;
            }
            else
            {
                Console.WriteLine("THERE IS NO DATA");
                return ds;
            }
        }
        public void ComposeNewEmail(int emailid, String from, String to, String subject, String message, String folder)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "NewEmail"; // name of the Stored Procedure 

            // Pass an input parameter value to the Stored Procedure that is used for the 
            // @theName built-in parameter

            objCommand.Parameters.AddWithValue("@emailid", emailid);
            objCommand.Parameters.AddWithValue("@from", from);
            objCommand.Parameters.AddWithValue("@to", to);
            objCommand.Parameters.AddWithValue("@subject", subject);
            objCommand.Parameters.AddWithValue("@message", message);
            objCommand.Parameters.AddWithValue("@folder", folder);

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }

        public DataSet GetAllUsers()
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAllUsers";

            DBConnect objDB = new DBConnect();
            DataSet myDataSet = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDataSet;
        }

        public DataSet GetFlaggedEmails()
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetFlaggedEmails";
            objCommand.Parameters.AddWithValue("@flagged", "true");

            DBConnect objDB = new DBConnect();
            DataSet myDataSet = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDataSet;
        }

        public void FlagAnEmail(String emailid)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "FlagAnEmail"; // name of the Stored Procedure 

            // Pass an input parameter value to the Stored Procedure that is used for the 
            // @theName built-in parameter

            objCommand.Parameters.AddWithValue("@emailid", emailid);
            objCommand.Parameters.AddWithValue("@value", "true");

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }

        public void BanAUser(String userid)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "BanAUser"; // name of the Stored Procedure 

            // Pass an input parameter value to the Stored Procedure that is used for the 
            // @theName built-in parameter

            objCommand.Parameters.AddWithValue("@userid", userid);
            objCommand.Parameters.AddWithValue("@value", "true");

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }
        public DataSet GetBannedUsers()
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetBannedUsers";
            objCommand.Parameters.AddWithValue("@value", "true");

            DBConnect objDB = new DBConnect();
            DataSet myDataSet = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDataSet;
        }

        public Boolean CheckBannedByUserId(String userid)
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CheckBannedByUserId";
            objCommand.Parameters.AddWithValue("@userid", userid);

            DBConnect objDB = new DBConnect();
            DataSet myDataSet = objDB.GetDataSetUsingCmdObj(objCommand);
            
            try
            {
                String test = Convert.ToString(myDataSet.Tables[0].Rows[0]["banned"]);
                Boolean test2 = Convert.ToBoolean(test);
                return test2;
            }
            catch (Exception)
            {
                return false;
            }
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace FMailLibrary
{
    public class User
    {
        String userId;
        String password;
        String userType;
        String name;
        String phone;
        String street;
        String city;
        int zip;
        String state;
        String secondaryEmail;
        String avatar;
        Boolean banned;

        public User()
        {

        }

        public User(String userId, String password, String userType, String name, String phone, 
            String street, String city, int zip, String state, String secondaryEmail,String avatar, Boolean banned)
        {
            this.userId = userId;
            this.password = password;
            this.userType = userType;
            this.name = name;
            this.phone = phone;
            this.street = street;
            this.city = city;
            this.zip = zip;
            this.state = state;
            this.secondaryEmail = secondaryEmail;
            this.avatar = avatar;
            this.banned = banned;
        }

        public String toString()
        {
            return "userId = " + userId + ", password = " + password + ", userType = " + userType
                + ", name = " + name;
        }

        public void setUserId(String id)
        {
            userId = id;
        }
        public String getUserId()
        {
            return userId;
        }
        public void setPassword(String pass)
        {
            password = pass;
        }
        public String getPassword()
        {
            return password;
        }
        public void setUserType(String type)
        {
            if (type != "regular" || type != "admin")
            {
                throw new Exception("invalid type name - must be 'regular' or 'admin' ");
            }
            else
            {
                userType = type;
            }
        }
        public String getUserType()
        {
            return userType;
        }
        public void setName(String inName)
        {
            name = inName;
        }
        public String getName()
        {
            return name;
        }
        public void setBanned(Boolean inBanned)
        {
            banned = inBanned;
        }
        public Boolean getBanned()
        {
            return banned;
        }
    }
}

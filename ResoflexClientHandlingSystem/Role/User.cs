using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public static class Userglobals
    {
        public static int uid = 0;
        public static string uname = "";
        public static string priv = "";

    }

    public static class Logglobals
    {
        public static int id;
        public static DateTime login;
        public static DateTime logout;
        public static string ip;
        public static string detail;
    }

    class User : Staff
    {
        private int userId;
        private string uName;
        private string pword;
        private string permission;


        public User(int userId, string uName, string pword, string permission) : base(userId)
        {
            this.UName = uName;
            this.Pword = pword;
            this.Permission = permission;
        }

        public User(string uName, string pword, string permission, string[] telNumber) : base(telNumber)
        {
            this.UName = uName;
            this.Pword = pword;
            this.Permission = permission;
        }

        public User(string uName, string pword, string permission)
        {
            this.UName = uName;
            this.Pword = pword;
            this.Permission = permission;
        }

        public User(int userId, string uName, string pword)
        {
            this.UName = uName;
            this.Pword = pword;
            this.userId = userId;
        }

        public User(int userId)
        {
            this.UserId = userId;

        }

        public User(int userId, string perm) : this(userId)
        {
            this.UserId = userId;
            this.Permission = perm;
        }

        public User(string uname, string pass, string perm, int userId) : this(userId)
        {
            this.UserId = userId;
            this.Permission = perm;
            this.Pword = pass;
        }

        public User(int userId, string uName, string pword, string fname, string lname, string permission) : base(userId, fname, lname)
        {
            this.UName = uName;
            this.Pword = pword;
            this.Permission = permission;
        }



        public int UserId { get => userId; set => userId = value; }
        public string UName { get => uName; set => uName = value; }
        public string Pword { get => pword; set => pword = value; }
        public string Permission { get => permission; set => permission = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Client
    {
        private int clientID;
        private string firstName;
        private string lastName;
        private string address;
        private string[] phoneNo = new string[2];
        private string NIC;
        private string email;
        private List<Project> projectList;

        public Client()
        {
        }

        //getters and setters
        public int ClientID { get => clientID; set => clientID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string[] PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string NIC1 { get => NIC; set => NIC = value; }
        public string Email { get => email; set => email = value; }
        internal List<Project> ProjectList { get => projectList; set => projectList = value; }
    }

    class Project
    {

        private int projectID;
        private int clientID;
        private string projectName;
        private string type;
        private DateTime firstInitDate;
        private DateTime trainingCmpltDate;
        private DateTime firstEndDate;
        private DateTime secondEndDate;
        private int noOfVisits;
        private DateTime warrantyDate;
        private string terms;
        private string supportTerms;
        private string warrantyTerms;

        public Project()
        {
        }

        //getters and setters
        public int ProjectID { get => projectID; set => projectID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public string Type { get => type; set => type = value; }
        public DateTime FirstInitDate { get => firstInitDate; set => firstInitDate = value; }
        public DateTime TrainingCmpltDate { get => trainingCmpltDate; set => trainingCmpltDate = value; }
        public DateTime FirstEndDate { get => firstEndDate; set => firstEndDate = value; }
        public DateTime SecondEndDate { get => secondEndDate; set => secondEndDate = value; }
        public int NoOfVisits { get => noOfVisits; set => noOfVisits = value; }
        public DateTime WarrantyDate { get => warrantyDate; set => warrantyDate = value; }
        public string Terms { get => terms; set => terms = value; }
        public string SupportTerms { get => supportTerms; set => supportTerms = value; }
        public string WarrantyTerms { get => warrantyTerms; set => warrantyTerms = value; }
        public string ProjectName { get => projectName; set => projectName = value; }

        //other 3 methods

    }

    class Visit
    {
        private int visitID;
        private int projectID;
        private string type;
        private string serviceEng;
        private DateTime fromDateTime;
        private DateTime toDateTime;
        private string vehicalDetails;
        private float mileage;

        public Visit()
        {
        }

        //getter and setter
        public int VisitID { get => visitID; set => visitID = value; }
        public int ProjectID { get => projectID; set => projectID = value; }
        public string Type { get => type; set => type = value; }
        public string ServiceEng { get => serviceEng; set => serviceEng = value; }
        public DateTime FromDateTime { get => fromDateTime; set => fromDateTime = value; }
        public DateTime ToDateTime { get => toDateTime; set => toDateTime = value; }
        public string VehicalDetails { get => vehicalDetails; set => vehicalDetails = value; }
        public float Mileage { get => mileage; set => mileage = value; }

        //other methods
    }

    class Expense
    {
        private int expID;
        private int visitID;
        private string category;
        private string billNo;
        private decimal expense;

        public Expense()
        {
        }

        //getters and setters
        public int ExpID { get => expID; set => expID = value; }
        public int VisitID { get => visitID; set => visitID = value; }
        public string Category { get => category; set => category = value; }
        public string BillNo { get => billNo; set => billNo = value; }
        public decimal Exp { get => expense; set => expense = value; }

        //other methods
    }
}

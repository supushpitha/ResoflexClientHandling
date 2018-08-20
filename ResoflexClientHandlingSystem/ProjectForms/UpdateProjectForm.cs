using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;

namespace ResoflexClientHandlingSystem
{
    public partial class UpdateProjectForm : MetroFramework.Forms.MetroForm
    {
        int projID;
        string name;
        string desc;
        int projSubCatID;
        int clientID;
        DateTime install;
        DateTime firstTrainComp;
        DateTime secondTrainComp;
        int visits;
        DateTime warDate;
        int warPeriod;
        string supTerms;
        string visitTerms;
        string warrTerms;

        public UpdateProjectForm( string name, string desc, int projSubCatID, int clientID, string supTerms, string visitTerms, string warrTerms)
        {
            
            this.name = name;
            this.desc = desc;
            this.projSubCatID = projSubCatID;
            this.clientID = clientID;
            
            this.supTerms = supTerms;
            this.visitTerms = visitTerms;
            this.warrTerms = warrTerms;

            InitializeComponent();
        }

        public UpdateProjectForm()
        {
            InitializeComponent();
        }




        private void UpdateProjectForm_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select name from client");

                while (reader.Read())
                {
                    metroComboBox1.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("select cat_name from proj_category");

                while (reader.Read())
                {
                    catComboBox.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }



            nameTxt.Text = name;
            DescripTxt.Text = desc;
            CatagoTxt.Text = "" +projSubCatID;
            supTermTxt.Text = supTerms;
            visitTermTxt.Text = visitTerms;
            warTerTxt.Text = warrTerms;

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        public void emailClient(String email)
        {
            string subject = "Project Successfully Added";
            string message = "Your Project successfully added to our DataBase. Thank you";

            try
            {
                bool isSuccess = Internet.sendMail(email, subject, message);

                if (isSuccess)
                {
                    MessageBox.Show("Project added mail sent");
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please check your Internet connection");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTxt.Text;
                string description = DescripTxt.Text;
                string catago = CatagoTxt.Text.ToString();

                string supportTerms = supTermTxt.Text;
                string visitTerms = visitTermTxt.Text;
                string warrentyTerms = warTerTxt.Text;

                Client client;

                MySqlDataReader reader = DBConnection.getData("select client_id from client where name='" + metroComboBox1.SelectedItem.ToString() + "';");


                int cid = 0;

                while (reader.Read())
                {
                    cid = int.Parse(reader.GetValue(0).ToString());
                }

                reader.Close();

                client = new Client(cid);

                ResoflexClientHandlingSystem.Role.Project project = new Role.Project(name, description, client, int.Parse(catago), supportTerms, visitTerms, warrentyTerms);

                Database.addProject(project);


                notifySuccessProjectAdding.Icon = SystemIcons.Application;
                notifySuccessProjectAdding.BalloonTipText = "Project Successfully Added!";
                notifySuccessProjectAdding.ShowBalloonTip(1000);

                String email;


                try
                {
                    MySqlDataReader reader1 = DBConnection.getData("Select email from client where client_id='" + client.ClientID + "'");

                    while (reader1.Read())
                    {
                        email = reader1["email"].ToString();
                        emailClient( email);
                    }
                    reader1.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Project Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

 
       
    
    
}

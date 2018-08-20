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
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;

namespace ResoflexClientHandlingSystem
{
    public partial class ProjectUpdate : MetroFramework.Forms.MetroForm
    {
        int projID;
        int clientID;
        DateTime install;
        DateTime firstTrainComp;
        DateTime secondTrainComp;
        DateTime warDate;
        int warPeriod;
        
        public ProjectUpdate(DateTime firstTrainComp, DateTime secondTrainComp, DateTime install, DateTime warDate, int warPeriod)
        {
            InitializeComponent();

            this.firstTrainComp = firstTrainComp;
            this.secondTrainComp = secondTrainComp;
            this.install = install;
            this.warDate = warDate;
            this.warPeriod = warPeriod;
        }

        public ProjectUpdate()
        {
            InitializeComponent();
        }

        private void ProjectUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select proj_name from project");

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


            firstTraCompDate.Text = "" +firstTrainComp;
            secoTraCompDate.Text = "" + secondTrainComp;
            installDate.Text = "" + install;
            warStarDate.Text= "" + warDate;
            warrPerTxt.Text = "" +warPeriod;
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

      /*  private void addBtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string firstTran = firstTraCompDate.Text;
                    string secondTran = secoTraCompDate.Text;
                    string ins = installDate.Text;
                    string warSt = warStarDate.Text;
                    string warPer = warrPerTxt.Text;


                    ResoflexClientHandlingSystem.Role.Project project = new Role.Project(tEndDate1,tEndDate2,firstInitDate,warrantyStart,warrantyPeriod);

                    Database.addProject(project);


                }
                catch (Exception)
                {
                    MessageBox.Show("Every detail must be there!", "Project Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

            }
        }

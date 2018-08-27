using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.ProjectForms
{
    public partial class ProjectProgress : MetroFramework.Forms.MetroForm
    {
        public ProjectProgress()
        {
            InitializeComponent();
        }

        private void ProjectProgress_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select proj_name from project");

                while (reader.Read())
                {
                    selectProjectCombo.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            

        }

        private void selectProjectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select c.name from client c, project p where p.client_id=c.client_id and p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox1.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("select s.sub_cat_name from proj_sub_category s, project p where p.proj_sub_cat_id=s.proj_sub_cat_id and p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox2.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("select p.warranty_period, p.warranty_start_date as Starts  from project p where p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox4.Text = (reader.GetValue(0).ToString());
                    metroTextBox6.Text = (reader.GetValue(1).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }


            try
            {
                MySqlDataReader reader = DBConnection.getData("select count(p.proj_id) from schedule s, project p where s.proj_id=p.proj_id and p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox5.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("select p.description from project p where p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox8.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("select p.first_init_date from project p where p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox11.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("select p.training_comp_second_end_date from project p where p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox13.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("select p.training_comp_first_end_date from project p where p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox12.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("select p.visit_terms from project p where p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox9.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }



            try
            {
                MySqlDataReader reader = DBConnection.getData("select p.warranty_terms from project p where p.proj_name='" + selectProjectCombo.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox10.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}

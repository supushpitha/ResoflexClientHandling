﻿using MySql.Data.MySqlClient;
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

namespace ResoflexClientHandlingSystem
{
    public partial class ProjectRanks : MetroFramework.Forms.MetroForm
    {
        public ProjectRanks()
        {
            InitializeComponent();
        }

        private void ProjectRank_Load(object sender, EventArgs e)
        {
            projectExGrid.DataSource = getProjects();
            visitGrid.DataSource = getVisits();
            projectExGrid.Columns[0].Visible = false;
            visitGrid.Columns[0].Visible = false;
            projectExGrid.ClearSelection();
            visitGrid.ClearSelection();
            warGrid.DataSource = getWarrenty();
            warGrid.Columns[0].Visible = false;
            visitGrid.ClearSelection();
            catGrid.DataSource = getCats();
            catGrid.Columns[0].Visible = false;
            catGrid.ClearSelection();
            
            projectExGrid.Rows[4].Cells[0].Selected = true;


        }





        private DataTable getProjects()
        {
            DataTable table = new DataTable();
            

            MySqlDataReader reader = DBConnection.getData("select p.proj_id, c.name as Client, p.proj_name as Project ,e.amount as Amount from project p, exp_detail_event e, client c where p.proj_id=e.proj_id and p.client_id=c.client_id order by e.amount DESC");

            table.Load(reader);
            projectExGrid.ClearSelection();
            
            return table;


        }


    private DataTable getVisits()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select e.event_id,p.proj_name as Project, c.name as Client ,e.visit_type_id as Type ,e.from_date_time as Date from project p, client c, event e where p.client_id=c.client_id and e.proj_id=p.proj_id");

            table.Load(reader);
            visitGrid.ClearSelection();
            return table;
        }

        private DataTable getCats()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select c.client_id, c.name as Client, p.proj_name as Project, s.sub_cat_name as Category from client c, project p, proj_sub_category s where p.client_id=c.client_id and p.proj_sub_cat_id=s.proj_sub_cat_id order by s.sub_cat_name");

            table.Load(reader);
            visitGrid.ClearSelection();
            return table;
        }


        private DataTable getWarrenty()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select p.proj_id, p.proj_name as Project, c.name as Client, p.warranty_start_date as Warranty_Start ,p.warranty_period as Months from project p, client c where p.client_id=c.client_id order by p.warranty_period");

            table.Load(reader);
            visitGrid.ClearSelection();
            return table;
        }






        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            UpdateProjectForm upPrj = new UpdateProjectForm();

            upPrj.Show();
        }

        private void updateProjectBtn_Click(object sender, EventArgs e)
        {
            ProjectUpdate prjUp = new ProjectUpdate();

            prjUp.Show();


        }

        private void metroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void projectExGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void projectExGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < projectExGrid.Rows.Count; i++)
            {
                int val = Int32.Parse(projectExGrid.Rows[i].Cells[3].Value.ToString());
                if (val >= 7000)
                {
                    projectExGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                
            }
        }

       

        private void visitGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void visitGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < visitGrid.Rows.Count; i++)
            {
                int val = Int32.Parse(visitGrid.Rows[i].Cells[3].Value.ToString());
                if (val >= 2)
                {
                    visitGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }

            }
        }


        private void warGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void warGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < warGrid.Rows.Count; i++)
            {
                int val = Int32.Parse(warGrid.Rows[i].Cells[4].Value.ToString());
                if (val <= 5)
                {
                    warGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }

            }
        }

        private void projectExGrid_SelectionChanged(Object sender, EventArgs e)
        {
            projectExGrid.ClearSelection();
        }
    }
}
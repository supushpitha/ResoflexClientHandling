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
            nameTxt.Text = name;
            DescripTxt.Text = desc;
            CatagoTxt.Text = "" +projSubCatID;
            IDTxt.Text = "" +clientID;
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
    }
}

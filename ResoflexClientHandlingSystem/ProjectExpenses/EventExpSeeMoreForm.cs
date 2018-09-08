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

namespace ResoflexClientHandlingSystem.ProjectExpenses
{
    public partial class EventExpSeeMoreForm : MetroFramework.Forms.MetroForm
    {
        private int projId;
        private int eventId;
        private string project;
        private string client;

        public EventExpSeeMoreForm()
        {
            InitializeComponent();
        }

        public EventExpSeeMoreForm(int projId, int eventId, string project, string client)
        {
            InitializeComponent();

            this.projId = projId;
            this.eventId = eventId;
            this.project = project;
            this.client = client;
        }

        private void EventExpSeeMoreForm_Load(object sender, EventArgs e)
        {

        }

        private void EventExpSeeMoreForm_Shown(object sender, EventArgs e)
        {
            projLbl.Text = project;
            clientLbl.Text = client;

            eventExpMoreGrid.DataSource = geteventExpMore();
        }

        private object geteventExpMore()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select x.dateOfExp as Date, t.type as Exp_Type, x.amount as Amount, x.paymentType as Paid_Type, x.comment as " +
                "Comment from exp_detail_event x inner join expense_type t on x.exp_type_id=t.exp_type_id where x.proj_id=" + projId + " and x.event_id=" + eventId + " " +
                "order by x.dateOfExp, t.exp_type_id");

            table.Load(reader);

            return table;
        }
    }
}

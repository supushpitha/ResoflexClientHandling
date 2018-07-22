using MySql.Data.MySqlClient;
using System;
using ResoflexClientHandlingSystem.Role;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.Core
{
    class Database
    {
        public static void saveClient(Client client)
        {
            string id = client.NIC;
            string name = client.FirstName;
            string[] tel = client.PhoneNo;
            string add = client.Address;
            try
            {
                DBConnection.updateDB("insert into client (name, tel, add) values ('"+name+"','"+tel+ "','"+add+"');");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void updateClient(Client client) {

            string nic = client.NIC;
            string name = client.FirstName;
            string[] tel = client.PhoneNo;
            string add = client.Address;

            try
            {
                DBConnection.updateDB("update client set name = '" + name + "', tel = '" + tel + "', add = '" + add + "' where nic = '"+nic+"');");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

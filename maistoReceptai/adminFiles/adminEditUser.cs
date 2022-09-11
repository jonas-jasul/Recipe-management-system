using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maistoReceptai
{
    public partial class adminEditUser : Form
    {
        public adminEditUser()
        {
            InitializeComponent();
            this.Text = "Redaguoti vartotojus";
        }

        private void editUserAtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            connection.Open();
            SqlCommand update = new SqlCommand("Update Vartotojai Set vartotojoVardas=@vNick, vartFirstName=@vVardas, vartLastName=@vPavard, vartEmail=@vEmail, vartDoB=@vDoB, vartPref=@vPref Where ID=@vID", connection);
            update.Parameters.AddWithValue("@vNick", editUserNick.Text);
            update.Parameters.AddWithValue("@vVardas", editUserName.Text);
            update.Parameters.AddWithValue("@vPavard", editUserLastName.Text);
            update.Parameters.AddWithValue("@vEmail", editUserEmail.Text);
            update.Parameters.AddWithValue("@vDoB", editUserDoB.Value);
            update.Parameters.AddWithValue("@vPref", editUserRecType.SelectedItem);
            update.Parameters.AddWithValue("@vID", editUserID.Text);
            update.ExecuteNonQuery();
            connection.Close();



        }

        private void editUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void editUserLastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void editUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void editUserLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}

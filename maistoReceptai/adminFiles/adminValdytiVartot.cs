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
    public partial class adminValdytiVartot : UserControl
    {

        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        private static adminValdytiVartot _instance;
        public static adminValdytiVartot Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new adminValdytiVartot();
                return _instance;
            }
        }
        public adminValdytiVartot()
        {
            InitializeComponent();
            con1.Open();
            da = new SqlDataAdapter("select ID, vartotojoVardas, vartFirstName, vartLastName, vartEmail, vartDoB, vartPref from Vartotojai", con1);
            con1.Close();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns[1].HeaderText = "Slapyvardis";
            dataGridView1.Columns[2].HeaderText = "Vardas";
            dataGridView1.Columns[3].HeaderText = "Pavardė";
            dataGridView1.Columns[4].HeaderText = "El. paštas";
            dataGridView1.Columns[5].HeaderText = "Gimimo data";
            dataGridView1.Columns[6].HeaderText = "Pasirinktas tipas";
           

        }

        private void atnaujintiToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vartotojaiTableAdapter.Atnaujinti(this.database1DataSet3.Vartotojai);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

     

        private void refreshAdminVartotBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            string sqlQuery = "select ID, vartotojoVardas, vartFirstName, vartLastName, vartEmail, vartDoB, vartPref from Vartotojai";
            SqlCommand sqlcomm = new SqlCommand(sqlQuery, sqlc);
            sqlc.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void removeAdminVartot_Click(object sender, EventArgs e)
        {
            /*SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            string sqlQuery = "select ID, vartotojoVardas from Vartotojai";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataGridView1.Rows.Remove(row);
            }
            da.Update(dt);
            */

            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    var index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
                    con2.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from Vartotojai WHERE ID=@ID", con2);
                    cmd.Parameters.Add(new SqlParameter("ID", index));
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    cmd.ExecuteNonQuery();
                    con2.Close();
                }

            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminValdytiVartot_Load(object sender, EventArgs e)
        {

        }

        private void adminEditUser_Click(object sender, EventArgs e)
        {
            adminEditUser edituser = new adminEditUser();
            edituser.editUserID.Text= this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            edituser.editUserNick.Text= this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edituser.editUserName.Text= this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            edituser.editUserLastName.Text= this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            edituser.editUserEmail.Text= this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            edituser.editUserDoB.Text= this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            edituser.editUserRecType.SelectedItem= this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            edituser.Show();
        }
    }
}

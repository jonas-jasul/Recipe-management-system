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
    public partial class ziuretiReceptAdmin : UserControl
    {
        public static int cellValue;

        SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        DataView dv;
        private static ziuretiReceptAdmin _instance;
        public static ziuretiReceptAdmin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ziuretiReceptAdmin();
                return _instance;
            }
        }
        public ziuretiReceptAdmin()
        {
            InitializeComponent();

            /*con2.Open();
            da = new SqlDataAdapter("Delete ID from Recept_ingred_nuotrauka", con2);
            con2.Close();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/

        }

        public ziuretiReceptAdmin(ListBox box)
        {
            InitializeComponent();
            
        }

        private void CompareDelete(string strTagNumb, string strAtual, DataView dtv)
        {
            foreach (DataRowView row in dtv)
            {
                if (row.Row["receptoPavadinimas"].ToString().Equals(strAtual))
                {
                    string nl = Environment.NewLine;
                    row.Row["IngredientoPavadinimas"] += string.Concat(nl, ", ", strTagNumb.ToLower());
                    return;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            
            DataGridViewRow rowApr = dataGridView1.CurrentCell.OwningRow;
            
            string value = rowApr.Cells["AprasasTxt"].Value.ToString();
            receptDescForm rdc = new receptDescForm(value);
            rdc.Show();
        }

        private void ziurRecAtn_Click(object sender, EventArgs e)
        {
            filterByTypeUsr.ClearSelected();
            string mainconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();

            //string sqlquery = "Select rin.receptoID, r.receptoPavadinimas, i.IngredientoPavadinimas, rin.VegOrNonVeg, n.Nuotraukos_img, a.AprasasTxt, t.ParuosimLaikasVal FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID INNER JOIN ParuosimLaikas t ON rin.laikoID=t.LaikoID";
            string sqlquery = "Select rin. ID, rin.receptoID, r.receptoPavadinimas, i.IngredientoPavadinimas, rin.VegOrNonVeg, t.ParuosimLaikasVal, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN ParuosimLaikas t ON rin.laikoID=t.LaikoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";

            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();


            DataView dv = new DataView(dt);
            String strAtual = String.Empty;
            foreach (DataRowView row in dv)
            {
                if (strAtual.Equals(row.Row["receptoPavadinimas"].ToString()))
                {
                    string strTagNumb = row["IngredientoPavadinimas"].ToString();
                    CompareDelete(strTagNumb, strAtual, dv);
                    row.Delete();
                    continue;
                }

                if (!string.IsNullOrEmpty(row.Row["receptoPavadinimas"].ToString()))
                    strAtual = row.Row["receptoPavadinimas"].ToString();
            }
            dataGridView1.DataSource = dv;


            DataGridViewColumn column = dataGridView1.Columns[6];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((DataGridViewImageColumn)dataGridView1.Columns[6]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            //dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[1].Width = 30;

            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[4].Width = 88;

            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[5].Width =60;

            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[6].Width = 120;

            dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[1].Visible = false;


            //dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "rID";
            dataGridView1.Columns[2].HeaderText = "Recepto pavadinimas";
            dataGridView1.Columns[3].HeaderText = "Ingredientai";
            dataGridView1.Columns[4].HeaderText = "Tipas";
            dataGridView1.Columns[5].HeaderText = "Paruošimo laikas (mins)";
            dataGridView1.Columns[6].HeaderText = "Nuotrauka";

        }

        private void ziurRecAdmDel_Click(object sender, EventArgs e)
        {
            /* foreach(DataGridViewRow row in dataGridView1.SelectedRows)
             {
                 if(!row.IsNewRow)
                 {
                     dataGridView1.Rows.Remove(row);
                 }
             }*/

            
            try
            {
                foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    var index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                    SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
                    con2.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from Recept_ingred_nuotrauka WHERE receptoID=@ID", con2);
                    cmd.Parameters.Add(new SqlParameter("ID", index));
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    cmd.ExecuteNonQuery();
                    con2.Close();
                }
               
            }
            catch(System.Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            

            ziurRecAtn_Click(sender, e);
            //da.Update(dt);
        }

        private void ziuretiReceptAdmin_Load(object sender, EventArgs e)
        {

            dataGridView1.RowTemplate.Height = 50;
        }

        private void filterByIngred_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterByName_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterByName_TextChanged_1(object sender, EventArgs e)
        {
            string mainconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "Select rin.receptoID, r.receptoPavadinimas, i.IngredientoPavadinimas, rin.VegOrNonVeg, t.ParuosimLaikasVal, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN ParuosimLaikas t ON rin.laikoID=t.LaikoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";

            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
           
            sqlconn.Close();
            DataView dw = new DataView(dt);

            DataView dv = new DataView(dt);
            String strAtual = String.Empty;
            foreach (DataRowView row in dv)
            {
                if (strAtual.Equals(row.Row["receptoPavadinimas"].ToString()))
                {
                    string strTagNumb = row["IngredientoPavadinimas"].ToString();
                    CompareDelete(strTagNumb, strAtual, dv);
                    row.Delete();
                    continue;
                }

                if (!string.IsNullOrEmpty(row.Row["receptoPavadinimas"].ToString()))
                    strAtual = row.Row["receptoPavadinimas"].ToString();
            }
          

            dw.RowFilter = string.Format("receptoPavadinimas LIKE '%{0}%'", filterByName.Text);
            dataGridView1.DataSource = dw;
        }

        private void filterByIngred_TextChanged_1(object sender, EventArgs e)
        {
            string mainconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "Select rin.receptoID, r.receptoPavadinimas, i.IngredientoPavadinimas, rin.VegOrNonVeg, t.ParuosimLaikasVal, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN ParuosimLaikas t ON rin.laikoID=t.LaikoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            sqlconn.Close();

            DataView dv = new DataView(dt);
            String strAtual = String.Empty;
            foreach (DataRowView row in dv)
            {
                if (strAtual.Equals(row.Row["receptoPavadinimas"].ToString()))
                {
                    string strTagNumb = row["IngredientoPavadinimas"].ToString();
                    CompareDelete(strTagNumb, strAtual, dv);
                    row.Delete();
                    continue;
                }

                if (!string.IsNullOrEmpty(row.Row["receptoPavadinimas"].ToString()))
                    strAtual = row.Row["receptoPavadinimas"].ToString();
            }
            
            dv.RowFilter = string.Format("IngredientoPavadinimas LIKE '%{0}%'", filterByIngred.Text);
            dataGridView1.DataSource = dv;
        }

        private void filterByTypeUsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mainconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "Select rin.receptoID, r.receptoPavadinimas, i.IngredientoPavadinimas, rin.VegOrNonVeg, t.ParuosimLaikasVal, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN ParuosimLaikas t ON rin.laikoID=t.LaikoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";

            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            sqlconn.Close();
            DataView dw = new DataView(dt);

            DataView dv = new DataView(dt);
            String strAtual = String.Empty;
            foreach (DataRowView row in dv)
            {
                if (strAtual.Equals(row.Row["receptoPavadinimas"].ToString()))
                {
                    string strTagNumb = row["IngredientoPavadinimas"].ToString();
                    CompareDelete(strTagNumb, strAtual, dv);
                    row.Delete();
                    continue;
                }

                if (!string.IsNullOrEmpty(row.Row["receptoPavadinimas"].ToString()))
                    strAtual = row.Row["receptoPavadinimas"].ToString();
            }

            dw.RowFilter = string.Format("VegOrNonVeg LIKE '{0}'", filterByTypeUsr.SelectedItem);
            dataGridView1.DataSource = dw;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminEditRecep_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int cellValue = 0;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                cellValue = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            }
        }

        private void filterByIngred_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            }
            catch
            {
                MessageBox.Show("Įveskite raidę");
            }
        }

        private void filterByName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            }
            catch
            {
                MessageBox.Show("Įveskite raidę");
            }
        }

        /*  private void adminEditRecep_Click_1(object sender, EventArgs e)
          {
              editRecipeBox editbox = new editRecipeBox();

              editbox.editRecID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
              editbox.editRecName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
              editbox.editRecType.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
              editbox.editRecTime.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
              editbox.editRecRID.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

              editbox.Show();
          }*/
    }
}

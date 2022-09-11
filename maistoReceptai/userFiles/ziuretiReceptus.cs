using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace maistoReceptai
{
    public partial class ziuretiReceptus : UserControl
    {

        public bool isNonVeg;
        private static ziuretiReceptus _instance;
        public static ziuretiReceptus Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ziuretiReceptus();
                return _instance;
            }
        }
        public ziuretiReceptus()
        {
            InitializeComponent();
            isNonVeg = userSettings.isNonVeg;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            /*var rowIndex = e.RowIndex;
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;*/
            /*  var receptDesc = new receptDescForm();
              receptDesc.Show();*/
            //receptDescForm ob = new receptDescForm(id);
            DataGridViewRow rowApr = dataGridView1.CurrentCell.OwningRow;
            //string value = dataGridView1.CurrentCell.Value.ToString();
            string value = rowApr.Cells["AprasasTxt"].Value.ToString();
            receptDescForm rdc = new receptDescForm(value);
            rdc.Show();
        }

        private void ziuretiReceptus_Load(object sender, EventArgs e)
        {

            dataGridView1.RowTemplate.Height = 50;
            
        }

     /*   bool IsTheSameValue (int column, int row)
        {
            DataGridViewCell cell1 = dataGridView1[column, row];
            DataGridViewCell cell2 = dataGridView1[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }
*/
       /* private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if(IsTheSameValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }

            else
            {
                e.AdvancedBorderStyle.Top = dataGridView1.AdvancedCellBorderStyle.Top;
            }
        }
*/
       /* private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex==0)
                return;
            if(IsTheSameValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
*/
        private void CompareDelete(string strTagNumb, string strAtual, DataView dt)
        {
            foreach (DataRowView row in dt)
            {
                if(row.Row["receptoPavadinimas"].ToString().Equals(strAtual))
                {
                    string nl = Environment.NewLine;
                    row.Row["IngredientoPavadinimas"] += string.Concat(nl,", ", strTagNumb.ToLower());
                    return;
                }
            }
        }

        private void ziurRecAtn_Click(object sender, EventArgs e)
        {
            filterByTypeUsr.ClearSelected();
            string mainconn= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();
            //string sqlquery = "Select rin.ID, r.receptoPavadinimas, i.IngredientoPavadinimas, n.Nuotraukos_img FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID";

            string sqlquery = "Select rin.receptoID, r.receptoPavadinimas, i.IngredientoPavadinimas, rin.VegOrNonVeg, t.ParuosimLaikasVal, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN ParuosimLaikas t ON rin.laikoID=t.LaikoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
  
            sqlconn.Close();


            DataView dv = new DataView(dt);
            String strAtual = String.Empty;
            foreach(DataRowView row in dv)
            {
                if(strAtual.Equals(row.Row["receptoPavadinimas"].ToString()))
                {
                    string strTagNumb =row["IngredientoPavadinimas"].ToString();
                    CompareDelete(strTagNumb, strAtual, dv);
                    row.Delete();
                    continue;
                }

                if (!string.IsNullOrEmpty(row.Row["receptoPavadinimas"].ToString()))
                    strAtual = row.Row["receptoPavadinimas"].ToString(); 
            }
            dataGridView1.DataSource = dv;


            DataGridViewColumn column = dataGridView1.Columns[5];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((DataGridViewImageColumn)dataGridView1.Columns[5]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
           
            //dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[3].Width = 88;

            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[4].Width = 60;

            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[5].Width = 120;

            dataGridView1.Columns[1].HeaderText = "Recepto pavadinimas";
            dataGridView1.Columns[2].HeaderText = "Ingredientai";
            dataGridView1.Columns[3].HeaderText = "Tipas";
            dataGridView1.Columns[4].HeaderText = "Paruošimo laikas (mins)";
            dataGridView1.Columns[5].HeaderText = "Nuotrauka";

           /* BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            if(isNonVeg)
            {
                bs.Filter = "VegOrNonVeg LIKE '%" + "Nevegetariškas" + "%'";
                dataGridView1.DataSource = bs;
            }*/



        }

        private void filterByName_TextChanged(object sender, EventArgs e)
        {
            string mainconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            //string sqlquery = "Select rin.ID, r.receptoPavadinimas, i.IngredientoPavadinimas, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";
            string sqlquery = "Select rin.receptoID, r.receptoPavadinimas, i.IngredientoPavadinimas, rin.VegOrNonVeg, t.ParuosimLaikasVal, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN ParuosimLaikas t ON rin.laikoID=t.LaikoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";

            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            //dataGridView1.DataSource = dt;
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
            //dataGridView1.DataSource = dv;

            dw.RowFilter = string.Format("receptoPavadinimas LIKE '%{0}%'", filterByName.Text);
            dataGridView1.DataSource = dw;
        }

        private void filterByIngred_TextChanged(object sender, EventArgs e)
        {
            string mainconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            //string sqlquery = "Select rin.ID, r.receptoPavadinimas, i.IngredientoPavadinimas, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";
            string sqlquery = "Select rin.receptoID, r.receptoPavadinimas, i.IngredientoPavadinimas, rin.VegOrNonVeg, t.ParuosimLaikasVal, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN ParuosimLaikas t ON rin.laikoID=t.LaikoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            //dataGridView1.DataSource = dt;
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
            //dataGridView1.DataSource = dv;

           //DataView dw = new DataView(dt);
            dv.RowFilter = string.Format("IngredientoPavadinimas LIKE '%{0}%'", filterByIngred.Text);
            dataGridView1.DataSource = dv;
        }

        private void filterByTypeUsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mainconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            //string sqlquery = "Select rin.ID, r.receptoPavadinimas, i.IngredientoPavadinimas, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";
            string sqlquery = "Select rin.receptoID, r.receptoPavadinimas, i.IngredientoPavadinimas, rin.VegOrNonVeg, t.ParuosimLaikasVal, n.Nuotraukos_img, a.AprasasTxt FROM Recept_ingred_nuotrauka rin inner JOIN Receptai r ON rin.ReceptoID=r.ReceptoID INNER JOIN Ingredientai i ON rin.IngredientoID=i.IngredientoID INNER JOIN ParuosimLaikas t ON rin.laikoID=t.LaikoID INNER JOIN Nuotraukos n ON rin.NuotraukaID=n.NuotraukaID INNER JOIN Aprasas a ON rin.AprasoID=a.AprasoID";

            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            //dataGridView1.DataSource = dt;
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
            //dataGridView1.DataSource = dv;

            dw.RowFilter = string.Format("VegOrNonVeg LIKE '{0}'", filterByTypeUsr.SelectedItem);
            dataGridView1.DataSource = dw;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}

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
using System.IO;

namespace maistoReceptai
{
    public partial class adminPridetiRec : UserControl
    {
        private static adminPridetiRec _instance;
        public static adminPridetiRec Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new adminPridetiRec();
                return _instance;
            }
        }
        public adminPridetiRec()
        {
            InitializeComponent();
        }



        private void ingred_admin_Box1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int id3=0;
            if (ingred_admin_Box1.SelectedIndex > -1)
            {
                DataRowView data = ingred_admin_Box1.SelectedItem as DataRowView;
                id3 = int.Parse(data["IngredientoID"].ToString());
                string name = data["IngredientoPavadinimas"].ToString();
            }
            MessageBox.Show(id3.ToString());*/
        }

        private void adminPridetiRec_Load(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            string sqlQuery = "select IngredientoPavadinimas, IngredientoID from Ingredientai";
            SqlCommand sqlcomm = new SqlCommand(sqlQuery, sqlc);
            sqlc.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            ingred_admin_Box1.ValueMember = "IngredientoID";
            ingred_admin_Box1.DisplayMember = "IngredientoPavadinimas";
            ingred_admin_Box1.DataSource = dt;
            sqlc.Close();

        }

        private void ikeltFoto_Click(object sender, EventArgs e)
        {
           
            Stream myStream = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files(*.jpg; *.jpeg; *.gif; *.png;)|*.jpg; *.jpeg; *.gif; *.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = dialog.FileName;
                try
                {
                    recNuotrauka.Load(FileName);
                }
                catch
                {
                    MessageBox.Show("Įkelkite nuotrauką");
                }
            }

        }

        private void PridetiRec_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(receptoPav.Text))
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
                connection.Open();

                MemoryStream ms = new MemoryStream();
                try
                {
                    recNuotrauka.Image.Save(ms, recNuotrauka.Image.RawFormat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                byte[] Nuotraukos_img = ms.ToArray();
                SqlCommand cmd = new SqlCommand("Insert Into Nuotraukos (Nuotraukos_img) Values(@Nuotraukos_img) SELECT CAST (SCOPE_IDENTITY() As int)", connection);

                cmd.Parameters.AddWithValue("@Nuotraukos_img", Nuotraukos_img);
                int id2 = Convert.ToInt32(cmd.ExecuteScalar());


                SqlCommand sqlCmmnd = new SqlCommand("Insert into Receptai (receptoPavadinimas) Values(@receptoPavadinimas) SELECT CAST (SCOPE_IDENTITY() As int)", connection);
                sqlCmmnd.Parameters.AddWithValue("@receptoPavadinimas", receptoPav.Text);
                int id1 = Convert.ToInt32(sqlCmmnd.ExecuteScalar());

                SqlCommand cmdDesc = new SqlCommand("Insert into Aprasas (AprasasTxt) Values (@AprasasTxt) SELECT CAST (SCOPE_IDENTITY() As int)", connection);
                cmdDesc.Parameters.AddWithValue("@AprasasTxt", receptDescTxtBox.Text);
                int idDesc = Convert.ToInt32(cmdDesc.ExecuteScalar());

                SqlCommand cmdTime = new SqlCommand("Insert into ParuosimLaikas (paruosimLaikasVal) Values (@laikas) SELECT CAST (SCOPE_IDENTITY() As int)", connection);
                cmdTime.Parameters.AddWithValue("@laikas", adminPridRecTime.Value);
                int idTime = Convert.ToInt32(cmdTime.ExecuteScalar());

                string rectype = "";
                if (radioVeg.Checked)
                {
                    rectype = radioVeg.Text;
                }
                else if (radioNonVeg.Checked)
                {
                    rectype = radioNonVeg.Text;
                }

                var lst = ingred_admin_Box1.SelectedItems.Cast<DataRowView>();
                string text2 = "";
                foreach (var item in lst)
                {
                    text2 = item.Row[1].ToString();
                    //SqlCommand commandName1 = new SqlCommand("insert into Recept_ingred_nuotrauka(receptoID, NuotraukaID, IngredientoID, AprasoID) values (@ReceptoID_1, @NuotraukaID_1, @IngredientoID_1, @AprasasID_1)", connection);

                    SqlCommand commandName1 = new SqlCommand("insert into Recept_ingred_nuotrauka(receptoID, NuotraukaID, IngredientoID, AprasoID, VegOrNonVeg, laikoID) values (@ReceptoID_1, @NuotraukaID_1, @IngredientoID_1, @AprasasID_1, @VegOrNonVeg_1, @laikoID_1)", connection);

                    commandName1.Parameters.AddWithValue("@ReceptoID_1", id1);
                    commandName1.Parameters.AddWithValue("@NuotraukaID_1", id2);
                    commandName1.Parameters.AddWithValue("@IngredientoID_1", text2);
                    commandName1.Parameters.AddWithValue("@AprasasID_1", idDesc);
                    commandName1.Parameters.AddWithValue("@VegOrNonVeg_1", rectype);
                    commandName1.Parameters.AddWithValue("@laikoID_1", idTime);
                    commandName1.ExecuteNonQuery();
                }


                SqlConnection sqlc2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");




                /*SqlCommand commandName1 = new SqlCommand("insert into Recept_ingred_nuotrauka(receptoID, NuotraukaID, IngredientoID) values (@ReceptoID_1, @NuotraukaID_1, @IngredientoID_1)", connection);
                //SqlCommand commandName1 = new SqlCommand("insert into Recept_ingred_nuotrauka(receptoID, NuotraukaID) values (@ReceptoID_1, @NuotraukaID_1)", connection);

                commandName1.Parameters.AddWithValue("@ReceptoID_1", id1);
                commandName1.Parameters.AddWithValue("@NuotraukaID_1", id2);
                commandName1.Parameters.AddWithValue("@IngredientoID_1", text2);
                commandName1.ExecuteNonQuery();*/

                //sqlCmmnd.ExecuteNonQuery();
                //cmd.ExecuteNonQuery();
                connection.Close();
              
                if (ingred_admin_Box1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Pasirinkite bent vieną ingredientą!");
                    

                }
                else
                {
                    MessageBox.Show("Įkelta");
                }
                
            }
            
            else
            {
                MessageBox.Show("Įveskite pavadinimą!");
            }
        }

        private void receptoPav_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshIngred_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            string sqlQuery = "select IngredientoPavadinimas, IngredientoID from Ingredientai";
            SqlCommand sqlcomm = new SqlCommand(sqlQuery, sqlc);
            sqlc.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            ingred_admin_Box1.ValueMember = "IngredientoID";
            ingred_admin_Box1.DisplayMember = "IngredientoPavadinimas";
            ingred_admin_Box1.DataSource = dt;
            sqlc.Close();
        }

        private void pridetReceptDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminPridRecRemPhoto_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Resources\blankIMG2.png");
            recNuotrauka.Image = img;
        }

        private void ikeltIngredToTxtBox_Click(object sender, EventArgs e)
        {

            /*SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            string sqlQuery = "select IngredientoPavadinimas, IngredientoID from Ingredientai";
            SqlCommand sqlcomm = new SqlCommand(sqlQuery, sqlc);
            sqlc.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            ingred_admin_Box1.ValueMember = "IngredientoID";
            ingred_admin_Box1.DisplayMember = "IngredientoPavadinimas";
            ingred_admin_Box1.DataSource = dt;*/

            string value = "";
            foreach (var item in ingred_admin_Box1.SelectedItems)
            {
                value += "\n" + ((DataRowView)item)["IngredientoPavadinimas"].ToString() +": " + System.Environment.NewLine;
            }

            receptDescTxtBox.Text = value;

        }

        private void adminPridRecTime_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void receptoPav_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}

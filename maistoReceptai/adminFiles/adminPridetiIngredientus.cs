using System;
using System.Collections;
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
    public partial class adminPridetiIngredientus : UserControl
    {

        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
        //SqlDataAdapter da;
        //DataTable dt;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\JONCE\SOURCE\REPOS\MAISTORECEPTAI\MAISTORECEPTAI\DATABASE1.MDF;Integrated Security=True";
        private static adminPridetiIngredientus _instance;
        public static adminPridetiIngredientus Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new adminPridetiIngredientus();
                return _instance;
            }
        }
        public adminPridetiIngredientus()
        {
            
            InitializeComponent();

            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select IngredientoPavadinimas FROM Ingredientai", con1);
            con1.Close();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ingred_admin_Box2.DataSource = dt;
            

        }
        static int id3;
         
        public void adminPridetiIngredienta_btn_Click(object sender, EventArgs e)
        {
            if(adminPridetiIngredienta_pav.Text=="" || adminPridetiIngredienta_pav.Text==" ")
            {
                MessageBox.Show("Įveskite ingrediento pavadinimą!");
            }
             else
            {
                using (SqlConnection sqlCnnct = new SqlConnection(connectionString))
                {
                    sqlCnnct.Open();
                    SqlCommand sqlCmmnd = new SqlCommand("INSERT into Ingredientai(IngredientoPavadinimas) Values(@IngredientoPavadinimas) SELECT CAST (SCOPE_IDENTITY() As int)", sqlCnnct);
                    //sqlCmmnd.CommandType = CommandType.StoredProcedure;
                    sqlCmmnd.Parameters.AddWithValue("@IngredientoPavadinimas", adminPridetiIngredienta_pav.Text);
                    MessageBox.Show("Ingredientas pridėtas sėkmingai");

                    id3 = Convert.ToInt32(sqlCmmnd.ExecuteScalar());
                    refreshIngred_Click(sender, e);
                }
            }
            
        }

        private void adminPridetiIngredientus_Load(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            string sqlQuery = "select IngredientoPavadinimas, IngredientoID from Ingredientai";
            SqlCommand sqlcomm = new SqlCommand(sqlQuery, sqlc);
            sqlc.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            //ingred_admin_Box2.ValueMember = "IngredientoID";
            ingred_admin_Box2.DisplayMember = "IngredientoPavadinimas";
            ingred_admin_Box2.DataSource = dt;
            sqlc.Close();



        }

        private void deleteSlcIngr_Click(object sender, EventArgs e)
        {
            string text = ingred_admin_Box2.GetItemText(ingred_admin_Box2.SelectedItem);

            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            con2.Open();
            SqlCommand cmd = new SqlCommand("DELETE from Ingredientai WHERE IngredientoPavadinimas=@pav", con2);
            cmd.Parameters.Add(new SqlParameter("pav", text));
            cmd.ExecuteNonQuery();
            con2.Close();
            refreshIngred_Click(sender, e);
        }

        private void ingred_admin_Box2_SelectedIndexChanged(object sender, EventArgs e)
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
            ingred_admin_Box2.ValueMember = "IngredientoID";
            ingred_admin_Box2.DisplayMember = "IngredientoPavadinimas";
            ingred_admin_Box2.DataSource = dt;
            sqlc.Close();

        }

        private void adminPridetiIngredienta_pav_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}

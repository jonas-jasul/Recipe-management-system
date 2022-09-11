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
    public partial class editRecipeBox : Form
    {
        public int cellValue;
        public editRecipeBox()
        {
            InitializeComponent();
            cellValue = ziuretiReceptAdmin.cellValue;
            this.Text = "Redaguoti receptą";


        }
        public editRecipeBox(ListBox.ObjectCollection items)
        {
            InitializeComponent();
            //editRecIngredBox.Items.AddRange(items);

        }

        private void editRecipeBox_Load(object sender, EventArgs e)
        {
           /* SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            string sqlQuery = "select IngredientoPavadinimas, IngredientoID from Ingredientai";
            SqlCommand sqlcomm = new SqlCommand(sqlQuery, sqlc);
            sqlc.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            //ingred_admin_Box2.ValueMember = "IngredientoID";
            editRecIngredBox.DisplayMember = "IngredientoPavadinimas";
            editRecIngredBox.DataSource = dt;
            sqlc.Close();*/

        }

        private void editRecAtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            connection.Open();

         
            SqlCommand cmdPav = new SqlCommand("Insert into Receptai (receptoPavadinimas) Values(@receptoPavadinimas) SELECT CAST (SCOPE_IDENTITY() As int)", connection);
            cmdPav.Parameters.AddWithValue("@receptoPavadinimas", editRecName.Text);
            int id1 = Convert.ToInt32(cmdPav.ExecuteScalar());

            SqlCommand cmdTime = new SqlCommand("Insert into ParuosimLaikas (paruosimLaikasVal) Values (@laikas) SELECT CAST (SCOPE_IDENTITY() As int)", connection);
            cmdTime.Parameters.AddWithValue("@laikas", editRecTime.Value);
            int id2 = Convert.ToInt32(cmdTime.ExecuteScalar());

            SqlCommand delete = new SqlCommand("Delete from Receptai where receptoID=@IDtoDel", connection);
            delete.Parameters.AddWithValue("@IDtoDel", editRecRID.Text);

        

            string selectedType = editRecType.SelectedItem.ToString();

            SqlCommand update = new SqlCommand("Update rin Set rin.receptoID=@id1, rin.laikoID=@id2, rin.VegOrNonVeg=@type From Recept_ingred_nuotrauka rin Inner Join Receptai r On rin.ReceptoID=r.ReceptoID Inner Join ParuosimLaikas pl on rin.laikoID=pl.LaikoID Where rin.ID=@newrecID", connection);
            update.Parameters.AddWithValue("@id1", id1);
            update.Parameters.AddWithValue("@id2", id2);
            update.Parameters.AddWithValue("@type", selectedType);
           
            update.Parameters.AddWithValue("@newrecID", editRecID.Text);
            update.ExecuteNonQuery();

            //SqlCommand update = new SqlCommand("Update rin Set rin.receptoID=@id1, rin.laikoID=@id2 From Recept_ingred_nuotrauka rin Inner Join Receptai r On rin.ReceptoID=r.ReceptoID Inner Join ParuosimLaikas pl on rin.laikoID=pl.LaikoID Where rin.ID=@newrecID", connection);
            
            //update.Parameters.AddWithValue("@newrecRID", editRecRID);
            
            delete.ExecuteNonQuery();
            connection.Close();
           
            //String command = "UPDATE Recept_ingred_nuotrauka SET vartFirstName=@vartFirstName, vartLastName=@vartLastName, vartEmail=@vartEmail, vartotojoVardas=@vartotojoVardas, vartDoB=@vartDoB, vartPref=@vartPref WHERE ID=@ID";

        }
    }
}

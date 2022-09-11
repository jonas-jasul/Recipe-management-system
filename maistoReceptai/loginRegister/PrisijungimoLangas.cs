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
using static maistoReceptai.userSettings;
using System.Security.Cryptography;
using System.IO;

namespace maistoReceptai
{
    public partial class PrisijungimoLangas : Form
    {
       

        public static int UserID;
        //SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");

       string salt = "560A18CD-6346-4CF0-A2E8-671F9B6B9EA9";

        public PrisijungimoLangas()
        {
            
            InitializeComponent();
            /*PrisijungimoLangas pris = new PrisijungimoLangas();
            pris.StartPosition = FormStartPosition.CenterScreen;
            */
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var regLangas = new RegistracijosLangas();
            regLangas.Show();
        }

     
        public void prisijungPrisijungti_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");

            //string decPw = encDec.Decrypt(encDec.Encrypt(prisijungSlaptazodis.Text.Trim().));
            //SqlDataAdapter sdapater2 = new SqlDataAdapter("SELECT * FROM Vartotojai", sqlc);
           
            //DataTable dt = new DataTable();
            //sdapater2.Fill(dt);
            //string name = encDec.Decrypt(prisijungVardas.Text);
            /*bool contains = dt.AsEnumerable().Any(row => name == row.Field<String>("vartotojoVArdas"));
            if (contains)
            {
                MessageBox.Show("Contains");
            }*/

            sqlc.Open();

            //alternatyvus prisijungimo kodas
            /*SqlCommand cmd = new SqlCommand(@"Select ID from Vartotojai where vartotojoVardas=@name and slaptazodis=@pwd", sqlc);

             cmd.Parameters.AddWithValue("@pwd", prisijungSlaptazodis.Text.Trim());
             cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = prisijungSlaptazodis.Text.Trim();
             object result = cmd.ExecuteScalar();
             sqlc.Close();

             //MessageBox.Show(result.ToString());

             if (result != null)
             {
                 UserID = Convert.ToInt32(result);
                 PagrPrograma pgr = new PagrPrograma();
                 this.Hide();
                 pgr.Show();
                 //MessageBox.Show(UserID.ToString());


             }

             else
             {
                 MessageBox.Show("Neteisingas slapyvardis arba slaptažodis");

             }
 */
            SqlDataAdapter sdapater = new SqlDataAdapter("SELECT * FROM Vartotojai WHERE vartotojoVardas ='" + prisijungVardas.Text + "' AND slaptazodis = '" + rms.EncryptRijndael(prisijungSlaptazodis.Text, salt) +"'",sqlc);
            DataTable dttable = new DataTable();
            sdapater.Fill(dttable);
            //bool contains = dt.AsEnumerable().Any(row => name == row.Field<String>("vartotojoVardas"));
            if (dttable.Rows.Count > 0)
            {
                UserID = dttable.Rows[0].Field<int>("ID");
                this.Hide();
                PagrPrograma pgr = new PagrPrograma();
                pgr.Show();
            }

           
            else { MessageBox.Show("Neteisingas slapyvardis arba slaptažodis"); }

        }

        private void PrisijungimoLangas_Load(object sender, EventArgs e)
        {
            
        }

        private void prisijungVardas_TextChanged(object sender, EventArgs e)
        {

        }

        private void prisijungAdmin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            using (sqlc)
            {   
                //sqlc.Open();
                SqlDataAdapter sdapater = new SqlDataAdapter("SELECT adminVardas, adminSlaptazodis FROM Admin WHERE adminVardas ='" + prisijungVardas.Text + "' AND adminSlaptazodis = '" + prisijungSlaptazodis.Text + "'", sqlc);
                DataTable dttable = new DataTable();
                sdapater.Fill(dttable);
                if (dttable.Rows.Count == 1)
                {
                    this.Hide();
                    AdminPanelesLangas adminLangas = new AdminPanelesLangas();
                    adminLangas.Show();

                }
                else { MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis"); }
            }
        }

        private void loginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prisijungSlaptazodis_TextChanged(object sender, EventArgs e)
        {
           

        }

    }
}

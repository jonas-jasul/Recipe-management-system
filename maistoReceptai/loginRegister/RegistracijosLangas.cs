using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maistoReceptai
{
    public partial class RegistracijosLangas : Form
    {
        string salt="560A18CD-6346-4CF0-A2E8-671F9B6B9EA9";

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\JONCE\SOURCE\REPOS\MAISTORECEPTAI\MAISTORECEPTAI\DATABASE1.MDF;Integrated Security=True";
       

        public RegistracijosLangas()
        {
            InitializeComponent();
            
        }

        private void RegistracijosLangas_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerWindowGrizti_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            PrisijungimoLangas login = new PrisijungimoLangas();
            login.ShowDialog();
        }


       
       
    /*    public static string Encrypt(string clearText)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(clearText);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    clearText = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return clearText;
        }*/


        private void registerWindowRegister_Click(object sender, EventArgs e)
        {


            if(rgstrVardas.Text=="" || rgstrSlaptazodis.Text=="" ||rgstrSlaptazodisPak.Text=="" )
            {
                MessageBox.Show("Įveskite visus duomenis!");
            }
            else if(rgstrSlaptazodis.Text!=rgstrSlaptazodisPak.Text)
            {
                MessageBox.Show("Slaptažodžiai nesutampa!");
            } 
            else { 
            using (SqlConnection sqlCnnct = new SqlConnection(connectionString))
            {

                    sqlCnnct.Open();
                    string query2 = "Select * from Vartotojai where vartotojoVardas='" + rgstrVardas.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query2, sqlCnnct);
                    DataTable dtbl2 = new DataTable();
                    sda.Fill(dtbl2);
                    if(dtbl2.Rows.Count>0)
                    {
                        MessageBox.Show("Šis vartotojo vardas yra užimtas!");
                    }

                        else
                        {
                            SqlCommand sqlCmmnd = new SqlCommand("INSERT INTO Vartotojai (vartotojoVardas, slaptazodis) Values (@vartotojoVardas, @slaptazodis) SELECT CAST (SCOPE_IDENTITY() As int)", sqlCnnct);


                            //PasswordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(rgstrSlaptazodis.Text);
                            sqlCmmnd.Parameters.AddWithValue("@vartotojoVardas", rgstrVardas.Text.Trim().ToString());
                            sqlCmmnd.Parameters.AddWithValue("@slaptazodis", rms.EncryptRijndael(rgstrSlaptazodis.Text, salt));
                            sqlCmmnd.ExecuteNonQuery();

                        
                            //int idReg = Convert.ToInt32(sqlCmmnd.ExecuteScalar());
                            MessageBox.Show("Registracija sėkminga");
                            sqlCnnct.Close();
                        }
            }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rgstrSlaptazodis_TextChanged(object sender, EventArgs e)
        {

        }

    }


}

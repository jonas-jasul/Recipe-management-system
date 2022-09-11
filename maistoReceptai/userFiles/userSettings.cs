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

    public partial class userSettings : UserControl
    {

        public int UserID;
        public static bool isNonVeg;
        string salt = "560A18CD-6346-4CF0-A2E8-671F9B6B9EA9";
        private static userSettings _instance;

        public static userSettings Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new userSettings();

                return _instance;

            }
        }
        public userSettings()
        {
            InitializeComponent();
            UserID = PrisijungimoLangas.UserID;
            //MessageBox.Show(UserID.ToString());
           
        }


        private void saveUserSetting_Click(object sender, EventArgs e)
        {
           
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            //String command = "INSERT INTO Vartotojai (vartFirstName, vartLastName, vartEmail, vartDoB, vartPref) Values(@vartFirstName, @vartLastName, @vartEmail, @vartDoB, @vartPref)";
            //int ID = 54;
            //int UserID = Int32.Parse()); 
            String command = "UPDATE Vartotojai SET vartFirstName=@vartFirstName, vartLastName=@vartLastName, vartEmail=@vartEmail, vartotojoVardas=@vartotojoVardas, vartDoB=@vartDoB, vartPref=@vartPref, slaptazodis=@slapt WHERE ID=@ID";
            SqlCommand cmmd = new SqlCommand(command, sqlc);
            cmmd.Parameters.AddWithValue("@ID", UserID);
            cmmd.Parameters.AddWithValue("@vartFirstName", userFirstName.Text);
            cmmd.Parameters.AddWithValue("@vartLastName", userLastName.Text);
            cmmd.Parameters.AddWithValue("@vartEmail", userEmail.Text);
            cmmd.Parameters.AddWithValue("@vartotojoVardas", userNickname.Text);
            cmmd.Parameters.AddWithValue("@vartDoB", userDoB.Value.ToString());

            if (String.IsNullOrEmpty(userPass.Text))
            {
                MessageBox.Show("Įveskite slaptažodį!");
            }
            else
            {


                try
                {
                    if (userNonVeg.Checked)
                    {
                        cmmd.Parameters.AddWithValue("@vartPref", userNonVeg.Text);
                        isNonVeg = true;
                    }
                    else if (userVeg.Checked)
                    {
                        cmmd.Parameters.AddWithValue("@vartPref", userVeg.Text);
                        isNonVeg = false;
                    }

                    if (!(String.IsNullOrEmpty(userPass.Text)))
                    {
                        cmmd.Parameters.AddWithValue("@slapt", rms.EncryptRijndael(userPass.Text, salt));
                    }

                    sqlc.Open();
                    cmmd.ExecuteNonQuery();
                    sqlc.Close();
                }


                catch (SqlException ex)
                {
                    MessageBox.Show("Pasirinkite maisto tipą!");
                }
                MessageBox.Show("Duomenys išsaugoti");

            }
           /* sqlc.Open();
            cmmd.ExecuteNonQuery();
            sqlc.Close();*/

            
        }

        private void userNickname_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void userImportRefre_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            sqlc.Open();
            string query = "Select * From Vartotojai Where ID=@UserID";
            SqlCommand cmd = new SqlCommand(query, sqlc);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            DataSet ds = new DataSet();

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            if(ds.Tables[0].Rows.Count>0)
            {
                userFirstName.Text = ds.Tables[0].Rows[0]["vartFirstName"].ToString();
                userLastName.Text = ds.Tables[0].Rows[0]["vartLastName"].ToString();
                userEmail.Text= ds.Tables[0].Rows[0]["vartEmail"].ToString();
                userNickname.Text= ds.Tables[0].Rows[0]["vartotojoVardas"].ToString();
                //userPass.Text= ds.Tables[0].Rows[0]["slaptazodis"].ToString();
                try
                {
                    userDoB.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["vartDoB"]);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Pakeiskite datą");
                }
            }
            sqlc.Close();
        }

        private void userSettings_Load(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonce\source\repos\maistoReceptai\maistoReceptai\Database1.mdf;Integrated Security=True");
            sqlc.Open();
            string query = "Select * From Vartotojai Where ID=@UserID";
            SqlCommand cmd = new SqlCommand(query, sqlc);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            DataSet ds = new DataSet();

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                userFirstName.Text = ds.Tables[0].Rows[0]["vartFirstName"].ToString();
                userLastName.Text = ds.Tables[0].Rows[0]["vartLastName"].ToString();
                userEmail.Text = ds.Tables[0].Rows[0]["vartEmail"].ToString();
                userNickname.Text = ds.Tables[0].Rows[0]["vartotojoVardas"].ToString();
                //userPass.Text= ds.Tables[0].Rows[0]["slaptazodis"].ToString();
                if(ds.Tables[0].Rows[0]["vartPref"].ToString().Equals("Nevegetariškas"))
                {
                    userNonVeg.Checked = true;
                }

                else
                {
                    userVeg.Checked = true;
                }
                
            }
            sqlc.Close();
        }

        private void userFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void userLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}

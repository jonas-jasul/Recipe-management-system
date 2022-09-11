using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maistoReceptai
{
    public partial class PagrPrograma : Form
    {
        int thisInt;
        public PagrPrograma()
        {
            InitializeComponent();
            this.Text = "Maisto receptų programa (Vartotojas)";
            thisInt = PrisijungimoLangas.UserID;
            //MessageBox.Show(thisInt.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void ziuretiReceptusBtn_Click(object sender, EventArgs e)
        {

            if(!pagrPanel.Controls.Contains(ziuretiReceptus.Instance))
            {
                pagrPanel.Controls.Add(ziuretiReceptus.Instance);
                ziuretiReceptus.Instance.Dock = DockStyle.Fill;
                ziuretiReceptus.Instance.BringToFront();
            }
            else
            {
                ziuretiReceptus.Instance.BringToFront();
            }

            /*ziuretiReceptus zr = new ziuretiReceptus();
            zr.BringToFront();
            zr.Dock = DockStyle.Fill;
            this.Controls.Add(zr);*/
            
        }

        private void PagrPrograma_Load(object sender, EventArgs e)
        {
           
            
        }

        private void ziuretiReceptus1_Load(object sender, EventArgs e)
        {

        }

        private void pagrPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutUs_Click(object sender, EventArgs e)
        {
            if (!pagrPanel.Controls.Contains(aboutUsPage.Instance))
            {
                pagrPanel.Controls.Add(aboutUsPage.Instance);
                aboutUsPage.Instance.Dock = DockStyle.Fill;
                aboutUsPage.Instance.BringToFront();
            }
            else
            {
                aboutUsPage.Instance.BringToFront();
            }

            aboutUsPage.Instance.BringToFront();

        }

        private void vartotojoNustatymai_Click(object sender, EventArgs e)
        {
           
            
            if (!pagrPanel.Controls.Contains(userSettings.Instance))
            {
                pagrPanel.Controls.Add(userSettings.Instance);
                userSettings.Instance.Dock = DockStyle.Fill;
                userSettings.Instance.BringToFront();
            }

            else
            {
                userSettings.Instance.BringToFront();
            }
        }
        public static void openLoginForm()
        {
            Application.Run(new PrisijungimoLangas());
        }
        private void userLogOut_Click(object sender, EventArgs e)
        {

            /* PagrPrograma pgr = new PagrPrograma();
             System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(openLoginForm));
             this.Close();
             t.Start();*/
            Application.Restart();
            PrisijungimoLangas pris = new PrisijungimoLangas();
            pris.Show();
        }
    }
}

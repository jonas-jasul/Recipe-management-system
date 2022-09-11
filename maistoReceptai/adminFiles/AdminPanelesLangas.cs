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
    public partial class AdminPanelesLangas : Form
    {
        public AdminPanelesLangas()
        {
            InitializeComponent();
            this.Text = "Maisto receptų programa (Administratorius)";
        }

        private void pridetiReceptaBtn_Click(object sender, EventArgs e)
        {
            if (!adminPridetRecPanel.Controls.Contains(adminPridetiRec.Instance))
            {
                adminPridetRecPanel.Controls.Add(adminPridetiRec.Instance);
                adminPridetiRec.Instance.Dock = DockStyle.Fill;
                adminPridetiRec.Instance.BringToFront();
            }
            else
            {
                adminPridetiRec.Instance.BringToFront();
            }


        }

        private void prideti_Ingred_Click(object sender, EventArgs e)
        {
            if (!adminPridetRecPanel.Controls.Contains(adminPridetiIngredientus.Instance))
            {
                adminPridetRecPanel.Controls.Add(adminPridetiIngredientus.Instance);
                adminPridetiIngredientus.Instance.Dock = DockStyle.Fill;
                adminPridetiIngredientus.Instance.BringToFront();
            }
            else
            {
                adminPridetiIngredientus.Instance.BringToFront();
            }
        }

        private void ziuretiReceptusAdmin_Click(object sender, EventArgs e)
        {
            if (!adminPridetRecPanel.Controls.Contains(ziuretiReceptAdmin.Instance))
            {
                adminPridetRecPanel.Controls.Add(ziuretiReceptAdmin.Instance);
                ziuretiReceptAdmin.Instance.Dock = DockStyle.Fill;
                ziuretiReceptAdmin.Instance.BringToFront();
            }
            else
            {
                ziuretiReceptAdmin.Instance.BringToFront();
            }

        }

        private void adminTvarkVartBtn_Click(object sender, EventArgs e)
        {
            if (!adminPridetRecPanel.Controls.Contains(adminValdytiVartot.Instance))
            {
                adminPridetRecPanel.Controls.Add(adminValdytiVartot.Instance);
                adminValdytiVartot.Instance.Dock = DockStyle.Fill;
                adminValdytiVartot.Instance.BringToFront();
            }
            else
            {
                adminValdytiVartot.Instance.BringToFront();
            }
        }

        private void adminPridetRecPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
            PrisijungimoLangas prisLang = new PrisijungimoLangas();
            prisLang.Show();
        }
    }
}

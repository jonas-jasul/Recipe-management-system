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
    public partial class receptDescForm : Form
    {
        public receptDescForm(string data)
        {
            InitializeComponent();
            viewReceptDesc.Text = data;
            this.Text = "Recepto aprašas";
            viewReceptDesc.SelectionStart = 0;
            
            
        }

        private void receptDescForm_Load(object sender, EventArgs e)
        {

        }

        private void receptDescTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewReceptDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

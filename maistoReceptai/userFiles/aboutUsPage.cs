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
    public partial class aboutUsPage : UserControl
    {

        private static aboutUsPage _instance;

        public static aboutUsPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new aboutUsPage();
                return _instance;
            }
        }
        public aboutUsPage()
        {
            InitializeComponent();
        }
    }
}

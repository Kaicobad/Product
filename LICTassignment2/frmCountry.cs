using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LICTassignment2
{
    public partial class frmCountry : Form
    {
        public frmCountry()
        {
            InitializeComponent();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            frmNewCountry nCountry = new frmNewCountry();
            nCountry.Show();
        }
    }
}

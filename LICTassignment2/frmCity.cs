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
    public partial class frmCity : Form
    {
        public frmCity()
        {
            InitializeComponent();
        }

        private void btnNewCity_Click(object sender, EventArgs e)
        {
            frmNewCity nCity = new frmNewCity();
            nCity.Show();
        }
    }
}

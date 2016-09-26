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
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();

            if (product.IsDisposed)

                product = new frmProduct();

            product.Show();
            product.BringToFront();
            product.MdiParent = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWatch.Text = "Date and Time \t: " + DateTime.Now.ToString();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();

            if (customer.IsDisposed)
                customer = new frmCustomer();

            customer.Show();
            customer.BringToFront();
            customer.MdiParent = this;
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee employee = new frmEmployee();

            if (employee.IsDisposed)
                employee = new frmEmployee();

            employee.Show();
            employee.BringToFront();
            employee.MdiParent = this;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGender gender = new frmGender();

            if (gender.IsDisposed)
                gender = new frmGender();

            gender.Show();
            gender.BringToFront();
            gender.MdiParent = this;
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCity city = new frmCity();

            if (city.IsDisposed)
                city = new frmCity();

            city.Show();
            city.BringToFront();
            city.MdiParent = this;
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCountry country = new frmCountry();

            if (country.IsDisposed)
                country = new frmCountry();

            country.Show();
            country.BringToFront();
            country.MdiParent = this;
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrandList brandlist = new frmBrandList();

            if (brandlist.IsDisposed)
                brandlist = new frmBrandList();

            brandlist.Show();
            brandlist.BringToFront();
            brandlist.MdiParent = this;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColorList colorlist = new frmColorList();

            if (colorlist.IsDisposed)
                colorlist = new frmColorList();

            colorlist.Show();
            colorlist.BringToFront();
            colorlist.MdiParent = this;
        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatagoryList catagorylist = new frmCatagoryList();

            if (catagorylist.IsDisposed)
                catagorylist = new frmCatagoryList();

            catagorylist.Show();
            catagorylist.BringToFront();
            catagorylist.MdiParent = this;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSizeList sizelist = new frmSizeList();

            if (sizelist.IsDisposed)
                sizelist = new frmSizeList();

            sizelist.Show();
            sizelist.BringToFront();
            sizelist.MdiParent = this;
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnitList unitlist = new frmUnitList();

            if (unitlist.IsDisposed)
                unitlist = new frmUnitList();

            unitlist.Show();
            unitlist.BringToFront();
            unitlist.MdiParent = this;
        }

        private void warrantyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWarrantyList warrantylist = new frmWarrantyList();

            if (warrantylist.IsDisposed)
                warrantylist = new frmWarrantyList();

            warrantylist.Show();
            warrantylist.BringToFront();
            warrantylist.MdiParent = this;
        }
    }
}

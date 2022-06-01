using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppKargo
{
    public partial class Dashboard : Form
    {
        CargoDbContext db = new();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var countries = db.Countries;
            var packages = db.Packages;
            foreach (var package in packages.ToList())
            {
                CmbPackages.Items.Add(package.Name);
            }

            foreach (var country in countries.ToList())
            {
                CmbCountry.Items.Add(country.Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var counrtyName = CmbCountry.Text;
            var packageName = CmbPackages.Text;
            decimal weight = numericUpDown.Value;

            if (weight <= 0)
            {
                MessageBox.Show("zehmet olmasa ceki daxil edin");
            }
            else
            {
                try
                {

                    var country = db.Countries.FirstOrDefault(c => c.Name == counrtyName);
                    var package = db.Packages.FirstOrDefault(c => c.Name == packageName);
                    decimal result = Convert.ToDecimal((country.Price + package.Price)) * weight;
                    lblprice.Text = result.ToString() + "₼";
                }
                catch (Exception)
                {
                     MessageBox.Show("butun xanalari doldurun");
                }
            }
          }

        private void CmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
    }
}

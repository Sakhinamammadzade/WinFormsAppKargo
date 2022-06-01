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
    public partial class AdminPanel : Form
    {
        CargoDbContext db = new();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void CmbPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var packageName = CmbPackages.Text;
            nmrPackages.Enabled = true; 

            var package=db.Packages.FirstOrDefault(p => p.Name == packageName);
            nmrPackages.Value = Convert.ToDecimal(package.Price);
        }

        private void CmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var countryName = CmbCountry.Text;
            nmrCountry.Enabled = true;

            var country =db.Countries.FirstOrDefault(x=>x.Name == countryName);//sqlden countryden  her setrin name price id getirir
            nmrCountry.Value = Convert.ToDecimal(country.Price);
        }

      

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            var countries = db.Countries.ToList();
            var packages=db.Packages.ToList();

            foreach (var country in countries)
            {
                CmbCountry.Items.Add(country.Name);
            }

            foreach (var package in packages)
            {
                CmbPackages.Items.Add(package.Name);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var countryName = CmbCountry.Text;
                var country = db.Countries.FirstOrDefault(x => x.Name == countryName);
                country.Price= Convert.ToDouble(nmrCountry.Value);
                db.SaveChanges();
                MessageBox.Show("melumat deyishdirildi");
                nmrCountry.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("melumat deyishdirerken bir xet bash verdi");
            }

        }

        private void btnqiymet2_Click(object sender, EventArgs e)
        {
            try
            {
                var packageName=CmbPackages.Text;
                var package=db.Packages.FirstOrDefault(x => x.Name == packageName);
                package.Price = Convert.ToDouble(nmrPackages.Value);
                db.SaveChanges();
                MessageBox.Show("melumat ugurla deyishdirildi");
                nmrPackages.Enabled = false;




            }
            catch (Exception)
            {

                MessageBox.Show("Melumat deyishdirilerken xeta bash verdi");
            }
        }
    }
}

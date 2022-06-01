using DataAccess;

namespace WinFormsAppKargo
{
    public partial class Form1 : Form
    {
        CargoDbContext db = new CargoDbContext();


        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnlogin_Click(object sender, EventArgs e)


        {
            var user = db.Users.FirstOrDefault(x => x.Email == txtEmail.Text);
            if (user == null)
            {
                MessageBox.Show("bele bir istifadeci tapilmadi");
            }

            else
            {
                if (user.Password== txtPassword.Text && user.Email== txtPassword.Text)
                {


                    if (user.IsAdmin == true)
                    {
                        AdminPanel adminpanel = new AdminPanel();
                        adminpanel.Show();
                    }
                    else
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }
                 

                }

                else
                {
                    MessageBox.Show("Email ve ya sifre sehvdi");

                }
              }
          }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
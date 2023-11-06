using DevExpress.DentalClinic.View;
using DevExpress.DentalClinic.Views.Settings;

namespace FeedingManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            InitializeComponent();

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class ShowDashboard : Form
    {
        public ShowDashboard()
        {
            InitializeComponent();
        }

        private void ShowDashboard_Load(object sender, EventArgs e)
        {
            Display display = new Display();
            lblDoctorsCount.Text = display.DoctorsCount().ToString();
            lblPatientsCount.Text = display.PatientsCount().ToString();
            lblAppointmentsCount.Text = display.AppointmentsCount().ToString();
            lblEarnings.Text = display.Earnings().ToString() + "$";
        }
        private int imageNumber = 1;
        private void LoadNextIamge()
        {
            if (imageNumber == 5)
                imageNumber = 1;
            pictureBox1.ImageLocation = String.Format(@"Images\{0}.png", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextIamge();
        }
    }
}

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
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
            circularProgressBarLoading.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBarLoading.Value += 5;
            circularProgressBarLoading.Text = circularProgressBarLoading.Value.ToString() + "%";

            if (circularProgressBarLoading.Value == 100)
            {
                timer1.Enabled = false;
                FormLogIn formLogIn = new FormLogIn();
                formLogIn.Show();
                this.Hide();
            }
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

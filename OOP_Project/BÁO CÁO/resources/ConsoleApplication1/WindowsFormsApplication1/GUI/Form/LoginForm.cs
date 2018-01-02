using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        BUS_User bus_user = new BUS_User();

        public LoginForm()
        {
            Thread t = new Thread(new ThreadStart(showWelcomeForm));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
          
        }

        private void showWelcomeForm()
        {
            Application.Run(new WelcomeForm());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            User user = new User(bunifuMaterialTextbox1.Text,bunifuMaterialTextbox2.Text);
            if (bus_user.checkUser(user))
            {
                HomeForm homeform = new HomeForm();
                this.Hide();
                homeform.Show();
            }
            
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuCards1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuCards2.BringToFront(); 
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

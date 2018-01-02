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

namespace WindowsFormsApplication1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

     

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void myTopics1_Load(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

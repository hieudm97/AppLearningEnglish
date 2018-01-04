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
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        private BUS_Nguoidung bus_nguoidung = new BUS_Nguoidung();

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
            String username = bunifuMaterialTextbox1.Text;
            String password = bunifuMaterialTextbox2.Text;
            Nguoidung nguoidung = new Nguoidung(username, password);
            if (bus_nguoidung.checkNguoidung(nguoidung))
            {
                HomeForm homeform = new HomeForm(nguoidung);
                this.Hide();
                homeform.Show();
            }
            else
                MessageBox.Show("Please input again!!!!");
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
            String username = bunifuMaterialTextbox3.Text;
            String password = bunifuMaterialTextbox4.Text;
            String cellnumber = bunifuMaterialTextbox5.Text;
            int experience = 1;
            Nguoidung nguoidung = new Nguoidung(username, password, cellnumber, experience);
            if (bus_nguoidung.addUser(nguoidung))
                MessageBox.Show("SUCESSFULLY!!!");
            else
                MessageBox.Show("Please insert again!!!");

        }

        private void bunifuMaterialTextbox6_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1
{
    public partial class Exercise : UserControl
    {
        private Baitap tmp;

        public Exercise()
        {
            InitializeComponent();
        }

        public Exercise(Baitap tmp)
        {
            InitializeComponent();
            this.tmp = tmp;
            khoitao();
        }

        private void khoitao()
        {
            bunifuCustomLabel1.Text = tmp.NAME;
            bunifuCustomLabel2.Text = tmp.DESCRIPTION;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}

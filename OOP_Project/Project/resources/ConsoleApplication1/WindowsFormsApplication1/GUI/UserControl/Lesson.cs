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
    public partial class Lesson : UserControl
    {
        private Baihoc baihoc;

        public Lesson()
        {
            InitializeComponent();
        }

        public Lesson(Baihoc tmp)
        {
            InitializeComponent();
            this.baihoc = tmp;
            khoitao();
        }

        private void khoitao()
        {
            this.bunifuCustomLabel1.Text = baihoc.NAME;
            this.bunifuCustomLabel2.Text = baihoc.DESCRIPTION;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartLessonForm startLessonForm = new StartLessonForm(baihoc);
            startLessonForm.ShowDialog();
        }
    }
}

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
    public partial class StartLesson : UserControl
    {
        private Noidung noidung;

        public StartLesson()
        {
            InitializeComponent();
        }

        public StartLesson(Noidung noidung)
        {
            InitializeComponent();
            this.noidung = noidung;
            khoitao();
        }

        private void khoitao()
        {
            pictureBox1.Image = new Bitmap(noidung.PATH_HINH);
            label1.Text = noidung.TUVUNG;
        }

    }
}

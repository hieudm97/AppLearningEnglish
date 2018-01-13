using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using WindowsFormsApplication1.DATABASE;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class StartExerciseForm : Form
    {
        private Baitap tmp;
        List<Cauhoi> lst_cauhoi = new List<Cauhoi>();
        private BUS.BUS_Cauhoi bus_cauhoi = new BUS.BUS_Cauhoi();
        private int i = 0;
        private BUS.BUS_Nguoidung bus_nguoidung = new BUS.BUS_Nguoidung();
        private int somang = 3;

        public int Somang
        {
            get
            {
                return somang;
            }

            set
            {
                somang = value;
            }
        }

        public StartExerciseForm()
        {
            InitializeComponent();
        }

        public StartExerciseForm(Baitap tmp)
        {
            InitializeComponent();
            this.tmp = tmp;
            lst_cauhoi = bus_cauhoi.getCauHoi(tmp.ID);
        }

        private void StartExerciseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void StartExerciseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(i >= 5)
                {
                    hoanThanhBaiTap();
                }
                else
                {
                    chuyenCauHoiKeTiep();
                }

            }
        }

        private void chuyenCauHoiKeTiep()
        {

            StartExercise startexercise = new StartExercise(lst_cauhoi[i], this, Somang);
            panel1.Controls.Add(startexercise);
            if (panel1.Contains(startexercise))
            {
                startexercise.BringToFront();
            }
            i++;
        }

        private void hoanThanhBaiTap()
        {
            MessageBox.Show("Congratulation!!! You receive " + tmp.EXPERIENCE.ToString() + " from this exercise.");
            Nguoidung nguoidung = Session.nguoidung;
            bus_nguoidung.upDateMyExp(nguoidung, tmp.EXPERIENCE);
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        internal TableLayoutPanel getTimeLable()
        {
            return this.tableLayoutPanel1;
        }

        private void StartExerciseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using Bunifu.Framework.UI;

namespace WindowsFormsApplication1
{
    public partial class StartExercise : UserControl
    {
        private BUS.BUS_Cautraloi bus_cautraloi = new BUS.BUS_Cautraloi();
        private Cauhoi cauhoi;
        private List<Cautraloi> cautralois = new List<Cautraloi>();
        private Cautraloi correct_ans = new Cautraloi();
        private StartExerciseForm startExerciseForm;
        private int somang;

        public StartExercise()
        {
            InitializeComponent();
        }

        public StartExercise(Cauhoi cauhoi)
        {
            InitializeComponent();
            this.cauhoi = cauhoi;
            cautralois = bus_cautraloi.getCauTraLoi(cauhoi.ID);
            correct_ans = bus_cautraloi.getCauTraLoiDung(cauhoi.CORRECT_ANS_ID);
            khoitao();
        }

        public StartExercise(Cauhoi cauhoi, StartExerciseForm startExerciseForm) : this(cauhoi)
        {
            this.startExerciseForm = startExerciseForm;
        }

        public StartExercise(Cauhoi cauhoi, StartExerciseForm startExerciseForm, int somang) : this(cauhoi, startExerciseForm)
        {
            this.somang = somang;
        }

        private void khoitao()
        {
            khoiTaoCauHoi();
            khoiTaoCauTraLoi();
        }

        private void khoiTaoCauTraLoi()
        {
            radioButton1.Text = cautralois[0].NOIDUNG;
            radioButton2.Text = cautralois[1].NOIDUNG;
            radioButton3.Text = cautralois[2].NOIDUNG;
            radioButton4.Text = cautralois[3].NOIDUNG;

        }

        private void khoiTaoCauHoi()
        {
            bunifuCustomLabel2.Text = cauhoi.NOIDUNG;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton1.Text.Equals(correct_ans.NOIDUNG))
                    MessageBox.Show("Correct!!!");
                else
                {
                    xuLyKhiChonSaiCauHoi();
                }
            }
            if (radioButton2.Checked)
            {
                if (radioButton2.Text.Equals(correct_ans.NOIDUNG))
                    MessageBox.Show("Correct!!!");
                else
                {
                    xuLyKhiChonSaiCauHoi();
                }
            }
            if (radioButton3.Checked)
            {
                if (radioButton3.Text.Equals(correct_ans.NOIDUNG))
                    MessageBox.Show("Correct!!!");
                else
                {
                    xuLyKhiChonSaiCauHoi();
                }
            }
            if (radioButton4.Checked)
            {
                if (radioButton4.Text.Equals(correct_ans.NOIDUNG))
                    MessageBox.Show("Correct!!!");
                else
                {
                    xuLyKhiChonSaiCauHoi();
                }
            }
        }

        private void xuLyKhiChonSaiCauHoi()
        {
            try
            {
                if (startExerciseForm.Somang == 0)
                {
                    MessageBox.Show("You loose!!!");
                    startExerciseForm.Close();
                }
                else
                {
                    
                    TableLayoutPanel tablelayout = startExerciseForm.getTimeLable();
                    PictureBox pic = (PictureBox)tablelayout.GetControlFromPosition(startExerciseForm.Somang - 1, 0);
                    startExerciseForm.Somang -= 1;
                    pic.Visible = false;
                    if (startExerciseForm.Somang == 0)
                    {
                        MessageBox.Show("You loose!!!");
                        startExerciseForm.Close();
                    }

                }
            }
            catch(Exception e)
            {
                MessageBox.Show("You fail");
                startExerciseForm.Close();
            }
           
               
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DATABASE;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class StartLessonForm : Form
    {
        private Baihoc baihoc;
        private BUS.BUS_Noidung bus_noidung = new BUS.BUS_Noidung();
        List<Noidung> lst_Noidung = new List<Noidung>();
        List<Label> lst_labels = new List<Label>();
        
        private int i = 0;
        private BUS.BUS_Nguoidung bus_nguoidung = new BUS.BUS_Nguoidung();

        public StartLessonForm()
        {

        }

        public StartLessonForm(Baihoc baihoc)
        {
            InitializeComponent();
            this.baihoc = baihoc;
            lst_Noidung = bus_noidung.getNoidung(baihoc.ID);
            lst_labels = khoitaolistlabel();

        }

        private List<Label> khoitaolistlabel()
        {
            List<Label> lst_lbls = new List<Label>();
            lst_labels.Add(label1);
            lst_labels.Add(label2);
            lst_labels.Add(label3);
            lst_labels.Add(label4);
            lst_labels.Add(label5);
            return lst_labels;
        }

        private void StartLessonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void StartLessonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (i >= 5)
                {
                    MessageBox.Show("Congratulation!!! You receive " + baihoc.EXPERIENCE.ToString() + " from this lesson.");
                    Nguoidung nguoidung = Session.nguoidung;
                    bus_nguoidung.upDateMyExp(nguoidung, baihoc.EXPERIENCE);
                    this.Close();                    
                }
                else
                {
                    StartLesson startlesson = new StartLesson(lst_Noidung[i]);
                    panel1.Controls.Add(startlesson);
                    if (panel1.Contains(startlesson))
                    {
                        startlesson.BringToFront();
                    }
                    lst_labels[i].BackColor = Color.Chartreuse;
                    i++;
                }
                  
            }
        }
    }
}

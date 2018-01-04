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

namespace WindowsFormsApplication1
{
    public partial class StartLessonForm : Form
    {
        private Baihoc baihoc;
        private BUS.BUS_Noidung bus_noidung = new BUS.BUS_Noidung();
        List<Noidung> lst_Noidung = new List<Noidung>();
        private int i = 0;

        public StartLessonForm()
        {

        }

        public StartLessonForm(Baihoc baihoc)
        {
            InitializeComponent();
            this.baihoc = baihoc;
            lst_Noidung = bus_noidung.getNoidung(baihoc.ID);


        }

        private void StartLessonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StartLessonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (i == 10)
                {
                    MessageBox.Show("You have already finished this topic!!!");
                    this.Close();
                }
                else
                {
                    StartLesson startlesson = new StartLesson(lst_Noidung[i]);
                    panel1.Controls.Add(startlesson);
                    i++;
                }
                
            }
        }
    }
}

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
    public partial class StartExerciseForm : Form
    {
        private Baitap tmp;
        List<Cauhoi> lst_cauhoi = new List<Cauhoi>();
        private BUS.BUS_Cauhoi bus_cauhoi = new BUS.BUS_Cauhoi();
        private int i = 0;

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
                    MessageBox.Show("You finish the test!!! Congratulation <3 ");
                    this.Close();
                }
                else
                {
                    StartExercise startexercise = new StartExercise(lst_cauhoi[i]);
                    panel1.Controls.Add(startexercise);
                    if (panel1.Contains(startexercise))
                    {
                        startexercise.BringToFront();
                    }
                    i++;
                }
               
            }
        }
    }
}

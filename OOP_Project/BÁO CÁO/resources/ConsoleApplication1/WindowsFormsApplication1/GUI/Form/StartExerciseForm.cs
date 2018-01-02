using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class StartExerciseForm : Form
    {
        public StartExerciseForm()
        {
            InitializeComponent();
        }

        private void StartExerciseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

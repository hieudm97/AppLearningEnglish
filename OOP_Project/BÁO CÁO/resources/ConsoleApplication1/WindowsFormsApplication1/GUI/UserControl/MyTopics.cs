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
    public partial class MyTopics : UserControl
    {
        private Topic tmp;

        public MyTopics()
        {
            InitializeComponent();
        }

        public MyTopics(Topic tmp)
        {
            this.tmp = tmp;
        }

        private void MyTopics_DoubleClick(object sender, EventArgs e)
        {
           
        }
    }
}

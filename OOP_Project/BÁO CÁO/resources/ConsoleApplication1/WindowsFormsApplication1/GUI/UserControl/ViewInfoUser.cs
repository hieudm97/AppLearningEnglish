using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ViewInfoUser : UserControl
    {
        public ViewInfoUser()
        {
            InitializeComponent();
        }

        internal void setYourCircleProgressBar(int sotopicdahoc)
        {
            bunifuCircleProgressbar1.MaxValue = 100;
            int value = 100 / sotopicdahoc;
            bunifuCircleProgressbar1.Value = value;
        }
    }
}

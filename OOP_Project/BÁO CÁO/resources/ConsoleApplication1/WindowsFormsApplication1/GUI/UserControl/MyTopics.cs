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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class MyTopics : UserControl
    {
        private Topic topic;

        public MyTopics()
        {
            InitializeComponent();
        }

        private void khoitao()
        {
          //  pictureBox1.Image = covertByteToImage(topic.HINH);
            bunifuCustomLabel1.Text = topic.NAME;
            bunifuCustomLabel3.Text = topic.REWARD.ToString();
        }

        private Image covertByteToImage(byte[] hINH)
        {
            MemoryStream ms = new MemoryStream(hINH);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public MyTopics(Topic tmp)
        {
            InitializeComponent();
            this.topic = tmp;
            khoitao();
          
        }

        private void MyTopics_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            HienThiTopic();
        }

        private void HienThiTopic()
        {
            InsideTopicForm insidetopicform = new InsideTopicForm(topic);
            insidetopicform.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HienThiTopic();
        }
    }
}

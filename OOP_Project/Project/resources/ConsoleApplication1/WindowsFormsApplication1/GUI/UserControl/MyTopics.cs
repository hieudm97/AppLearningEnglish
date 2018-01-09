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
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class MyTopics : UserControl
    {
        private Topic topic;
        private BUS.BUS_Tmp bus_tmp = new BUS.BUS_Tmp();

        public MyTopics()
        {
            InitializeComponent();
        }

        private void khoitao()
        {

            pictureBox1.Image = new Bitmap(topic.PATH_IMAGE);
            bunifuCustomLabel1.Text = topic.NAME;
            bunifuCustomLabel3.Text = "REWARD: " + topic.REWARD.ToString() + " exp.";
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
            XuLyHienThiTopiC();
        }

        private void XuLyHienThiTopiC()
        {
            Nguoidung nguoidung = Session.nguoidung;
            xuLyGiuHoacTangSoTopic(nguoidung, topic);
            HienThiTopic();
        }

        private void xuLyGiuHoacTangSoTopic(Nguoidung nguoidung, Topic topic)
        {
            bus_tmp.xuLyGiuHoacTangSoTopic(nguoidung, topic);
            
        }

        private void HienThiTopic()
        {
            InsideTopicForm insidetopicform = new InsideTopicForm(topic);
            insidetopicform.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            XuLyHienThiTopiC();
        }

       
    }
}

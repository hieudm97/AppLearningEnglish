using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1
{
    public partial class HomeForm : Form
    {
        private Nguoidung nguoidung;
        private BUS.BUS_Nguoidung bus_nguoidung = new BUS.BUS_Nguoidung();
        private BUS.BUS_Tmp bus_tmp = new BUS.BUS_Tmp();
        private BUS.BUS_Topic bus_topic = new BUS.BUS_Topic();

        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(Nguoidung nguoidung)
        {
            this.nguoidung = nguoidung;
            khoitao();
        }

        private void khoitao()
        {
            Nguoidung nguoidung = bus_nguoidung.getNguoidung(this.nguoidung.USERNAME);
            khoiTaoThongTinNguoiDung(nguoidung);
            loadTopic();
        }

        private void loadTopic()
        {
            List<Topic> topics = bus_topic.getTopics();
            List<UserControl> lst_usercontrol = ganTopicsToUc(topics);
            ganUcVaoTableLayout(lst_usercontrol);
        }

        private void ganUcVaoTableLayout(List<UserControl> lst_usercontrol)
        {
            foreach(UserControl tmp in lst_usercontrol)
            {
                tableLayoutPanel1.Controls.Add(tmp);
            }
        }

        private List<UserControl> ganTopicsToUc(List<Topic> topics)
        {
            List<Topic> lst_topics = bus_topic.getTopics();
            List<UserControl> lstUC_Topic = new List<UserControl>();
            foreach(Topic tmp in lst_topics)
            {
                MyTopics uc_myTopic = new MyTopics(tmp);
                lstUC_Topic.Add(uc_myTopic);
            }
            return lstUC_Topic;
        }

        private void khoiTaoThongTinNguoiDung(Nguoidung nguoidung)
        {
            pictureBox1.Image = convertImageToByte(nguoidung.IMAGE);
            bunifuCustomLabel1.Text = nguoidung.USERNAME;
            int sotopicdahoc = bus_tmp.getSoTopicDaHoc(nguoidung.ID);
            xulycircleprogress(sotopicdahoc);
        }

        private void xulycircleprogress(int sotopicdahoc)
        {
            viewInfoUser1.setYourCircleProgressBar(sotopicdahoc);
        }

        private Image convertImageToByte(byte[] iMAGE)
        {
            MemoryStream ms = new MemoryStream(iMAGE);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

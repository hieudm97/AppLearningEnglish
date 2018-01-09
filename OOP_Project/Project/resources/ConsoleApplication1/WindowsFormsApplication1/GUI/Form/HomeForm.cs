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
using WindowsFormsApplication1.DTO;
using WindowsFormsApplication1.Properties;

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
            InitializeComponent();
            this.nguoidung = nguoidung;
            Session.nguoidung = nguoidung;
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
            List<MyTopics> lst_usercontrol = ganTopicsToUc(topics);
            ganUcVaoTableLayout(lst_usercontrol);
        }

        private void ganUcVaoTableLayout(List<MyTopics> lst_usercontrol)
        {
            foreach(MyTopics tmp in lst_usercontrol)
            {
                tableLayoutPanel1.Controls.Add(tmp);
            }
        }

        private List<MyTopics> ganTopicsToUc(List<Topic> topics)
        {
            List<Topic> lst_topics = bus_topic.getTopics();
            List<MyTopics> lstUC_Topic = new List<MyTopics>();
            foreach(Topic tmp in lst_topics)
            {
                MyTopics uc_myTopic = new MyTopics(tmp);
                lstUC_Topic.Add(uc_myTopic);
            }
            return lstUC_Topic;
        }

        private void khoiTaoThongTinNguoiDung(Nguoidung nguoidung)
        {
            loadHinhNguoiDung(nguoidung);
            bunifuCustomLabel1.Text = nguoidung.USERNAME;
            bunifuCustomLabel2.Text = "Your exp: " + nguoidung.EXPERIENCE.ToString();
            int sotopicdahoc = bus_tmp.getSoTopicDaHoc(nguoidung.ID);
            xulytopicdahoc(sotopicdahoc);
            xulycircleprogress(sotopicdahoc);
        }

        private void loadHinhNguoiDung(Nguoidung nguoidung)
        {
               pictureBox1.Image = new Bitmap(nguoidung.PATH_IMAGE.ToString());
        }

        private void xulytopicdahoc(int sotopicdahoc)
        {
            viewInfoUser1.setYourTopiclearned(sotopicdahoc);
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

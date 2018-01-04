using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1
{
    public partial class InsideTopicForm : Form
    {
        private Topic topic;
        private BUS.BUS_Baihoc bus_baihoc = new BUS.BUS_Baihoc();
        private BUS.BUS_Baitap bus_baitap = new BUS.BUS_Baitap();

        public InsideTopicForm()
        {
            InitializeComponent();
        }

        public InsideTopicForm(Topic topic)
        {
            InitializeComponent();
            this.topic = topic;
            khoitao();
        }

        private void khoitao()
        {
           // pictureBox1.Image = ConvertByteToImage(topic.HINH);
            bunifuCustomLabel1.Text = topic.NAME;
            List<Baihoc> lst_baihoc = bus_baihoc.getBaiHoc(topic.ID);
            List<Baitap> lst_baitap = bus_baitap.getBaiTap(topic.ID);
            List<Lesson> lst_UCLesson = ganBaiHocVaoUC(lst_baihoc);
            List<Exercise> lst_UCExercise = ganBaiTapVaoUC(lst_baitap);
            ganUcVaoFlowLayout(lst_UCLesson, lst_UCExercise);

        }

        private List<Exercise> ganBaiTapVaoUC(List<Baitap> lst_baitap)
        {
            List<Exercise> lst_UCExercise = new List<Exercise>();
            foreach (Baitap tmp in lst_baitap)
            {
                Exercise lesson = new Exercise(tmp);
                lst_UCExercise.Add(lesson);
            }
            return lst_UCExercise;
        }

        private void ganUcVaoFlowLayout(List<Lesson> lst_UCLesson, List<Exercise> lst_UCExercise)
        {
            ganUCLessonVaoFlowLayout(lst_UCLesson);
            ganUCExerciseVaoFlowLayout(lst_UCExercise);
        }

        private void ganUCExerciseVaoFlowLayout(List<Exercise> lst_UCExercise)
        {
            foreach (Exercise tmp in lst_UCExercise)
            {
                flowLayoutPanel1.Controls.Add(tmp);
            }
        }

        private void ganUCLessonVaoFlowLayout(List<Lesson> lst_UCLesson)
        {
            foreach (Lesson tmp in lst_UCLesson)
            {
                flowLayoutPanel1.Controls.Add(tmp);
            }
        }

       

        private List<Lesson> ganBaiHocVaoUC(List<Baihoc> lst_baihoc)
        {
            List<Lesson> lst_UCLesson = new List<Lesson>();
            foreach (Baihoc tmp in lst_baihoc)
            {
                Lesson lesson = new Lesson(tmp);
                lst_UCLesson.Add(lesson);
            }
            return lst_UCLesson;
        }

        private Image ConvertByteToImage(byte[] hINH)
        {
            MemoryStream ms = new MemoryStream(hINH);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void InsideTopicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

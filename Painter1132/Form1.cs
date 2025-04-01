using System.Drawing.Imaging;

namespace Painter1132
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }



        Pen p = new Pen(Color.Black, 3);

        bool wipe = false;
        int x, y; //�p�e�ƹ���m
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (wipe)
                {
                    Graphics g = Graphics.FromImage(pictureBox1.Image);
                    p.Color = pictureBox1.BackColor;
                    p.Width = 10;
                    g.DrawLine(p, x, y, e.X, e.Y);
                    x = e.X;
                    y = e.Y;
                    pictureBox1.Refresh();
                }
                else
                {
                    Graphics g = Graphics.FromImage(pictureBox1.Image);
                    p.Color = Color.Black;
                    p.Width = 3;
                    g.DrawLine(p, x, y, e.X, e.Y);
                    x = e.X;
                    y = e.Y;
                    pictureBox1.Refresh();
                }

            }
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 20;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void �I�u��uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void ���u��uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void ���uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void �x�s�ɮ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.png", ImageFormat.Png);
                MessageBox.Show("�s�ɦ��\");
            }
            catch
            {
                MessageBox.Show("�s�ɥ���");
            }

        }

        private void �`��uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            p.DashPattern = new float[] { 6.0F, 3.0F };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wipe = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wipe = false;
        }
    }
}
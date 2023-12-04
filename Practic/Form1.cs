using Practic._4_практична;
using Practic._5__практична;
using Practic._6_практична;

namespace Practic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tabul tabul = new Tabul();

            double xn, xk, h, a;

            xn = Convert.ToDouble(this.textBox1.Text);
            xk = Convert.ToDouble(this.textBox2.Text);
            h = Convert.ToDouble(this.textBox3.Text);
            a = Convert.ToDouble(this.textBox4.Text);

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul.tab(xn, xk, h, a);

            for (int i = 0; i < tabul.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul.xy[i, 0], 2).ToString(),
                    Math.Round(tabul.xy[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
            }

        }

        private void одновимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Array f = new Array();
            f.Show();
            this.Hide();
        }

        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoubleArray f = new DoubleArray();
            f.Show();
            this.Hide();
        }

        private void labaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4Laba f = new _4Laba();
            f.Show();
            this.Hide();
        }

        private void практинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4pract f = new _4pract();
            f.Show();
            this.Hide();
        }

        private void практичнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pract5 f = new Pract5();
            f.Show();
            this.Hide();
        }

        private void практичнаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pract6 f = new Pract6();
            f.Show();
            this.Hide();
        }
    }
}
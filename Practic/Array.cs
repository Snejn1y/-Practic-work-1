using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic
{
    public partial class Array : Form
    {
        public Array()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                int n = Convert.ToInt32(textBox5.Text);
                int Tmin = Convert.ToInt32(textBox1.Text);
                int Tmax = Convert.ToInt32(textBox2.Text);
                int Opmin = Convert.ToInt32(textBox3.Text);
                int Opmax = Convert.ToInt32(textBox4.Text);

                ArrayClass T = new ArrayClass(Tmin, Tmax, n);
                ArrayClass Op = new ArrayClass(Opmin, Opmax, n);

                for(int i = 0; i < T.Length; i++)
                {
                    dataGridView1.Rows.Add(T[i].ToString(), Op[i].ToString());
                }

                var opadi = T.Count(Op, T);

                label5.Text = opadi.Item1.ToString();
                label6.Text = opadi.Item3.ToString();
                label7.Text = opadi.Item2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

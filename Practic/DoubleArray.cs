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
    public partial class DoubleArray : Form
    {
        public DoubleArray()
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
            try
            {
                int n = 0;
                n = Convert.ToInt32(textBox1.Text);

                Array2D arr = new Array2D(n, n);

                DataGridViewTextBoxColumn dvage;

                for (int i = 0; i < n; i++)
                {
                    dvage = new DataGridViewTextBoxColumn();
                    dvage.Width = 40;
                    dataGridView1.Columns.Add(dvage);
                }

                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = arr.X_length;
                dataGridView1.ColumnCount = arr.Y_length;

                for (int i = 0; i < arr.X_length; i++)
                    for (int j = 0; j < arr.Y_length; j++)
                        dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();

                int dob = arr.Dob_Gol;
                label2.Text = dob.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

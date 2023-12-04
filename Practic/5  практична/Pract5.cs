using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practic;

namespace Practic._5__практична
{
    public partial class Pract5 : Form
    {
        People people = new People();
        string path = "people.txt";
        public Pract5()
        {
            InitializeComponent();
        }

        public void show(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (Person p in people.people)
            {
                dg.Rows.Add(p.PIB, p.Posada, p.Zarplata, p.Stage);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new Person(
                    pib.Text,
                    posada.Text,
                    Convert.ToDouble(zarplata.Text),
                    Convert.ToDouble(stage.Text)
                    );
                people.Add(p);
                dataGridView2.Rows.Add(
                    people.people[people.people.Count - 1].PIB,
                    people.people[people.people.Count - 1].Posada,
                    people.people[people.people.Count - 1].Zarplata,
                    people.people[people.people.Count - 1].Stage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void Pract5_Activated(object sender, EventArgs e)
        {
            Size = new Size(934, 900);
            dataGridView1.Rows.Clear();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            people.WriteFile(path);
            MessageBox.Show("Файл записано");
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            people.ReadFile(path);
            show(dataGridView2);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            people.SortByStage();
            show(dataGridView3);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var i = dataGridView2.CurrentRow.Index;
            people.Remove(i);
            show(dataGridView2);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            people.people.Sort();
            dataGridView1.Rows.Clear();
            foreach (Person p in people.people)
            {
                if(p.Zarplata < Convert.ToDouble(zarplatamin.Text))
                    dataGridView1.Rows.Add(p.PIB, p.Posada, p.Zarplata, p.Stage);
            }
        }
    }
}

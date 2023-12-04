using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic._4_практична
{
    public partial class _4pract : Form
    {
        public _4pract()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reader = new ArrayFileReader();
            var writer = new ArrayFileWriter();
            var analyzer = new ArrayAnalyzer();

            int[] array = reader.ReadArrayFromFile("input.txt");

            int maxZeros = analyzer.CountMaxConsecutiveZeros(array);


            writer.WriteResultToFile(maxZeros, "result.txt");

            Arr.Text = writer.WriteResultConsole(array);
            Ans.Text = maxZeros.ToString();

        }
    }
}

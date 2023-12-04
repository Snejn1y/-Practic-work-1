using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic._6_практична
{
    public partial class Pract6 : Form
    {
        InternalCombustionEngine icEngine = new InternalCombustionEngine();
        Diesel dieselEngine = new Diesel();
        JetEngine jetEngine = new JetEngine();
        EngineEvents engineEvents = new EngineEvents();

        public Pract6()
        {
            InitializeComponent();
            icEngine.EngineStarted += EngineStarted;
            icEngine.EngineStopped += EngineStopped;
            icEngine.PerformMaintenanceStart += PerformMaintenanceStart;
            jetEngine.EngineStarted += EngineStarted;
            jetEngine.EngineStopped += EngineStopped;
            dieselEngine.EngineStarted += EngineStarted;
            dieselEngine.EngineStopped += EngineStopped;
            dieselEngine.PerformMaintenanceStart += PerformMaintenanceStart;
            dieselEngine.EnergyEfficiencyStart += EnergyEfficiencyStart;
        }

        private void EngineStarted(string message)
        {
            MessageBox.Show(message);
        }

        private void EngineStopped(string message)
        {
            MessageBox.Show(message);
        }

        private void PerformMaintenanceStart(string message)
        {
            MessageBox.Show(message);
        }
        private void EnergyEfficiencyStart(string message)
        {
            MessageBox.Show(message);
        }

        private void startICEngineBtn_Click(object sender, EventArgs e)
        {
            icEngine.Start();
        }
        private void stopICEngineBtn_Click(object sender, EventArgs e)
        {
            icEngine.Stop();
        }
        private void PerformMaintenance1_Click(object sender, EventArgs e)
        {
            icEngine.PerformMaintenance();
        }
        private void startDieselEngineBtn_Click(object sender, EventArgs e)
        {
            dieselEngine.Start();
        }
        private void stopDieselEngineBtn_Click(object sender, EventArgs e)
        {
            dieselEngine.Stop();
        }
        private void PerformMaintenance2_Click(object sender, EventArgs e)
        {
            dieselEngine.PerformMaintenance();
        }
        private void Effective_Click(object sender, EventArgs e)
        {
            dieselEngine.EnergyEfficiency();
        }
        private void startJetEngineBtn_Click(object sender, EventArgs e)
        {
            jetEngine.Start();
        }
        private void stopJetEngineBtn_Click(object sender, EventArgs e)
        {
            jetEngine.Stop();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}

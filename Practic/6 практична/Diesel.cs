using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic._6_практична
{
    public class Diesel : Engine, IMaintainable, IEfficient
    {
        public override void Start()
        {
            MessageBox.Show("Diesel Engine started.");
            OnEngineStarted("Success started.");
        }
        public override void Stop()
        {
            MessageBox.Show("Diesel Engine stopped.");
            OnEngineStopped("Success stopped.");
        }
        public void PerformMaintenance()
        {
            MessageBox.Show("Diesel Engine maintenance.");
            OnPerformMaintenanceStart("Success maintenance.");
        }
        public void EnergyEfficiency()
        {
            MessageBox.Show("Diesel Engine efficiency checked.");
            OnEnergyEfficiencyChecked("Success efficiency checked.");
        } 
    }   
}

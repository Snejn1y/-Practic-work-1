namespace Practic._6_практична
{
    public class InternalCombustionEngine : Engine, IMaintainable
    {
        public override void Start()
        {
            MessageBox.Show("Internal Combustion Engine started.");
            OnEngineStarted("Success started.");
        }

        public override void Stop()
        {
            MessageBox.Show("Internal Combustion Engine stopped.");
            OnEngineStopped("Success stopped.");
        }

        public void PerformMaintenance()
        {
            MessageBox.Show("Internal Combustion Engine maintenance.");
            OnPerformMaintenanceStart("Success maintenance.");
        }
    }
}

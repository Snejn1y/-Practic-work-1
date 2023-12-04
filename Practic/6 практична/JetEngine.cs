namespace Practic._6_практична
{
    public class JetEngine : Engine
    {
        public override void Start()
        {
            MessageBox.Show("Jet Engine started.");
            OnEngineStarted("Success started.");
        }

        public override void Stop()
        {
            MessageBox.Show("Jet Engine stopped.");
            OnEngineStopped("Success stopped.");
        }
    }
}

using System;
using System.Windows;

namespace Practic._6_практична
{
    public delegate void EngineStatusHandler(string message);

    public abstract class Engine
    {
        public event EngineStatusHandler EngineStarted;
        public event EngineStatusHandler EngineStopped;
        public event EngineStatusHandler PerformMaintenanceStart;
        public event EngineStatusHandler EnergyEfficiencyStart;

        public abstract void Start();
        public abstract void Stop();

        protected void OnEngineStarted(string message)
        {
            EngineStarted?.Invoke(message);
        }

        protected void OnEngineStopped(string message)
        {
            EngineStopped?.Invoke(message);
        }

        protected void OnPerformMaintenanceStart(string message)
        {
            PerformMaintenanceStart?.Invoke(message);
        }

        protected void OnEnergyEfficiencyChecked(string message)
        {
            EnergyEfficiencyStart?.Invoke(message);
        }
    }
}

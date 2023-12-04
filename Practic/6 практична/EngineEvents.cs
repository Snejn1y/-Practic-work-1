using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic._6_практична
{
    public delegate void EngineOperations(string status);

    public class EngineEvents
    {
        public event EngineOperations OperationsCompleted;

        public void OnOperationsCompleted()
        {
            OperationsCompleted?.Invoke("Операція успішна");
        }
    }
}

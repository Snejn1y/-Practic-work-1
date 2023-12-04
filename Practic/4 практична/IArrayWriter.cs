using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic._4_практична
{
    public interface IArrayWriter
    {
        void WriteResultToFile(int result, string filePath);
        string WriteResultConsole(int[] ints);
    }
}

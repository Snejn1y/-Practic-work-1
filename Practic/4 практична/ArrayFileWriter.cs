using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic._4_практична
{
    public class ArrayFileWriter : IArrayWriter
    {
        public void WriteResultToFile(int result, string filePath)
        {
            File.WriteAllText(filePath, result.ToString());
        }
        public string WriteResultConsole(int[] ints)
        {
            string arr = "";
            foreach (var item in ints)
            {
                arr += item.ToString();
                arr += " ";
            }
            return arr;
        }
    }
}

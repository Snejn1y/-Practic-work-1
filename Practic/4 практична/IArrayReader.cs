﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic
{
    public interface IArrayReader
    {
        int[] ReadArrayFromFile(string filePath);
    }
}

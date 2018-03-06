using System;
using System.Collections.Generic;
using System.Text;

namespace Wuerstelstand_Simulator.Database
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}

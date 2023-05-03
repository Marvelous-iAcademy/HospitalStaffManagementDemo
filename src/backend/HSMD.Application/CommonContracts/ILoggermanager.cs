using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.CommonContracts
{
    public interface ILoggermanager
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogDebug(string message);
    }
}

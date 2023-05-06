using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.CommonContracts
{
    public interface ILoggerManager 
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogDebug(string message);
    }
}
/*This code defines an interface called ILoggerManager,
 * which is used to define a contract for a logging
 * component in a software system. The interface declares 
 * four methods that can be used to log different levels
 * of information:

LogInfo: Used to log general information messages.
LogWarning: Used to log warning messages.
LogError: Used to log error messages.
LogDebug: Used to log debug messages.
An interface is a blueprint for a class, which means that
any class that implements this interface must provide an 
implementation for each of these methods. By defining this 
interface, the code that depends on the logger can use any 
implementation of ILoggerManager interchangeably, making 
it easy to swap out the logger implementation as needed.*/
using HSMD.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.CommonContracts
{
    public interface IRepositoryManager
    {
        IHospitalRepository hospital { get; }
        IStaffRepository staff { get; }
        Task SaveAsync();
    }

    /*This code defines an interface called `IRepositoryManager`,
     * which is used to define a contract for a repository manager 
     * component in a software system. The interface declares three members:

- `hospital`: A property of type `IHospitalRepository`, which 
    represents a repository for managing hospital entities.
- `staff`: A property of type `IStaffRepository`, which represents
    a repository for managing staff entities.
- `SaveAsync()`: A method that is used to persist changes made to the 
    data source by any of the repositories managed by this repository 
    manager.

The purpose of this interface is to provide a single point of entry for managing multiple repositories in a software system. By defining this interface, the code that depends on the repository manager can use any implementation of `IRepositoryManager` interchangeably, making it easy to swap out the repository manager implementation as needed. Additionally, by exposing the repositories as properties of the repository manager, it becomes easy to manage the lifetime of these repositories, such as by disposing them when they are no longer needed.*/
    public class RepositoryManager : IRepositoryManager
    {
        public IHospitalRepository hospital => throw new NotImplementedException();

        public IStaffRepository staff => throw new NotImplementedException();

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}

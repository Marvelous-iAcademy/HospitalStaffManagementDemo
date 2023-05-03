using HSMD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.Contracts
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> GetAllStaffsAsync(bool trackChanges);
        Task<Staff> GetStaffByIdAsync(int Id, bool trackChanges);
        Task<Staff> GetStaffByName(string FirstName, string LastName, bool trackChanges);
        void CreateStaff(Staff staff);
        void DeleteStaff(Staff staff);
    }
}

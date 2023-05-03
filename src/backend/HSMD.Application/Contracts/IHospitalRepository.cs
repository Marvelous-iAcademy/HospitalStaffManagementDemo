using HSMD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.Contracts
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAllHospitalAsync(bool trackChanges);
        Task<Hospital> GetHospitalAsync(int Id, bool trackChanges);
        Task<Hospital> GetHospitalByName(string HospitalName, bool trackChanges);
        void CreateHospital(Hospital hospital);
        void DeleteHospital(Hospital hospital);
    }
}

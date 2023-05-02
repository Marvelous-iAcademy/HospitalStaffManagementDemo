using HSMD.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.CommonContracts
{
    public interface IRepositorymanager
    {
        IHospitalRepository hospital { get; }
        IStaffRepository staff { get; }
        Task SaveAsync();
    }
}

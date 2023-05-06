using HSMD.Application.CommonContracts;
using HSMD.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Infrastructure.Data.Common
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        public IHospitalRepository hospital => throw new NotImplementedException();

        public IStaffRepository staff => throw new NotImplementedException();

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.CommonContracts
{
    public interface IRepositoryBase
    {
        IQueryable<T> FindAll(bool trackChanges);
    }
}

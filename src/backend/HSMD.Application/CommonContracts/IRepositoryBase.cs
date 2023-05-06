using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.CommonContracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
/*This code defines an interface called `IRepositoryBase<T>`, which is used to define a contract 
 * for a repository component in a software system. The interface declares five methods that can 
 * be used to perform CRUD (Create, Read, Update, and Delete) operations on a data source for a 
 * specific type of entity `T`:

- `FindAll`: Used to retrieve all entities of type `T` from the data source. The `trackChanges` 
parameter is used to indicate whether changes made to the entities should be tracked by the data source.
- `FindByCondition`: Used to retrieve a subset of entities of type `T` from the data source that match 
a specific condition specified by the `expression` parameter. The `trackChanges` parameter is used to 
indicate whether changes made to the entities should be tracked by the data source.
- `Create`: Used to add a new entity of type `T` to the data source.
- `Update`: Used to update an existing entity of type `T` in the data source.
- `Delete`: Used to remove an existing entity of type `T` from the data source.

The generic type parameter `T` is used to specify the type of entity that the repository operates on. 
By defining this interface, the code that depends on the repository can use any implementation of
`IRepositoryBase<T>` interchangeably, making it easy to swap out the repository implementation as needed.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Repositories
{
   
    public interface IRepositoryBase<TEntity> :IDisposable where TEntity : class
    {        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Services
{    
    public interface IServiceBase<TEntity>: IDisposable where TEntity : class
    {        
    }
}

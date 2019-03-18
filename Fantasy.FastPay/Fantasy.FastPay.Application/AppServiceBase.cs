using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application.Interfaces
{
    public class AppServiceBase<TEntity>: IDisposable,  IAppServiceBase<TEntity> where TEntity: class
    {

        private readonly IServiceBase<TEntity> _serviceBase;
        
        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
       
        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

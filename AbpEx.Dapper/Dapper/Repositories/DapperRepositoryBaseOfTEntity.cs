﻿using Abp.Dapper.DbContext;
using Abp.Domain.Entities;

namespace Abp.Dapper.Repositories
{
    public class DapperRepositoryBase<TEntity> : DapperRepositoryBase<TEntity, int>, IDapperRepository<TEntity>        
        where TEntity : class, IEntity<int>
    {
        public DapperRepositoryBase(IDapperDbContextProvider dapperContextProvider) 
            : base(dapperContextProvider)
        {
        }
    }
}

﻿using AUTH_SERVICE_INFRASTRUCTURE.Models;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Config.Interfaces;
using System.Threading.Tasks;

namespace AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Config
{
    public class BaseConfigUnitOfWork : IBaseConfigUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public BaseConfigUnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task CommitAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}

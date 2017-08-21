
using CSM.Entities;
using Microsoft.Extensions.DependencyInjection;
using HTActive.Core.Repository;
using System;

namespace CSM.Repository
{
    public class InstanceUnitOfWork : BaseUnitOfWork<InstanceEntities>
    {
        public InstanceUnitOfWork(InstanceEntities entity)
            : base(entity)
        {
        }
    }
    public class CSMDBRepository
    {
	    public IServiceProvider ServiceProvider{get;private set;}
		public IBaseUnitOfWork<InstanceEntities> InstanceUnitOfWork{get;private set;}
        public CSMDBRepository(IBaseUnitOfWork<InstanceEntities> unitOfWork, IServiceProvider _serviceProvider)
        {
			this.InstanceUnitOfWork = unitOfWork;
			this.ServiceProvider = _serviceProvider;
		}
        public void Commit()
        {
            this.InstanceUnitOfWork.Commit();
        }
        #region Repositories
        private ITestRepository _TestRepository;
        public ITestRepository TestRepository 
		{ 
			get
			{
				return _TestRepository ?? 
				(_TestRepository = ServiceProvider.GetService<ITestRepository>());
			}
		}
		#endregion
    }
	
    public static class RegisterServiceHelper
    {
        public static void RegisterRepository(IServiceCollection services)
        {
			services.AddScoped<ITestRepository, TestRepository>();
		}
    }
}
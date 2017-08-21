
using CSM.Entities;
using HTActive.Core.Repository;
namespace CSM.Repository
{
    public partial class TestRepository : BaseRepository<Test, InstanceEntities>, ITestRepository
    {
        public TestRepository(IBaseUnitOfWork<InstanceEntities> unitOfWork)
            : base(unitOfWork)
        {

        }
		protected override int GetKeyId(Test model)
        {
            return model.Id;
        }
	}
}
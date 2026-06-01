using ServiceLifeTimesInDI.Service.IService;

namespace ServiceLifeTimesInDI.Service
{
    public class Scope : IScope
    {
        private readonly Guid _id;
        public Scope()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }
    }
}

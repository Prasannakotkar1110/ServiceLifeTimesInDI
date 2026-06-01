using ServiceLifeTimesInDI.Service.IService;

namespace ServiceLifeTimesInDI.Service
{
    public class MySingleTon : IMySingleTon
    {
        private readonly Guid _id;

        public MySingleTon()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }
    }
}

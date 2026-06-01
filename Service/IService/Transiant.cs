namespace ServiceLifeTimesInDI.Service.IService
{
    public class Transiant : ITransiant
    {
        private readonly Guid _id;
        public Transiant()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }
    }
}

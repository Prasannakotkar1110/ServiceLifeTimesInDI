using Microsoft.AspNetCore.Mvc;
using ServiceLifeTimesInDI.Service;
using ServiceLifeTimesInDI.Service.IService;

namespace ServiceLifeTimesInDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceLifetimeController : ControllerBase
    {
        
        private readonly IMySingleTon _IMyService1;
        private readonly IMySingleTon _IMyService2;
        private readonly IScope _IScope1;
        private readonly IScope _IScope2;
        private readonly ITransiant _ITransiant1;
        private readonly ITransiant _ITransiant2;
        public ServiceLifetimeController(IMySingleTon myservice1, IMySingleTon myService2, 
            IScope IScope1, IScope IScope2, ITransiant iTransiant1, ITransiant itransiant2)
        {
            _IMyService1 = myservice1;
            _IMyService2 = myService2;
            _IScope1 = IScope1;
            _IScope2 = IScope2;
            _ITransiant1 = iTransiant1;
            _ITransiant2 = itransiant2;
        }


        [HttpGet]
        [Route("CheckAllScope")]
        public IActionResult GetForSingleton()
        {
            return Ok(new
            {
                Singleton1 = _IMyService1.GetId(),
                Singleton2 = _IMyService2.GetId(),

                scope1 = _IScope1.GetId(),
                Scope2 = _IScope2.GetId(),

                Trasiant = _ITransiant1.GetId(),
                Transiant2 = _ITransiant2.GetId()

            });
        }
    }
}

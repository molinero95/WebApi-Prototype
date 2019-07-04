using Application.Business.Services.Interfaces;
using Application.Business.Services;


namespace Application.Business.ServiceFactories
{
    public abstract class ApplicationServiceFactory
    {
        private static ApplicationServiceFactory _instance;
        protected ApplicationServiceFactory() { }
        public static ApplicationServiceFactory GetInstance()
        {
            if (_instance == null)
                _instance = new ApplicationServiceFactoryImp();
            return _instance;
        }


        public abstract IApplicationService GetApplicationService(ApplicationBusinessServices service); 

    }
}

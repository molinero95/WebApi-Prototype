using Application.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Business.Factories
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


        public abstract IApplicationService GetApplicationService(ApplicationServices service); 

    }
}

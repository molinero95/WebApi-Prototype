using System;
using System.Collections.Generic;
using System.Text;
using Application.Business.Services;
using Application.Business.Services.Interfaces;

namespace Application.Business.Factories
{
    public class ApplicationServiceFactoryImp : ApplicationServiceFactory
    {
        internal ApplicationServiceFactoryImp() { }

        public override IApplicationService GetApplicationService(ApplicationServices service)
        {
            switch (service)
            {
                case ApplicationServices.ArticlesService: return ArticlesService.GetInstance();
                case ApplicationServices.ContainerService: return ContainersService.GetInstance();
                default:
                    return null;
            }
        }
    }
}

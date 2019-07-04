using System;
using System.Collections.Generic;
using System.Text;
using Application.Business.Services;
using Application.Business.Services.Interfaces;

namespace Application.Business.ServiceFactories
{
    internal class ApplicationServiceFactoryImp : ApplicationServiceFactory
    {
        internal ApplicationServiceFactoryImp() { }

        public override IApplicationService GetApplicationService(ApplicationBusinessServices service)
        {
            switch (service)
            {
                case ApplicationBusinessServices.ArticlesService: return ArticlesService.GetInstance();
                case ApplicationBusinessServices.ContainerService: return ContainersService.GetInstance();
                default:
                    return null;
            }
        }
    }
}

using System;
using Application.Data.Services;

namespace Application.Data.ServicesFactories
{
    internal class DataServiceFactoryImp : DataServiceFactory
    {
        public override IDataService GetDataService(ApplicationDataServices service)
        {
            switch (service)
            {
                case ApplicationDataServices.DAOService: return DAOService.GetInstance();
                case ApplicationDataServices.LogService: return LogService.GetInstance();
                case ApplicationDataServices.RequestService: return RequestService.GetInstance();
                default: return null;
            }
        }
    }
}

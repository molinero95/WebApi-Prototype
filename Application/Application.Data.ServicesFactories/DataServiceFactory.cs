using System;
using Application.Data.Services;

namespace Application.Data.ServicesFactories
{
    public abstract class DataServiceFactory
    {

        private static DataServiceFactory _instance;
        protected DataServiceFactory() { }
        public static DataServiceFactory GetInstance()
        {
            if (_instance == null)
                _instance = new DataServiceFactoryImp();
            return _instance;
        }


        public abstract IDataService GetDataService(ApplicationDataServices service);

    }
}


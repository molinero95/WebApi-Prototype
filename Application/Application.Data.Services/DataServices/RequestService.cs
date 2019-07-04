using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Services
{
    public abstract class RequestService : IDataService
    {
        private static RequestService _instance { get; set; }
        protected RequestService()
        {

        }
        public static RequestService GetInstance()
        {
            if (_instance == null)
                _instance = new RequestServiceImp();
            return _instance;
        }
    }
}

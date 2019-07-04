using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Services
{
    public abstract class LogService : IDataService
    {

        private static LogService _instance { get; set; }
        protected LogService()
        {

        }

        public static LogService GetInstance()
        {
            if (_instance == null)
                _instance = new LogServiceImp();
            return _instance;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Services
{
    public abstract class DAOService: IDataService
    {

        private static DAOService _instance { get; set; }
        protected DAOService()
        {

        }

        public static DAOService GetInstance()
        {
            if (_instance == null)
                _instance = new DAOServiceImp();
            return _instance;
        }
        
    }
}

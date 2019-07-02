using Application.Business.Services.Base;
using Application.Business.Services.Interfaces;
using Application.Common.Entities.Containers;
using Application.Common.Entities.Containers.Lines;
using System;
using System.Collections.Generic;

namespace Application.Business.Services
{
    public abstract class ContainersService : BaseApplicationServiceWithId<Container>
    {
        private static ContainersService _instance { get; set; }

        protected ContainersService() { }
        public static ContainersService GetInstance()
        {
            if (_instance == null)
                _instance = new ContainersServiceImp();
            return _instance;
        }

    }
}

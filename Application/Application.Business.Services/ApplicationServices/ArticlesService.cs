using Application.Business.Services.Base;
using Application.Common.Entities.Articles;
using System;
using System.Collections.Generic;

namespace Application.Business.Services
{
    public abstract class ArticlesService: BaseApplicationServiceWithId<Article>
    {
        private static ArticlesService _instance { get; set; }

        protected ArticlesService() { }
        public static ArticlesService GetInstance()
        {
            if (_instance == null)
                _instance = new ArticlesServiceImp();
            return _instance;
        }

        
    }
}

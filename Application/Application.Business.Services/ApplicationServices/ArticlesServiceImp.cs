using System;
using System.Collections.Generic;
using Application.Common.Entities.Articles;

namespace Application.Business.Services
{
    public class ArticlesServiceImp: ArticlesService
    {
        internal ArticlesServiceImp() { }

        public override Article Create(Article item)
        {
            throw new NotImplementedException();
        }

        public override Article Create(List<Article> items)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int itemId)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(List<int> itemsIds)
        {
            throw new NotImplementedException();
        }

        public override Article Get(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Article> Get(List<int> id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Article item)
        {
            throw new NotImplementedException();
        }

        public override bool Update(List<Article> items)
        {
            throw new NotImplementedException();
        }
    }
}

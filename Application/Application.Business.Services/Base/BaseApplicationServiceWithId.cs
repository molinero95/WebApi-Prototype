using Application.Business.Services.Interfaces;
using Application.Common.Entities.Base;
using Application.Common.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Application.Business.Services.Base
{
    public abstract class BaseApplicationServiceWithId<T> : BaseApplicationService<T>, IGenericApplicationServiceWithId<T> where T : IItemWithId
    {
        public abstract override T Create(T item);

        public abstract override T Create(List<T> items);

        public override bool Delete(T item)
        {
            return Delete(item.Id);
        }

        public override bool Delete(List<T> items)
        {
            return Delete(items.Select(item => item.Id) as List<int>);
        }

        public abstract bool Delete(int itemId);

        public abstract bool Delete(List<int> itemsIds);

        public abstract T Get(int id);

        public abstract List<T> Get(List<int> id);

        public abstract override bool Update(T item);

        public abstract override bool Update(List<T> items);
    }
}

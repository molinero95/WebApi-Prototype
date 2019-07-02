using Application.Common.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Business.Services.Interfaces
{
    public interface IGenericApplicationServiceWithId<T>: IGenericApplicationService<T> where T: IItemWithId
    {
        T Get(int id);
        List<T> Get(List<int> id);
        bool Delete(int itemId);
        bool Delete(List<int> itemsIds);
    }
}

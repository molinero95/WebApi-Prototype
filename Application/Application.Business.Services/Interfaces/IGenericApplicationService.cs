using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Business.Services.Interfaces
{
    public interface IGenericApplicationService<T>: IApplicationService
    {
        T Create(T item);
        T Create(List<T> items);
        bool Update(T item);
        bool Update(List<T> items);
        bool Delete(T item);
        bool Delete(List<T> items);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Application.Business.Services.Interfaces;

namespace Application.Business.Services.Base
{
    public abstract class BaseApplicationService<T> : IGenericApplicationService<T>
    {
        public abstract T Create(T item);

        public abstract T Create(List<T> items);

        public abstract bool Delete(T item);

        public abstract bool Delete(List<T> items);

        public abstract bool Update(T item);

        public abstract bool Update(List<T> items);
    }
}

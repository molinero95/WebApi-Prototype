using Application.Common.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Entities.Base
{
    public class BaseItemWithId: IItemWithId
    {
        public int Id { get; set; }
    }
}

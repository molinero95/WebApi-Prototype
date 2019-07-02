using Application.Common.Entities.Base;
using Application.Common.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Entities.Articles.References
{
    public class Reference: BaseItemWithId
    {
        public string Name { get; set; }
    }
}

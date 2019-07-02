using Application.Common.Entities.Base;
using Application.Common.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Entities.Articles.Colors
{
    public class Color: BaseItemWithId
    {
        public string Name { get; set; }
    }
}

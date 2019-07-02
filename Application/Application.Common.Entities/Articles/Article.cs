using Application.Common.Entities.Articles.Colors;
using Application.Common.Entities.Articles.References;
using Application.Common.Entities.Base;
using Application.Common.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Entities.Articles
{
    public class Article: BaseItemWithId
    {
        public Reference Reference { get; set; }
        public Color Color { get; set; }

    }
}

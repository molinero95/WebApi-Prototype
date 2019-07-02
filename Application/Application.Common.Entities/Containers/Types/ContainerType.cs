using Application.Common.Entities.Articles;
using Application.Common.Entities.Base;
using Application.Common.Entities.Interfaces;
using System;

namespace Application.Common.Entities.Containers.Types
{
    public class ContainerType: BaseItemWithId
    {
        public string Name { get; set; }   
    }
}

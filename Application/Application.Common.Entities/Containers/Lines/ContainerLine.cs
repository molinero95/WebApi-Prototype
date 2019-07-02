using Application.Common.Entities.Articles;
using Application.Common.Entities.Base;
using Application.Common.Entities.Interfaces;
using System;

namespace Application.Common.Entities.Containers.Lines
{
    public class ContainerLine: BaseItemWithId
    {
        public int ContainerId { get; set; }
        public Article Article { get; set; }
        public float Quantity { get; set; }
    }
}

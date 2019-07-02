using Application.Common.Entities.Base;
using Application.Common.Entities.Containers.Lines;
using Application.Common.Entities.Containers.Types;
using Application.Common.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Application.Common.Entities.Containers
{
    public class Container: BaseItemWithId
    {
        public string Code { get; set; }
        public ContainerType ContainerType { get; set; }
        public List<ContainerLine> Lines { get; set; }
    }
}

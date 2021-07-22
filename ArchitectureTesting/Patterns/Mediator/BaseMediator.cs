using ArchitectureTesting.Patterns.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternPlay.Mediator
{
    public abstract class BaseMediator
    {
        public abstract void Send(BaseComponent component);

        public ILookup<BaseComponent, ComponentRelations> ComponentNotificationRelationship { get; set; }
    }
}

using ArchitectureTesting.Patterns.Mediator;
using System.Linq;

namespace PatternPlay.Mediator
{
    public abstract class BaseMediator
    {
        public abstract void Send(BaseComponent component);

        public ILookup<BaseComponent, ComponentRelations> ComponentNotificationRelationship { get; set; }
    }
}

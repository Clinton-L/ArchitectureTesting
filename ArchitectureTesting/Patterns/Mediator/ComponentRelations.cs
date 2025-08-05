using PatternPlay.Mediator;
using System;

namespace ArchitectureTesting.Patterns.Mediator
{
    public class ComponentRelations
    {
        public ComponentRelations(BaseComponent key, BaseComponent components)
        {
            KeyComponent = key;
            RelationalComponent = components;
        }

        public ComponentRelations(BaseComponent key, BaseComponent components, Func<BaseComponent, bool> filter)
        {
            KeyComponent = key;
            RelationalComponent = components;
            Filter = filter;
        }

        public BaseComponent KeyComponent { get; set; }
        public BaseComponent RelationalComponent { get; set; }
        public Func<BaseComponent, bool> Filter { get; set; } = (BaseComponent component) => true;
    }
}

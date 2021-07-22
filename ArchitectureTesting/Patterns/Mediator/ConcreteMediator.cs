using ArchitectureTesting.Patterns.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternPlay.Mediator
{
    public class ConcreteMediator : BaseMediator
    {
        public ConcreteMediator()
        {

        }

        public override void Send(BaseComponent keyCompenent)
        {
            foreach (var componentRelation in ComponentNotificationRelationship[keyCompenent])
            {
                if (componentRelation.Filter(keyCompenent))
                {
                    componentRelation.RelationalComponent.Notify(keyCompenent.State);
                }
            }
            //switch(component)
            //{
            //    case WindscreenMoistureSensor _:
            //        _windscreenWiperMechanism.Notify(message);
            //        break;
            //    case WindscreenWiperMechanism _:
            //        _windscreenMoistureSensor.Notify(message);
            //        break;
            //}
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PatternPlay.Mediator
{
    public class WindscreenMoistureSensor : BaseComponent
    {
        public WindscreenMoistureSensor(BaseMediator mediator) : base(mediator) { }

        public override void Notify(string message) => Console.WriteLine("Moisture Sensor notified: " + message);

        public override void Send() => Mediator.Send(this);
    }
}

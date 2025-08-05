using System;

namespace PatternPlay.Mediator
{
    public class WindscreenWiperMechanism : BaseComponent
    {
        public WindscreenWiperMechanism(BaseMediator mediator) : base(mediator) { }

        public override void Notify(string message) => Console.WriteLine("Windscreen: " + message);
        public override void Send() => Mediator.Send(this);
        public override string State => "Windscreen wiper started, pause moisture sensor for 3 seconds.";
        public int MoistureLevel = 9;
    }
}

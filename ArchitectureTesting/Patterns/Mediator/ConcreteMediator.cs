namespace PatternPlay.Mediator
{
    public class ConcreteMediator : BaseMediator
    {
        public override void Send(BaseComponent keyCompenent)
        {
            switch (keyCompenent)
            {
                case WindscreenMoistureSensor _:
                    ((WindscreenWiperMechanism)keyCompenent).Notify("Its raining");
                    break;
                case WindscreenWiperMechanism _:
                    ((WindscreenMoistureSensor)keyCompenent).Notify("Water cleared");
                    break;
            }
        }

        /***
         * Extending on the above we can include more components to be notified from 1 component.
         * We can also begin to exted in more complicated scenarios where we introduce more complex series of notifications
         ***/
    }
}

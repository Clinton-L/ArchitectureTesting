namespace PatternPlay.Mediator
{
    public abstract class BaseComponent
    {
        protected BaseMediator Mediator;

        public BaseComponent(BaseMediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void Notify(string message);
        public abstract void Send();
        public virtual string State { get; set; }
    }
}

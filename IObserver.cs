namespace observer
{
    public interface IObserver
    {
        void Update(ISubject sender);
    }
}
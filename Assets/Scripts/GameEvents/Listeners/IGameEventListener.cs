namespace SO.Events
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }
}
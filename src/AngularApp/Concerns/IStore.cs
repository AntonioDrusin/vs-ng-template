namespace AngularApp.Concerns
{
    // an example of a dependency injected store.
    public interface IStore<T>
    {
        void Put(T data);
        T Get();
    }
}
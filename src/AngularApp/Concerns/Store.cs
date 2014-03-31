namespace AngularApp.Concerns
{
    internal class Store<T> : IStore<T>
    {
        private T _data;

        public void Put(T data)
        {
            _data = data;
        }

        public T Get()
        {
            return _data;
        }
    }
}
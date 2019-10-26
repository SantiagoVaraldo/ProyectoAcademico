/// <summary>
/// Interfaz IObservable con las firmas Subscribe and Unsubscribe
/// </summary>

namespace Library
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
    }
}
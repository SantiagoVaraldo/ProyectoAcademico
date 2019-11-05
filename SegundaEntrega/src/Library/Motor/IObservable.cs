//--------------------------------------------------------------------------------
// <copyright file="IObservable.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library
{
    /// <summary>
    /// Interfaz IObservable con las firmas Subscribe and Unsubscribe.
    /// </summary>
    public interface IObservable
    {
        void Subscribe(IObserver observer);

        void Unsubscribe(IObserver observer);
    }
}
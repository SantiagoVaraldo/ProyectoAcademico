using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
    public class MotorLvl1 : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        public void Check(Letter letter)
        {
            if (letter.Right)
            {
                letter.Screen.levelCompleted();
                foreach(IObserver observer in observers)
                {
                    observer.Update();
                }
            }
            else
            {
                //mensaje de error que le erro.
            }
        }

        public void Subscribe(IObserver observer)
        {
            if (! observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }

    }
}

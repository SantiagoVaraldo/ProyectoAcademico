using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
    public class MotorLvl3 : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        public void Check(ButtonCheck buttonCheck, ButtonCheck buttonCheck2)
        {
            if (buttonCheck.Check & buttonCheck2.Check)
            {
                buttonCheck.Screen.levelCompleted();
            }
            else
            {
                //mensaje que le erro
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

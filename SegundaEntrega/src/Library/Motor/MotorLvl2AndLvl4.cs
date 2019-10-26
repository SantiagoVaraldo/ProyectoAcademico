using System;
using Proyecto.Common;
using System.Collections.Generic;

/// <summary>
/// NOMBRE: MotorLvl2AndLvl4
/// 
/// DESCRIPCION: Motor encargado de la logica del nivel 2 y 4
/// 
/// SRP: la unica responsabilidad de esta clase es hacer la logica del nivel 2 y 4(la misma logica), su unica razon de 
/// cambio es modificar la logica de estos niveles.
/// 
/// COLABORACIONES: colabora con la interfaz IObserver ya que conoce una lista de IObservers, colabora con la interfaz
/// IObservable ya que es de tipo IObservable, Colabora con la clase Word ya que es el elemento con el que va a 
/// realizar la logica.
/// </summary>

namespace Library
{
    public class MotorLvl2AndLvl4 : IObservable
    {
        private List<Word> listWords = new List<Word>();
        private List<IObserver> observers = new List<IObserver>();
        private int CantDestination;

        /// <summary>
        /// verifica que se haya superado el nivel
        /// </summary>
        /// <param name="word"> Word clickeado </param>
        public void Check(Word word)
        {
            ObtainCantDestination(word);
            
            if (!this.listWords.Contains(word))
            {
                this.AddWord(word);
            }
            else
            {
                this.RemoveWord(word);
            }
            if (this.listWords.Count == 4)
            {
                this.NextLevel(word);
            }
        }

        public void ObtainCantDestination(Word word)
         {
                  foreach(Element element in word.Screen.ListaElement)
                  {
                           if(element is BlanckSpace)
                           {
                                    this.CantDestination += 1;
                           }
                  }
         }
         

        /// <summary>
        /// metodo que establece que la pantalla fue superada y se lo notifica al Observer
        /// </summary>
        /// <param name="word"> Word que fue clickeado </param>
        public void NextLevel(Word word)
        {
            word.Screen.levelCompleted();
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        /// <summary>
        /// metodo que agrega un objeto Word a la lista si tiene la misma posicion que su destination
        /// </summary>
        /// <param name="word"> Word para agregar </param>
        public void AddWord(Word word)
        {
            if (word.PositionY == word.Destination.PositionY & word.PositionX == word.Destination.PositionX)
            {
                this.listWords.Add(word);
            }
        }

        /// <summary>
        /// metodo que elimina un objeto Word de la lista si no tiene la misma posicion que su destination
        /// </summary>
        /// <param name="word"> Word a eliminar </param>
        public void RemoveWord(Word word)
        {
            if (word.PositionY != word.Destination.PositionY || word.PositionX != word.Destination.PositionX)
            {
                this.listWords.Remove(word);
            }
        }

        /// <summary>
        /// metodo que agrega un IObserver a la lista de Observers
        /// </summary>
        /// <param name="observer"> observer para agregar </param>
        public void Subscribe(IObserver observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);
            }
        }

        /// <summary>
        /// metodo que elimina un IObserver de la lista de Observers
        /// </summary>
        /// <param name="observer"> observer a eliminar </param>
        public void Unsubscribe(IObserver observer)
        {
            if (this.observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }

    }
}
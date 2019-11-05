//--------------------------------------------------------------------------------
// <copyright file="EngineLvl4.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: EngineLvl4
    /// DESCRIPCION: Motor encargado de la logica del nivel 4.
    /// SRP: la unica responsabilidad de esta clase es hacer la logica del nivel 4, su unica razon de
    /// cambio es modificar la logica de este nivel.
    /// EXPERT: es el experto en conocer una lista de observers por lo que va a ser quien le notifique al GeneralEngine
    /// cuando se completa el nivel 4.
    /// COLABORACIONES: colabora con la interfaz IObserver ya que conoce una lista de IObservers, colabora con la interfaz
    /// IObservable ya que es de tipo IObservable,colabora con IEngineDropable ya que tambien es de ese tipo,
    /// colabora con la clase Word ya que es el elemento con el que va a realizar la logica.
    /// COMENTARIOS: buscamos la manera de hacer un poco mas generico el metodo check de este motor, la idea era
    /// cambiar el numero fijo "4" en la linea 61, por el atributo de tipo int "CantDestination", no logramos hacerlo funcionar.
    /// </summary>
    public class EngineLvl4 : IObservable, IEngineDropable
    {
        private List<Word> listWords = new List<Word>();
        private List<IObserver> observers = new List<IObserver>();
        private int cantDestination = 0;

        /// <summary>
        /// metodo que establece que la pantalla fue superada y se lo notifica al Observer.
        /// </summary>
        /// <param name="word"> Word que fue clickeado. </param>
        public void NextLevel(Word word)
        {
            if (this.listWords.Count == this.cantDestination)
            {
                word.Screen.LevelCompleted();
                foreach (IObserver observer in this.observers)
                {
                    observer.Update();
                }
            }
        }

        /// <summary>
        /// verifica que se haya superado el nivel.
        /// </summary>
        /// <param name="word"> Word clickeado. </param>
        public void Check(Word word)
        {
            if (this.cantDestination == 0)
            {
                this.ObtainCantDestination(word);
            }
        }

        public void ObtainCantDestination(Word word)
        {
            int num = 0;
            foreach (Element element in word.Screen.ListaElement)
            {
                if (element is BlankSpace)
                {
                    num += 1;
                }
            }

            this.cantDestination = num;
        }

        /// <summary>
        /// metodo que agrega un objeto Word a la lista si tiene la misma posicion que su destination.
        /// </summary>
        /// <param name="word"> Word para agregar. </param>
        public void AddWord(Word word)
        {
            this.listWords.Add(word);
            word.Destination.Fill();
        }

        /// <summary>
        /// metodo que elimina un objeto Word de la lista si no tiene la misma posicion que su destination.
        /// </summary>
        /// <param name="word"> Word a eliminar. </param>
        public void RemoveWord(Word word)
        {
            this.listWords.Remove(word);
            word.Destination.Unfill();
        }

        /// <summary>
        /// metodo que agrega un IObserver a la lista de Observers.
        /// </summary>
        /// <param name="observer"> observer para agregar. </param>
        public void Subscribe(IObserver observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);
            }
        }

        /// <summary>
        /// metodo que elimina un IObserver de la lista de Observers.
        /// </summary>
        /// <param name="observer"> observer a eliminar. </param>
        public void Unsubscribe(IObserver observer)
        {
            if (this.observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }
    }
}
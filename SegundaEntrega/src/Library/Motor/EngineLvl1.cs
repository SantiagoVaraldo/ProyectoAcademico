//--------------------------------------------------------------------------------
// <copyright file="EngineLvl1.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: EngineLvl1
    /// DESCRIPCION: Motor encargado de la logica del nivel 1
    /// SRP: la unica responsabilidad de esta clase es hacer la logica del nivel 1, su unica razon de cambio es modificar
    /// la logica del nivel.
    /// EXPERT: es el experto en conocer una lista de observers por lo que va a ser quien le notifique al GeneralEngine
    /// cuando se completa un nivel de tipo 1.
    /// COLABORACIONES: colabora con la interfaz IObserver ya que conoce una lista de IObservers, colabora con la interfaz
    /// IObservable ya que es de tipo IObservable, Colabora con la clase Letter ya que es el elemento con el que va a
    /// realizar la logica.
    /// </summary>
    public class EngineLvl1 : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// checkea que sea la letra correcta.
        /// </summary>
        /// <param name="letter"> letra la cual fue clickeada. </param>
        public void Check(Letter letter)
        {
            if (letter.Right)
            {
                this.NextLevel(letter);
            }
            else
            {
                // mensaje de error que le erro.
            }
        }

        /// <summary>
        /// metodo que establece que la pantalla fue superada y se lo notifica al Observer.
        /// </summary>
        /// <param name="letter"> letra que fue clickeada. </param>
        /// <returns> retorna true si se paso de nivel y false en caso contrario. </returns>
        public bool NextLevel(Letter letter)
        {
            letter.Screen.LevelCompleted();
            foreach (IObserver observer in this.observers)
            {
                observer.Update();
            }

            return true;
        }

        /// <summary>
        /// metodo que agrega un IObserver a la lista de Observers.
        /// </summary>
        /// <param name="observer"> observer a agregar. </param>
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

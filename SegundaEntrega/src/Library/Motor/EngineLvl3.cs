//--------------------------------------------------------------------------------
// <copyright file="EngineLvl3.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: EngineLvl3
    /// DESCRIPCION: Motor encargado de la logica del nivel 3
    /// SRP: la unica responsabilidad de esta clase es hacer la logica del nivel 3, su unica razon de cambio es modificar
    /// la logica del nivel.
    /// EXPERT: es el experto en conocer una lista de observers por lo que va a ser quien le notifique al GeneralEngine
    /// cuando se completa un nivel de tipo 3.
    /// COLABORACIONES: colabora con la interfaz IObserver ya que conoce una lista de IObservers, colabora con la interfaz
    /// IObservable ya que es de tipo IObservable, Colabora con la clase ButtonCheck ya que es el elemento con el que va a
    /// realizar la logica.
    /// </summary>
    public class EngineLvl3 : IObservable
    {
        private List<ButtonCheck> correctList = new List<ButtonCheck>();
        private List<ButtonCheck> selectedList = new List<ButtonCheck>();
        private int clickNum;
        private List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// verifica que se haya superado el nivel.
        /// </summary>
        /// <param name="buttonCheck"> boton clickeado. </param>
        public void Check(ButtonCheck buttonCheck)
        {
            this.clickNum += 1;

            buttonCheck.Select();
            this.selectedList.Add(buttonCheck);

            this.AddButtonCheck(buttonCheck);
            if ((this.clickNum % 2) == 0)
            {
                if (this.correctList.Count == 2)
                {
                    this.NextLevel(buttonCheck);
                }
                else
                {
                    this.correctList.Clear();

                    foreach (ButtonCheck button in this.selectedList)
                    {
                        button.Unselect();
                    }
                }
            }
        }

        /// <summary>
        /// metodo que establece que la pantalla fue superada y se lo notifica al Observer.
        /// </summary>
        /// <param name="buttonCheck"> boton que fue clickeado. </param>
        /// <returns> retorna true si se paso de nivel y false en caso contrario. </returns>
        public bool NextLevel(ButtonCheck buttonCheck)
        {
            buttonCheck.Screen.LevelCompleted();
            foreach (IObserver observer in this.observers)
            {
                observer.Update();
            }

            this.Reset(buttonCheck.Screen);
            return true;
        }

        /// <summary>
        /// metodo que reinicia el estado del juego y los elementos del nivel.
        /// </summary>
        /// <param name="screen"> Screen reiniciada. </param>
        public void Reset(Screen screen)
        {
            this.correctList.Clear();
            this.selectedList.Clear();
            foreach (Element element in screen.ElementList)
            {
                if (element is ButtonCheck)
                {
                    ((ButtonCheck)element).Unselect();
                }
            }
        }

        /// <summary>
        /// agrega el boton a la lista correcta en el caso de que sea un boton correcto.
        /// </summary>
        /// <param name="buttonCheck"> boton que fue clickeado. </param>
        public void AddButtonCheck(ButtonCheck buttonCheck)
        {
            if (buttonCheck.Check & !this.correctList.Contains(buttonCheck))
            {
                this.correctList.Add(buttonCheck);
            }
        }

        /// <summary>
        /// metodo que agrega un IObserver a la lista de observers.
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
using System;
using Proyecto.Common;
using System.Collections.Generic;

/// <summary>
/// NOMBRE: MotorLvl3
/// 
/// DESCRIPCION: Motor encargado de la logica del nivel 3
/// 
/// SRP: la unica responsabilidad de esta clase es hacer la logica del nivel 3, su unica razon de cambio es modificar
/// la logica del nivel.
/// 
/// COLABORACIONES: colabora con la interfaz IObserver ya que conoce una lista de IObservers, colabora con la interfaz
/// IObservable ya que es de tipo IObservable, Colabora con la clase ButtonCheck ya que es el elemento con el que va a 
/// realizar la logica.
/// </summary>

namespace Library
{
    public class MotorLvl3 : IObservable
    {
        private List<ButtonCheck> correctList = new List<ButtonCheck>();
        private List<ButtonCheck> selectedList = new List<ButtonCheck>();
        private int ClickNum;
        private List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// verifica que se haya superado el nivel
        /// </summary>
        /// <param name="buttonCheck"> boton clickeado </param>
        public void Check(ButtonCheck buttonCheck)
        {
            ClickNum += 1;

            buttonCheck.Select();
            selectedList.Add(buttonCheck);

            this.AddButtonCheck(buttonCheck);
            if ((ClickNum % 2) == 0)
            {
                if (this.correctList.Count == 2)
                {
                    this.NextLevel(buttonCheck);
                }
                else
                {
                    this.correctList.Clear();

                    foreach (ButtonCheck button in selectedList)
                    {
                        button.Unselect();
                    }

                }
            }
        }

        /// <summary>
        /// metodo que establece que la pantalla fue superada y se lo notifica al Observer
        /// </summary>
        /// <param name="buttonCheck"> boton al que se le hizo click </param>
        public void NextLevel(ButtonCheck buttonCheck)
        {
            buttonCheck.Screen.levelCompleted();
            foreach (IObserver observer in this.observers)
            {
                observer.Update();
            }
        }

        /// <summary>
        /// agrega el boton a la lista correcta en el caso de que sea un boton correcto
        /// </summary>
        /// <param name="buttonCheck"> boton que fue clickeado </param>
        public void AddButtonCheck(ButtonCheck buttonCheck)
        {
            if (buttonCheck.Check)
            {
                this.correctList.Add(buttonCheck);
            }
        }

        /// <summary>
        /// metodo que agrega un IObserver a la lista de observers
        /// </summary>
        /// <param name="observer"> observer para agregar</param>
        public void Subscribe(IObserver observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        /// <summary>
        /// metodo que elimina un IObserver de la lista de Observers
        /// </summary>
        /// <param name="observer"> observer a eliminar </param>
        public void Unsubscribe(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }

    }
}
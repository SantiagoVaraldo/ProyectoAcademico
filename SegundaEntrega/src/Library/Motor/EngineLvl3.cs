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
    /// cuando se completa el nivel 3.
    /// COLABORACIONES: colabora con la interfaz IObserver ya que conoce una lista de IObservers, colabora con la interfaz
    /// IObservable ya que es de tipo IObservable, Colabora con la clase ButtonCheck ya que es el elemento con el que va a
    /// realizar la logica. Ademas colabora con la clase OneAdapter.
    /// </summary>
    public class EngineLvl3
    {
        private List<ButtonCheck> correctList = new List<ButtonCheck>();
        private List<ButtonCheck> selectedList = new List<ButtonCheck>();
        private int clickNum;

        /// <summary>
        /// verifica que se haya superado el nivel.
        /// </summary>
        /// <param name="buttonCheck"> boton clickeado. </param>
        public void Check(ButtonCheck buttonCheck)
        {
            this.clickNum += 1;

            OneAdapter.Adapter.Debug($"Button clicked!");
            buttonCheck.Select();
            this.AddButtonSelected(buttonCheck);

            this.AddCorrectButton(buttonCheck);

            if (this.clickNum == 2)
            {
                if (this.correctList.Count == 2)
                {
                    this.NextLevel(buttonCheck);
                }
                else
                {
                    foreach (ButtonCheck button in this.selectedList)
                    {
                        button.Unselect();
                        OneAdapter.Adapter.SetImage(button.ButtonId, button.ImagePath);
                    }

                    this.correctList.Clear();
                    this.selectedList.Clear();
                    this.clickNum = 0;
                }
            }
        }

        /// <summary>
        /// añade el boton a la lista de botones seleccionados.
        /// </summary>
        /// <param name="buttonCheck">boton seleccionado.</param>
        public void AddButtonSelected(ButtonCheck buttonCheck)
        {
            this.selectedList.Add(buttonCheck);
            OneAdapter.Adapter.SetImage(buttonCheck.ButtonId, buttonCheck.ImagePath2);
        }

        /// <summary>
        /// metodo que establece que la pantalla fue superada y se lo notifica al Observer.
        /// </summary>
        /// <param name="buttonCheck"> boton que fue clickeado. </param>
        /// <returns> retorna true si se paso de nivel. </returns>
        public bool NextLevel(ButtonCheck buttonCheck)
        {
            buttonCheck.Screen.LevelCompleted();
            Singleton<GeneralEngine>.Instance.Update();

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
            foreach (ButtonCheck button in this.selectedList)
            {
                button.Unselect();
                OneAdapter.Adapter.SetImage(button.ButtonId, button.ImagePath);
            }

            this.clickNum = 0;
            this.selectedList.Clear();
            screen.LevelUncompleted();
        }

        /// <summary>
        /// agrega el boton a la lista correcta en el caso de que sea un boton correcto.
        /// </summary>
        /// <param name="buttonCheck"> boton que fue clickeado. </param>
        public void AddCorrectButton(ButtonCheck buttonCheck)
        {
            if (buttonCheck.Check & !this.correctList.Contains(buttonCheck))
            {
                this.correctList.Add(buttonCheck);
            }
        }
    }
}
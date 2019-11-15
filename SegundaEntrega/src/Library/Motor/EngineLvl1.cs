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
    /// cuando se completa el nivel 1.
    /// COLABORACIONES: colabora con la clase Letter ya que es el elemento con el que va a
    /// realizar la logica. Ademas colabora con la clase OneAdapter.
    /// </summary>
    public class EngineLvl1
    {
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
                OneAdapter.Adapter.Debug($"Esa no es la letra correcta, intentemos de nuevo!");
            }
        }

        /// <summary>
        /// metodo que establece que la pantalla fue superada y se lo notifica al Observer.
        /// </summary>
        /// <param name="letter"> letra que fue clickeada. </param>
        /// <returns> retorna true si se paso de nivel. </returns>
        public bool NextLevel(Letter letter)
        {
            letter.Screen.LevelCompleted();
            Singleton<GeneralEngine>.Instance.Update();

            return true;
        }

        /// <summary>
        /// resetea el estado del nivel.
        /// </summary>
        /// <param name="screen">screen reseteada.</param>
        public void Reset(Screen screen)
        {
            screen.LevelUncompleted();
        }

        /// <summary>
        /// hace el sonido de una letra.
        /// </summary>
        /// <param name="buttonSound"> boton con el sonido. </param>
        public void Sound(ButtonSound buttonSound)
        {
            OneAdapter.Adapter.Debug($"Button clicked!");
            OneAdapter.Adapter.PlayAudio(buttonSound.SoundPath);
        }
    }
}

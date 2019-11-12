//--------------------------------------------------------------------------------
// <copyright file="GeneralEngine.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// NOMBRE: GeneralEngine.
    /// DESCRIPCION: Motor general del juego, es quien va a pasar a la siguiente pantalla cuando sea necesario
    /// o al siguiente nivel.
    /// SRP: su unica responsabilidad es mostrar la pagina siguiente, su unica razon de cambio es modificar a que pagina
    /// se quiere ir.
    /// OBSERVER: decidimos aplicar este patron para que el motor general no necesite estar preguntandole a los motores
    /// particulares cuando debera cambiar de pagina, simplemente se suscribe a los diferentes "mini motores"
    /// y cuando se necesite cambiar de pantalla estos le notificaran al motor general.
    /// </summary>
    public class GeneralEngine : IObserver
    {
        private int actualPage = 0;

        private string actualLevel;

        /// <summary>
        /// metodo que actualiza la pagina, pasa a la siguiente pantalla.
        /// </summary>
        public void Update()
        {
            if (this.actualPage < Creator.PagesUnity[this.actualLevel].Count - 1)
            {
                OneAdapter.Adapter.ShowPage(Creator.PagesUnity[this.actualLevel][this.actualPage]);
                this.actualPage += 1;
            }
            else
            {
                OneAdapter.Adapter.ShowPage(Creator.PagesUnity["Menu"][0]);
                this.actualPage = 0;
            }
        }

        /// <summary>
        /// metodo que cambia el nivel actual en el que se encuentra el juego.
        /// </summary>
        /// <param name="levelName"> nivel al que se debe cambiar. </param>
        public void ChangeLevel(string levelName)
        {
            this.actualLevel = levelName;
        }
    }
}
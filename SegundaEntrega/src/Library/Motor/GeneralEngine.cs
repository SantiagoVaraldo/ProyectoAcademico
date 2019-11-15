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
    /// </summary>
    public class GeneralEngine
    {
        private int nextPage = 0;

        private string actualLevel;

        public string ActualLevel
        {
            get
            {
                return this.actualLevel;
            }

            set
            {
                this.actualLevel = value;
            }
        }

        /// <summary>
        /// metodo que actualiza la pagina, pasa a la siguiente pantalla.
        /// </summary>
        public void Update()
        {
            if (this.nextPage < this.getPagesLength())
            {
                OneAdapter.Adapter.ShowPage(this.getNextPage());
                this.nextPage += 1;
            }
            else
            {
                OneAdapter.Adapter.ShowPage(Creator.PagesUnity["Menu"][0]);
                this.nextPage = 0;
            }
        }

        public int getPagesLength()
        {
            return Creator.PagesUnity[this.actualLevel].Count - 1;
        }

        public string getNextPage()
        {
            return Creator.PagesUnity[this.actualLevel][this.nextPage];
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
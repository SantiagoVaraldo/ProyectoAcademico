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
    /// EXPERT: conoce la pagina actual y el nivel actual por lo que es quien obtiene y muestra la pagina
    /// siguiente en Unity.
    /// </summary>
    public class GeneralEngine
    {
        private int nextPage = 0;

        private string actualLevel;

        /// <summary>
        /// nivel actual.
        /// </summary>
        /// <value>string.</value>
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
            if (this.nextPage < this.GetPagesLength())
            {
                OneAdapter.Adapter.ShowPage(this.GetNextPage());
                this.nextPage += 1;
            }
            else
            {
                OneAdapter.Adapter.ShowPage(Creator.UnityPages["Menu"][0]);
                this.nextPage = 0;
            }
        }

        /// <summary>
        /// obtiene el largo de la lista con las paginas.
        /// </summary>
        /// <returns> largo. </returns>
        public int GetPagesLength()
        {
            return Creator.UnityPages[this.actualLevel].Count;
        }

        /// <summary>
        /// obtiene la pagina siguiente.
        /// </summary>
        /// <returns> pagina siguiente. </returns>
        public string GetNextPage()
        {
            return Creator.UnityPages[this.actualLevel][this.nextPage];
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
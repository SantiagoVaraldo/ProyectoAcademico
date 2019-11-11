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
        private int actualPage = 1;

        // private int actualLevel = 1;

        /// <summary>
        /// metodo que actualiza la pagina, pasa a la siguiente pantalla.
        /// </summary>
        public void Update()
        {
            if (this.actualPage < Creator.ListPages.Count - 1)
            {
                OneAdapter.Adapter.ShowPage(Creator.ListPages[this.actualPage + 1]);
                this.actualPage += 1;
            }
            else
            {
                OneAdapter.Adapter.ShowPage(Creator.ListPages[0]);
                this.actualPage = 0;
            }
        }
    }
}
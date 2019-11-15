//--------------------------------------------------------------------------------
// <copyright file="IEngineDropable.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// Interfaz utilizada por los motores del nivel 2 y 4.
    /// </summary>
    public interface IEngineDropable
    {
        /// <summary>
        /// metodo check de los motores.
        /// </summary>
        /// <param name="word"> Word para checkear. </param>
        void Check(Word word);

        /// <summary>
        /// agrega una word a una lista.
        /// </summary>
        /// <param name="word"> word que se agrega. </param>
        void AddWord(Word word);

        /// <summary>
        /// remueve la word de la lista.
        /// </summary>
        /// <param name="word"> word a remover. </param>
        void RemoveWord(Word word);

        /// <summary>
        /// obtiene la cantidad de BlankSpace que hay en una Screen.
        /// </summary>
        /// <param name="screen"> Screen en la que se calcula. </param>
        void ObtainCantDestination(Screen screen);
    }
}
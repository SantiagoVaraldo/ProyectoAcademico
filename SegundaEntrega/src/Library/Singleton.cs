//--------------------------------------------------------------------------------
// <copyright file="Singleton.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// NOMBRE: Singleton
    /// SINGLETON: clase implementada para aplicar el patron singleton, esta clase crea una instancia del objeto T, en caso
    /// de que exista ya una instancia simplemente te devuelve la misma, es usada para los motores y para World.
    /// </summary>
    /// <typeparam name="T"> tipo generico. </typeparam>
    public static class Singleton<T>
    where T : new()
    {
        private static T instance;

        /// <summary>
        /// crea una instancia del singleton o devuelve una si ya esta creada.
        /// </summary>
        /// <value>singleton.</value>
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
    }
}
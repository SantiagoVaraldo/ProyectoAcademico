//--------------------------------------------------------------------------------
// <copyright file="OneAdapter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: Adapter.
    /// DESCRIPCION: Conoce un IMainViewAdapter que estaremos usando en nuestro programa.
    /// </summary>
    public static class OneAdapter
    {
        public static IMainViewAdapter Adapter { get; set; }
    }
}
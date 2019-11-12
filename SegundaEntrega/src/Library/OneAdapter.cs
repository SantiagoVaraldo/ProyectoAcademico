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
    /// DESCRIPCION: Conoce un IMainViewAdapter que estaremos usando en nuestro programa asi como tambien
    /// un FalseAdapterContains que se usara para los tests.
    /// </summary>
    public static class OneAdapter
    {
        public static IMainViewAdapter Adapter { get; set; }
    }
}
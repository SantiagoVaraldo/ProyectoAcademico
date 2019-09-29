//--------------------------------------------------------------------------------
// <copyright file="Layout.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Proyecto.StudentsCode
{
    /// <summary>
    /// Los diferentes tipos de layout soportados.
    /// </summary>
    public enum Layout
    {
        /// <summary>
        /// Ordena los elementos en formato de grilla.
        /// </summary>
        Grid = 0,

        /// <summary>
        /// Ordena los elementos en una secuencia vertical.
        /// </summary>
        Vertical = 1,

        /// <summary>
        /// Ordena los elementos en una secuencia horizontal.
        /// </summary>
        Horizontal = 2,

        /// <summary>
        /// Permite colocar los elementos en cualquier coordenada.
        /// </summary>
        ContentSizeFitter = 3,
    }
}

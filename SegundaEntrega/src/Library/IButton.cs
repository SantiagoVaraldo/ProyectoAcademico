using System;
using Proyecto.Common;

/// <summary>
/// interfaz IButton con la firma Action(se utiliza para que cada tipo de boton tenga una accion particular).
/// </summary>

namespace Library
{
    public interface IButton
    {
        void Action(IMainViewAdapter adapter);
    }
}
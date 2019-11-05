//--------------------------------------------------------------------------------
// <copyright file="DragAndDropDestination.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: DragAndDropDestination.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos DragAndDropDestination
    /// es de tipo Element.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos DragAndDropDestination.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de DragAndDropDestination, su unica razon de cambio es modificar los datos que guardamos sobre DragAndDropDestination.
    /// HERENCIA: Esta clase hereda de la clase ancestra Element
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que un DragAndDropDestination debe pertenecer a una Screen
    /// y es de tipo Element.
    /// </summary>
    public class DragAndDropDestination : Element
    {
        public DragAndDropDestination(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
        }
    }
}
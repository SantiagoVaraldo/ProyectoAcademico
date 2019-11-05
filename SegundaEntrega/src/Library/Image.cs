//--------------------------------------------------------------------------------
// <copyright file="Image.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: Image.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a las imagenes.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos Image.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de Image, su unica razon de cambio es modificar los datos que guardamos sobre la imagen.
    /// HERENCIA: esta clase hereda de la clase mas general Element, de momento la imagen va a heredar todo de elemento
    /// y no agrega comportamiento ni atributos extras.(optamos pr herencia en lugar de composicion ya que necesitabamos
    /// todo los datos de Element y no ibamos a crear comportamiento)
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que una imagen debe pertenecer a una Screen y ademas
    /// es de tipo Element.
    /// </summary>
    public class Image : Element
    {
        public Image(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
        }

        /// <summary>
        /// metodo que permite al objeto de tipo Image renderizarce a si mismo en Unity.
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce. </param>
        public override void Render(IMainViewAdapter adapter)
        {
            string imageId = adapter.CreateImage((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            adapter.SetImage(imageId, this.ImagePath);
        }
    }
}

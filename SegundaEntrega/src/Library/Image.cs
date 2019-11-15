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
    /// es de tipo Element. Tambien colabora con la Interfaz IRenderer para dibujar el elemento correspondiente en Unity.
    /// </summary>
    public class Image : Element
    {
        /// <summary>
        /// constructor de la imagen.
        /// </summary>
        /// <param name="name">nombre.</param>
        /// <param name="positionY">posicion Y.</param>
        /// <param name="positionX">posicion X.</param>
        /// <param name="length">largo.</param>
        /// <param name="width">ancho.</param>
        /// <param name="screen">Screen a la que pertenece la imagen.</param>
        /// <param name="imagePath">imagen que posee el objeto.</param>
        public Image(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
        }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la interfaz IRenderer para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> IRenderer al que se le delega la responsabilidad. </param>
        public override void Render(IRenderer renderer)
        {
            renderer.RenderImage(this);
        }
    }
}

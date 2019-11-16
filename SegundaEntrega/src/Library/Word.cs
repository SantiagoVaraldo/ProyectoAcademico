//--------------------------------------------------------------------------------
// <copyright file="Word.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: Word.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos Word,
    /// es de tipo DragAndDropItem.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de Word, su unica razon de cambio es modificar los datos que guardamos sobre word.
    /// HERENCIA: Esta clase hereda de la clase ancestra DragAndDropItem
    /// COLABORACIONES: Colabora con la clase DragAndDropItem y Screen, debe pertenecer a una Screen
    /// y es de tipo DragAndDropItem, ademas colabora con DragAndDropSource y BlankSpace ya que un item debe
    /// conocer un Source y un Destination. Tambien colabora con la Interfaz IRenderer para dibujar el elemento correspondiente en Unity.
    /// COMENTARIOS: el metodo OnDrop no deberia de estar en la clase Word. De esta manera estamos dejando
    /// acoplado nuestro modelo con Unity, lo cual no queriamos que pase.
    /// La manera de solucionar este problema es que el metodo este en el EngineLvl2, que es quien colabora
    /// con el adapter, para poder hacer esto debiamos de cambiar nuestros motores para que estos conozcan
    /// el nivel que se esta jugando de alguna manera, no lo logramos hacer ya que cuando nos dimos cuenta de este
    /// error no contabamos con el tiempo suficiente para poder modificar los motores y los tests.
    /// </summary>
    public class Word : DragAndDropItem
    {
        /// <summary>
        /// constructor de la clase Word.
        /// </summary>
        /// <param name="name">nombre.</param>
        /// <param name="positionY">posicion Y.</param>
        /// <param name="positionX">posicion X.</param>
        /// <param name="length">largo.</param>
        /// <param name="width">ancho.</param>
        /// <param name="screen">pantalla a la que pertenece.</param>
        /// <param name="imagePath">imagen que posee.</param>
        /// <param name="source">fuente.</param>
        /// <param name="destination">destino.</param>
        public Word(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath, DragAndDropSource source, BlankSpace destination)
        : base(name, positionY, positionX, length, width, screen, imagePath, source, destination)
        {
        }

        /// <summary>
        /// este ItemId corresponde a la referencia del Word una vez creado.
        /// </summary>
        /// <value> itemId. </value>
        public string ItemId { get; set; }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la interfaz IRenderer para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> IRenderer al que se le delega la responsabilidad. </param>
        public override void Render(IRenderer renderer)
        {
            renderer.RenderWord(this);
        }

        /// <summary>
        /// metodo que mueve al elemento a la nueva posicion si esta es un source o un destination o lo deja en su
        /// posicion actual en caso contrario.
        /// </summary>
        /// <param name="elementName"> nombre del elemento. </param>
        /// <param name="x"> posicion x. </param>
        /// <param name="y"> posicion y. </param>
        public void OnDrop(string elementName, float x, float y)
        {
            if (elementName == this.ItemId)
            {
                EngineLvl2 engineLvl2 = Singleton<EngineLvl2>.Instance;
                engineLvl2.Check(this);
                OneAdapter.Adapter.Debug($"Drop '{elementName}' {x}@{y}");

                if (OneAdapter.Adapter.Contains(this.Destination.DestinationCellImageId, x, y))
                {
                    // Mueve el elemento arrastrado al destino si se suelta arriba del destino
                    OneAdapter.Adapter.Center(elementName, this.Destination.DestinationCellImageId);
                    engineLvl2.AddWord(this);
                }
                else
                {
                    // Mueve el elemento arrastrado nuevamente al origen en caso contrario
                    OneAdapter.Adapter.Center(elementName, this.Source.SourceCellImageId);
                    engineLvl2.RemoveWord(this);
                }

                if (engineLvl2.NextLevel(this))
                {
                    engineLvl2.Reset(this.Screen);
                }
            }
        }
    }
}
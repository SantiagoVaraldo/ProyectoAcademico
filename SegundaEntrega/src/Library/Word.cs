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
    /// </summary>
    public class Word : DragAndDropItem
    {
        public Word(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath, DragAndDropSource source, BlankSpace destination)
        : base(name, positionY, positionX, length, width, screen, imagePath, source, destination)
        {
        }

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
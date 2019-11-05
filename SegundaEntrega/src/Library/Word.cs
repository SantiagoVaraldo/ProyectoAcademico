
using System;
using Proyecto.Common;

/// <summary>
/// NOMBRE: Word.
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos Word,
/// es de tipo DragAndDropItem.
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Word, su unica razon de cambio es modificar los datos que guardamos sobre word.
/// HERENCIA: Esta clase hereda de la clase ancestra DragAndDropItem
/// COLABORACIONES: Colabora con la clase DragAndDropItem y Screen ya que un Word debe pertenecer a una Screen
/// y es de tipo DragAndDropItem.
/// </summary>

namespace Library
{
    public class Word : DragAndDropItem
    {
        string itemId;
        public Word(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath, DragAndDropSource source, BlankSpace destination)
        : base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath, source, destination)
        {
        }

        /// <summary>
        /// metodo que permite al objeto de tipo DragAndDropItem renderizarce a si mismo en Unity
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce </param>
        public override void Render(IMainViewAdapter adapter)
        {
            itemId = adapter.CreateImage((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            adapter.SetImage(itemId, this.ImagePath);
            adapter.MakeDraggable(itemId, true);
            OneAdapter.Adapter.OnDrop += this.OnDrop;
            OneAdapter.Adapter.Center(this.itemId, this.Source.sourceCellImageId);

            //adapter.SetImage(itemId, this.ImagePath);
        }

        /// <summary>
        /// metodo que mueve al elemento a la nueva posicion si esta es un source o un destination o lo deja en su
        /// posicion actual en caso contrario
        /// </summary>
        /// <param name="elementName"> nombre del elemento </param>
        /// <param name="x"> posicion x </param>
        /// <param name="y"> posicion y </param>
        private void OnDrop(string elementName, float x, float y)
        {
            IObserver generalEngine = Singleton<GeneralEngine>.Instance;
            EngineLvl2 engineLvl2 = Singleton<EngineLvl2>.Instance;
            engineLvl2.Subscribe(generalEngine);
            engineLvl2.Check(this);
            OneAdapter.Adapter.Debug($"Drop '{elementName}' {x}@{y}");

            if (elementName == this.itemId && OneAdapter.Adapter.Contains(this.Destination.destinationCellImageId, x, y))
            {
                // Mueve el elemento arrastrado al destino si se suelta arriba del destino
                OneAdapter.Adapter.Center(elementName, this.Destination.destinationCellImageId);
                engineLvl2.AddWord(this);
            }
            else if (elementName == this.itemId)
            {
                // Mueve el elemento arrastrado nuevamente al origen en caso contrario
                OneAdapter.Adapter.Center(elementName, this.Source.sourceCellImageId);
                engineLvl2.RemoveWord(this);
            }
            engineLvl2.NextLevel(this);
        }

        public bool CheckPosition()
        {
            return this.PositionY == this.Destination.PositionY & this.PositionX == this.Destination.PositionX;
        }

        public bool CheckPositionReversed()
        {
            return word.PositionY != word.Destination.PositionY || word.PositionX != word.Destination.PositionX;
        }
    }
}
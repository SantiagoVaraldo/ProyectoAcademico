using System;
using Proyecto.Common;

/// <summary>
/// NOMBRE: BlanckSpace.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos BlanckSpace,
/// es de tipo DragAndDropDestination.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de BlanckSpace, su unica razon de cambio es modificar los datos que guardamos sobre BlanckSpace.
/// 
/// HERENCIA: Esta clase hereda de la clase ancestra DragAndDropDestination
/// 
/// COLABORACIONES: Colabora con la clase DragAndDropDestination y Screen ya que un BlanckSpace debe pertenecer a una Screen 
/// y es de tipo DragAndDropDestination.
/// </summary>

namespace Library
{
    public class BlanckSpace : DragAndDropDestination
    {
        public string destinationCellImageId;
        public BlanckSpace(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        : base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
            this.Filled = false;
        }

        private bool filled;
        public bool Filled 
        {
            get
            {
                return this.filled; 
            }
            set
            {
                this.filled = value;
            }
        }

        public void Fill()
        {
            this.Filled = true;
        }

        public void Unfill()
        {
            this.Filled = false;
        }
        /// <summary>
        /// metodo que permite al objeto de tipo BlanckSpace renderizarce a si mismo en Unity
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce </param>
        public override void Render(IMainViewAdapter adapter)
        {
            destinationCellImageId = adapter.CreateImage((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            adapter.SetImage(destinationCellImageId, this.ImagePath);
        }

    }
}
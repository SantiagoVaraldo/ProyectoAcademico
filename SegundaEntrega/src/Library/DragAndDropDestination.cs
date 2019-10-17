using System;
using Proyecto.Common;

namespace Library
{
    public class DragAndDropDestination : Element
    {
        public DragAndDropDestination(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
        public override void Render(IMainViewAdapter adapter)
        {
            string destinationCellImageId = adapter.CreateDragAndDropDestination((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            //adapter.SetImage(destinationCellImageId, this.ImagePath);
        }
    }
}
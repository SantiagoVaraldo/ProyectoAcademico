using System;
using Proyecto.Common;

namespace Library
{
    public class DragAndDropSource : Element
    {
        public DragAndDropSource(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
        public override void Render(IMainViewAdapter adapter)
        {
            string sourceCellImageId = adapter.CreateDragAndDropSource((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            adapter.SetImage(sourceCellImageId, this.ImagePath);
        }
    }
}
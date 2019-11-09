//--------------------------------------------------------------------------------
// <copyright file="OneAdapter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using Proyecto.Common;
using System;

namespace Library
{
    /// <summary>
    /// NOMBRE: Adapter.
    /// DESCRIPCION: Conoce un IMainViewAdapter que estaremos usando en nuestro programa.
    /// </summary>
    public class FalseAdapter : IMainViewAdapter
    {

        public BeginDrawEvent OnBeginDraw { get; set; }
        public EndDrawEvent OnEndDraw { get; set; }
        public DrawingEvent OnDrawing { get; set; }
        public DropEvent OnDrop { get; set; }

        
        public void ToDoAfterBuild(Action action)
        {

        }
        public Action AfterBuild { get; set; }

        public float WorldWidth { get; }

        public float WorldHeight { get; }
        public string AddPage()
        {
            throw new Exception();
        }
        public void ShowPage(string pageName)
        {

        }

        public void ChangeLayout(Layout layout)
        {

        }
        public void ChangeLayout(string itemName, Layout layout)
        {

        }

        public string CreateButton(float x, float y, float width, float height, string color, Action<string> onClick)
        {
            throw new Exception();
        }

        public string CreateDragAndDropSource(float x, float y, float width, float height)
        {
            throw new Exception();
        }
        
        
        public string CreateDragAndDropDestination(float x, float y, float width, float height)
        {
            throw new Exception();
        }
       
        
        public string CreateDragAndDropItem(float x, float y, float width, float height)
        {
            throw new Exception();
        }

    
        
        public void AddItemToDragAndDropSource(string itemName, string destinationName)
        {

        }
    
        public string CreateImage(float x, float y, float width, float height)
        {
            throw new Exception();
        }

        
        public string CreateInputField(float x, float y, float width, float height, Action<string, string> onChange,
            Action<string, string> onEdited)
        {
            throw new Exception();
        }
        

        public string CreateToggle(float x, float y, float width, float height, Action<string, bool> onChange)
        {
            throw new Exception();
        }
        public string CreateLabel(float x, float y, float width, float height)
        {
            throw new Exception();
        }
        public string CreateAny(float x, float y, float width, float height, string anyName)
        {
            throw new Exception();
        }
        public void Debug(string message)
        {

        }
        public void SetParent(string childName, string parentName)
        {

        }
        public void SetParentAndCenter(string childName, string parentName)
        {

        }
        public void Center(string thisElement, string intoThisElement)
        {

        }
        public void SetImage(string elementName, string resourceName)
        {

        }
        public string GetText(string elementName)
        {
            throw new Exception();
        }
        public void SetText(string elementName, string value)
        {

        }
        public bool GetCheckedState(string elementName)
        {
            throw new Exception();
        }
        public void SetCheckedState(string elementName, bool value)
        {

        }
        public void PlayAudio(string fileName)
        {

        }
        public void SetDrawingRect(float x, float y, float width, float height)
        {

        }
        public void RemoveDrawingRect()
        {

        }
        public void SetFont(string elementName, bool? bold, bool? italic, int? size)
        {

        }
        public void MakeDraggable(string elementName, bool toggle)
        {

        }
        public bool Contains(string elementName, float x, float y)
        {
            throw new Exception();
        }
        public string GetWorkingFolder(bool readWrite = false)
        {
            throw new Exception();
        }
    }
}

//--------------------------------------------------------------------------------
// <copyright file="FalseAdapterContain.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using Proyecto.Common;
using System;

namespace Library
{
    /// <summary>
    /// NOMBRE: FalseAdapterContain.
    /// DESCRIPCION: Clase creada unicamente para utilizarla en los test como resultado verdadero o falso
    /// del metodo Contain del adapter.
    /// </summary>
    public class FalseAdapterContain : IMainViewAdapter
    {
        private bool contain;

        public FalseAdapterContain(bool contain)
        {
            this.Contain = contain;
        }

        public BeginDrawEvent OnBeginDraw { get; set; }

        public EndDrawEvent OnEndDraw { get; set; }

        public DrawingEvent OnDrawing { get; set; }

        public DropEvent OnDrop { get; set; }

        public bool Contain { get; set; }


        public void ToDoAfterBuild(Action action)
        {
            // intencionalmente en blanco.
        }

        public Action AfterBuild { get; set; }

        public float WorldWidth { get; }

        public float WorldHeight { get; }

        public string AddPage()
        {
            throw new Exception();
        }

        public string GetFileContents(string fileName)
        {
            throw new Exception();
        }

        public void SetActive(string element, bool active)
        {
            // intencionalmente en blanco.
        }

        public void SetText(string elementName, string value, bool wrap = false)
        {
            // intencionalmente en blanco.
        }

        public void ShowPage(string pageName)
        {
            // intencionalmente en blanco.
        }

        public void ChangeLayout(Layout layout)
        {
            // intencionalmente en blanco.
        }

        public void ChangeLayout(string itemName, Layout layout)
        {
            // intencionalmente en blanco.
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
            // intencionalmente en blanco.
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
            // intencionalmente en blanco.
        }

        public void SetParent(string childName, string parentName)
        {
            // intencionalmente en blanco.
        }

        public void SetParentAndCenter(string childName, string parentName)
        {
            // intencionalmente en blanco.
        }

        public void Center(string thisElement, string intoThisElement)
        {
            // intencionalmente en blanco.
        }
        
        public void SetActive(string elementName, bool boolean)
        {

        }

        public void SetImage(string elementName, string resourceName)
        {
            // intencionalmente en blanco.
        }

        public string GetFileContents(string fileName)
        {
            throw new Exception();
        }

        public string GetText(string elementName)
        {
            throw new Exception();
        }

        public void SetText(string elementName, string value)
        {
            // intencionalmente en blanco.
        }

         public void SetText(string elementName, string value, bool boolean)
        {

        }

        public bool GetCheckedState(string elementName)
        {
            throw new Exception();
        }

        public void SetCheckedState(string elementName, bool value)
        {
            // intencionalmente en blanco.
        }

        public void PlayAudio(string fileName)
        {
            // intencionalmente en blanco.
        }

        public void SetDrawingRect(float x, float y, float width, float height)
        {
            // intencionalmente en blanco.
        }

        public void RemoveDrawingRect()
        {
            // intencionalmente en blanco.
        }

        public void SetFont(string elementName, bool? bold, bool? italic, int? size)
        {
            // intencionalmente en blanco.
        }

        public void MakeDraggable(string elementName, bool toggle)
        {
            // intencionalmente en blanco.
        }

        public bool Contains(string elementName, float x, float y)
        {
            return this.Contain;
        }

        public string GetWorkingFolder(bool readWrite = false)
        {
            throw new Exception();
        }
    }
}

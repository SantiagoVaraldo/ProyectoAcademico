//--------------------------------------------------------------------------------
// <copyright file="FilterWord.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
    /// <summary>
    /// NOMBRE: FilterWord
    /// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un objeto Word.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto Word en caso
    /// de que el nombre del Tag sea el correspondiente, su unica razon de cambio es modificar como se debe filtrar.
    /// PATRON EXPERT: Conoce el filtro que se va a aplicar y el resultado de aplicar ese filtro.
    /// PATRON CREATOR: los objetos son creados en el filtro, el filtro no es el experto en conocer todo lo necesario para
    /// crear dicho objeto, sin embargo al intentar cumplir con el patron aparecian otras dificultades mayores
    /// (cuando llamamos al metodo Add del IContainer, es ahi donde deberia instanciarse el objeto ya que el contenedor
    /// si conoce los datos necesarios)
    /// PRINCIPIO OCP: la creacion de pipes and filters cumple con el principio de OCP, si tenemos un nuevo elemento
    /// simplemente agregamos un nuevo filtro y un pipe extra. El codigo queda abierto a la extencion pero cerrado a la
    /// modificacion ya que no se debera modificar los pipes and filters ya creados.
    /// CHAIN RESPONSiBILITY: esta clase es parte de la cadena de Pipes And Filters.
    /// </summary>
    public class FilterWord : IFilterConditional
    {
        private bool result;

        public bool Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// filtra el Tag recibido.
        /// </summary>
        /// <param name="tag">Tag a filtrar.</param>
        /// <returns>retorna el Tag.</returns>
        public Tag Filter(Tag tag)
        {
            if (tag.Name == "Word")
            {
                this.Result = true;

                string name;
                int positionY, positionX;
                int length, width;
                string imagePath;

                try
                {
                    Visitor visitor = new VisitorWorld();
                    visitor.Visit(Creator.World);

                    name = tag.ListaAtributos["Name"].Valor;
                    positionY = Int32.Parse(tag.ListaAtributos["PositionY"].Valor);
                    positionX = Int32.Parse(tag.ListaAtributos["PositionX"].Valor);
                    length = Int32.Parse(tag.ListaAtributos["Length"].Valor);
                    width = Int32.Parse(tag.ListaAtributos["Width"].Valor);

                    imagePath = tag.ListaAtributos["ImagePath"].Valor;

                    IXML word = new Word(name, positionY, positionX, length, width, visitor.LastScreen, imagePath, (DragAndDropSource)visitor.BeforeLastElement, (BlankSpace)visitor.LastElement);
                    visitor.LastScreen.Add(word);
                }
                catch (NotFoundOnXMLException)
                {
                    // Mostrar en pantalla que no se encontro lo deseado en xml
                }
            }
            else
            {
                this.Result = false;
            }

            return tag;
        }
    }
}
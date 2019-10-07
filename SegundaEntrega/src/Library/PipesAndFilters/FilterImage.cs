using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;
using System.IO;

/// <summary>
/// NOMBRE: FilterImage.
/// 
/// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un objeto Image.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto Image en caso
/// de que el nombre del Tag sea el correspondiente, su unica razon de cambio es modificar que es lo que necesita una Image
/// para ser creada.
/// 
/// PATRON EXPERT: Conoce el filtro que se va a aplicar y el resultado de aplicar ese filtro.
/// 
/// PATRON CREATOR: los objetos son creados en el filtro, el filtro no es el experto en conocer todo lo necesario para 
/// crear dicho objeto, sin embargo al intentar cumplir con el patron aparecian otras dificultades mayores
/// (cuando llamamos al metodo Add del IContainer, es ahi donde deberia instanciarse el objeto ya que el contenedor
/// si conoce los datos necesarios)
/// 
/// CHAIN RESPONSiBILITY: esta clase es parte de la cadena de Pipes And Filters.
/// </summary>

namespace Library
{
    public class FilterImage : IFilterConditional
    {
        private bool result;
        public bool Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// filtra el Tag recibido
        /// </summary>
        /// <param name="tag">Tag a filtrar</param>
        /// <returns>retorna el mismo Tag</returns>
        public Tag Filter(Tag tag)
        {
            if (tag.Name == "Image")
            {
                this.Result = true;
                IXML image = new Image(tag.ListaAtributos["Name"].Valor, Int32.Parse(tag.ListaAtributos["PositionY"].Valor), Int32.Parse(tag.ListaAtributos["PositionX"].Valor), Int32.Parse(tag.ListaAtributos["Length"].Valor), Int32.Parse(tag.ListaAtributos["Width"].Valor), Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen.Count - 1], tag.ListaAtributos["ImagePath"].Valor);
                Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen.Count - 1].Add(image);
            }
            else
            {
                this.Result = false;
            }
            return tag;

        }
    }
}
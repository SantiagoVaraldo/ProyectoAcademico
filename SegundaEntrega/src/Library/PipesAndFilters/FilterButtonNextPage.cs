using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;
using System.IO;

/// <summary>
/// NOMBRE: FilterButtonNextPage.
/// 
/// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un objeto ButtonNextPage.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto ButtonNextPage en caso
/// de que el nombre del Tag sea el correspondiente, su unica razon de cambio es modificar como se debe filtrar.
/// 
/// PATRON EXPERT: Conoce el filtro que se va a aplicar y el resultado de aplicar ese filtro.
/// 
/// PATRON CREATOR: los objetos son creados en el filtro, el filtro no es el experto en conocer todo lo necesario para 
/// crear dicho objeto, sin embargo al intentar cumplir con el patron aparecian otras dificultades mayores
/// (cuando llamamos al metodo Add del IContainer, es ahi donde deberia instanciarse el objeto ya que el contenedor
/// si conoce los datos necesarios)
/// 
/// PRINCIPIO OCP: la creacion de pipes and filters cumple con el principio de OCP, si tenemos un nuevo elemento
/// simplemente agregamos un nuevo filtro y un pipe extra. El codigo queda abierto a la extencion pero cerrado a la
/// modificacion ya que no se debera modificar los pipes and filters ya creados.
/// 
/// CHAIN RESPONSiBILITY: esta clase es parte de la cadena de Pipes And Filters.
/// </summary>

namespace Library
{
    public class FilterButtonNextPage : IFilterConditional
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
        /// <returns>retorna el Tag</returns>
        public Tag Filter(Tag tag)
        {
            if (tag.Name == "ButtonNextPage")
            {
                this.Result = true;

                string name = tag.ListaAtributos["Name"].Valor;
                int positionY = Int32.Parse(tag.ListaAtributos["PositionY"].Valor);
                int positionX = Int32.Parse(tag.ListaAtributos["PositionX"].Valor);
                int length = Int32.Parse(tag.ListaAtributos["Length"].Valor);
                int width = Int32.Parse(tag.ListaAtributos["Width"].Valor);
                Screen screen = Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen.Count - 1];
                string imagePath = tag.ListaAtributos["ImagePath"].Valor; 

                IXML button = new ButtonNextPage(name, positionY, positionX, length, width, screen, imagePath);
                Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen.Count - 1].Add(button);
            }
            else
            {
                this.Result = false;
            }
            return tag;

        }
    }
}
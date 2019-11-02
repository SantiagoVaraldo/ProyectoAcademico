using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;
using System.IO;

/// <summary>
/// NOMBRE: FilterImage.
/// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un objeto Image.
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto Image en caso
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

                try
                {
                    string name = tag.ListaAtributos["Name"].Valor;
                    int positionY = Int32.Parse(tag.ListaAtributos["PositionY"].Valor);
                    int positionX = Int32.Parse(tag.ListaAtributos["PositionX"].Valor);
                    int length = Int32.Parse(tag.ListaAtributos["Length"].Valor);
                    int width = Int32.Parse(tag.ListaAtributos["Width"].Valor);

                    int lastLevelId = Creator.world.ListLevel.Count - 1;
                    Level level = Creator.world.ListLevel[lastLevelId];
                    int lastScreenId = level.ListaScreen.Count - 1;
                    Screen screen = level.ListaScreen[lastScreenId];
                    string imagePath = tag.ListaAtributos["ImagePath"].Valor;

                    IXML image = new Image(name, positionY, positionX, length, width, screen, imagePath);
                    screen.Add(image);
                }
                catch (NotFoundOnXML)
                {
                    
                    //Mostrar en pantalla que no se encontro lo deseado en xml
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
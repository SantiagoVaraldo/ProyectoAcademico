using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

/// <summary>
/// NOMBRE: FilterScreen.
/// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un objeto Screen.
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto Screen en caso
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
    public class FilterScreen : IFilterConditional
    {
        private bool result;
        public bool Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// filtra un tag recibido por parametros
        /// </summary>
        /// <param name="tag">Tag a filtrar</param>
        /// <returns>Tag</returns>
        public Tag Filter(Tag tag)
        {
            if (tag.Name == "Screen")
            {
                this.Result = true;

                string name;

                try
                {
                    Visitor visitor = new VisitorWorld();
                    visitor.Visit(Creator.world);
                    name = tag.AttributeList["Name"].Value;

                    IXML screen = new Screen(name, visitor.lastLevel);
                    visitor.lastLevel.Add(screen);
                }
                catch (System.Exception)
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
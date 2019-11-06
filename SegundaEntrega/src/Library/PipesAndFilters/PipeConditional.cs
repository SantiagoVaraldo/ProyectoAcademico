//--------------------------------------------------------------------------------
// <copyright file="PipeConditional.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using ExerciseOne;
using Library;

namespace Library
{
    /// <summary>
    /// NOMBRE: PipeConditional.
    /// DESCRIPCION: Esta clase se encarga de conocer un filtro y dos pipes siguientes.
    /// PATRON EXPERT: Conoce el filtro que se va a aplicar y conoce el pipe siguiente por lo que le asignamos el metodo Send
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es aplicarle el filtro al tag
    /// y enviarlo al siguiente pipe, su unica razon de cambio es modificar la logica del metodo send, es decir modificar
    /// en que nos basamos para enviar el tag por un pipe o por otro.
    /// CHAIN RESPONSiBILITY: decidimos solucionar el problema de crear objetos a partir de una lista de tags utilizando
    /// este patron, para eso creamos una secuencia de Pipes And Filters donde mandamos cada tag por la cañeria.
    /// PRINCIPIO OCP: la creacion de pipes and filters cumple con el principio de OCP, si tenemos un nuevo elemento
    /// simplemente agregamos un nuevo filtro y un pipe extra. El codigo queda abierto a la extencion pero cerrado a la
    /// modificacion ya que no se debera modificar los pipes and filters ya creados.
    /// COLABORACIONES: Colabora con la interfaz IFilterConditional y con la interfaz IPipe, conoce un filtro de tipo
    /// IFilterConditional y el pipe es de tipo IPipe.
    /// COMENTARIO: a efectos de lo que buscamos con los pipes and filters podria no ser necesario utilizar pipes, solo encadenando
    /// filtros seria suficiente, sin embargo decidimos hacerlo de esta manera para aplicar el patron tal y como lo vimos en clase.
    /// </summary>
    public class PipeConditional : IPipe
    {
        private IPipe truePipe;
        private IPipe falsePipe;
        private IFilterConditional filter;

        public PipeConditional(IFilterConditional filter, IPipe truePipe, IPipe falsePipe)
        {
            this.truePipe = truePipe;
            this.falsePipe = falsePipe;
            this.filter = filter;
        }

        /// <summary>
        /// metodo de la interfaz IPipe, envia un Tag a otro pipe.
        /// </summary>
        /// <param name="tag"> tag que se envia al siguiente pipe. </param>
        /// <returns> devuelve el Tag. </returns>
        public Visitor Send(Tag tag)
        {
            Visitor filteredVisitor = this.filter.Filter(tag);
            Visitor resultVisitor;
            if (this.filter.Result)
            {
                resultVisitor = this.truePipe.Send(tag);
            }
            else
            {
                resultVisitor = this.falsePipe.Send(tag);
            }

            return filteredVisitor;
        }
    }
}
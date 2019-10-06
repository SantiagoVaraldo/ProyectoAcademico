using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

/// <summary>
/// esta interfaz es de tipo IXML, contiene la firma Add la cual hace que todas las clases que implementan esta
/// interfaz, deban tener un metodo Add donde no se sabe que tipo de objeto es el que recibe por parametros el metodo.
/// cuando se llama a este metodo en los filtros se hace uso de polimorfismo ya que no se sabe de que tipo es el parametro 
/// </summary>

namespace Library
{
    public interface IContainer : IXML 
    {
        void Add(IXML ixml);
    }
}
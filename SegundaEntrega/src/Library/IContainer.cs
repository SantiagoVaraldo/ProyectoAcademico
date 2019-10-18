using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

/// <summary> 
/// esta interfaz es de tipo IXML, contiene la firma Add la cual hace que todas las clases que implementan esta
/// interfaz, deban tener un metodo Add.
/// </summary>

namespace Library
{
    public interface IContainer : IXML 
    {
        void Add(IXML ixml);
    }
}
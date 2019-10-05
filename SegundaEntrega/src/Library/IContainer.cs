using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
    public interface IContainer : IXML 
    {
        IXML Add(Dictionary<string, Attribute> dictionary, IContainer container);
    }
}
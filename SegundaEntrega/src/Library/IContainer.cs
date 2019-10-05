using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
    public interface IContainer
    {
        void Add(Dictionary<string, Attribute> dictionary, IContainer container);
    }
}
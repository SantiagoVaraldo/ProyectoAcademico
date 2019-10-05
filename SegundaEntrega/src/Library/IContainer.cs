using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
    public interface IContainer : IXML 
    {
        void Add(IXML ixml);
    }
}
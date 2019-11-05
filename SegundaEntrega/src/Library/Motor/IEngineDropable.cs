using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
    public interface IEngineDropable
    {
        void Check(Word word);
        void AddWord(Word word);
        void RemoveWord(Word word);
        void ObtainCantDestination(Word word);
    }
}
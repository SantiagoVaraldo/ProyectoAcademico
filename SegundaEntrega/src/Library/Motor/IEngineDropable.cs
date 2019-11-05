//--------------------------------------------------------------------------------
// <copyright file="IEngineDropable.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Proyecto.Common;

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
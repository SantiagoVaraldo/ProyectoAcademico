﻿using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
    public class ControllerLetter : IController
    {
        public List<string> listPages {get;set;}
        private IMainViewAdapter adapter;
        public IMainViewAdapter Adapter
        {
            get
            {
                return this.adapter;
            }
            set
            {
                this.adapter = value;
            }
        }
        public ControllerLetter(IMainViewAdapter adapter, List<string> listpages)
        {
            this.Adapter = adapter;
            this.listPages = listpages;
        }
       /*  public void CheckRigth(Letter letter)
        {
            if (letter.Rigth)
            {
                this.adapter.ShowPage(this.listPages[1]);
            }
            else
            {
                this.adapter.Debug($"Esa no es la letra correcta, vuelve a intentar");
            }
        }
        */
    }
}

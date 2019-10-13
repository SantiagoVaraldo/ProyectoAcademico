using System;
using Proyecto.Common;
using Library;
using System.Collections.Generic;

namespace Library
{
         public class Action
         {
                  public Action(IMainViewAdapter Adapter, string FirstPageName, string NextPageName)
                  {
                           this.Adapter = Adapter;
                           this.FirstPageName = FirstPageName;
                           this.NextPageName = NextPageName;
                  }
                  private IMainViewAdapter adapter;
                  private string firstPageName;
                  private string nextPageName;
                  public IMainViewAdapter Adapter
                  {
                           get
                           {
                                    return this.adapter;
                           }
                           set
                           {
                                    if (value != null)
                                    {
                                             this.adapter = value;
                                    }
                           }
                  }
                  public string FirstPageName
                  {
                           get
                           {
                                    return this.firstPageName;
                           }
                           set
                           {
                                    if (value != null)
                                    {
                                             this.firstPageName = value;
                                    }
                           }
                  }
                  public string NextPageName
                  {
                           get
                           {
                                    return this.nextPageName;
                           }
                           set
                           {
                                    if (value != null)
                                    {
                                             this.nextPageName = value;
                                    }
                           }
                  }
                  public void AfterBuildShowFirstPage()
                  {
                           this.adapter.ShowPage(this.firstPageName);
                  }

                  private void GoToFirstPage()
                  {
                           this.adapter.ShowPage(this.firstPageName);
                           //this.adapter.PlayAudio("Speech On.wav");
                  }

                  private void GoToNextPage()
                  {
                           this.adapter.ShowPage(this.nextPageName);
                           //this.adapter.PlayAudio("Speech Off.wav");
                  }

                  private void OnClick()
                  {
                           this.adapter.Debug($"Button clicked!");
                           //this.adapter.ShowPage("MainPage");
                  }

         }
}
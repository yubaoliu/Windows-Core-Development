﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace USBdetection.ViewModels
{
  public class MainWindowViewModel : BindableBase
  {
    private string _title = "Prism Unity Application";
    public string Title
    {
      get { return _title; }
      set { SetProperty(ref _title, value); }
    }

    public MainWindowViewModel()
    {

    }
  }
}

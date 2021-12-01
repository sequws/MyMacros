using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shell.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        public string Hello { get; set; } = "Welcome in MyMacros!";

        public HomeViewModel()
        {

        }
    }
}

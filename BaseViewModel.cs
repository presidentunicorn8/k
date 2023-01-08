﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace KpopComebacks.ViewModel
{
        public partial class BaseViewModel : ObservableObject
        {
            [ObservableProperty]
            [AlsoNotifyChangeFor(nameof(IsNotBusy))]
            bool isBusy;

            [ObservableProperty]
            string title;

            public bool IsNotBusy => !IsBusy;
        }
    }

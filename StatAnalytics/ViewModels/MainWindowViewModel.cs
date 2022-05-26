﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatAnalytics.ViewModels.Base;

namespace StatAnalytics.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {


        #region Заголовок окна
        private string _Title = "StatAnalytics";
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        } 
        #endregion



    }
}
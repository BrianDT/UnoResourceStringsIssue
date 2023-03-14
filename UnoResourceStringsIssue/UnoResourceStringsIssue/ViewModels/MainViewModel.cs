// <copyright file="MainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023 All rights reserved</copyright>

namespace UnoResourceStringsIssue.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UnoResourceStringsIssue.Services;

    /// <summary>
    /// The main view model.
    /// </summary>
    internal class MainViewModel : IMainViewModel
    {
        private IStringResourceServices stringResourceServices;

        private bool showingAltText;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel(IStringResourceServices stringResourceServices) 
        {
            this.stringResourceServices = stringResourceServices;

            this.ParaText = stringResourceServices.FindNLString("ParaText");

        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the paragraph text.
        /// </summary>
        public string ParaText { get; private set; }

        /// <summary>
        /// Switch the paragraph text to the alternative text and back again.
        /// </summary>
        public void FlipText()
        {
            var textkey = "AltText";
            if (this.showingAltText)
            {
                textkey = "ParaText";
            }

            this.ParaText = stringResourceServices.FindNLString(textkey);
            this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(this.ParaText)));
            this.showingAltText = !this.showingAltText;
        }
    }
}

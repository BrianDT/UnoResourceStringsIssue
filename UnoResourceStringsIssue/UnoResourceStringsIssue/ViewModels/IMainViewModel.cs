// <copyright file="IMainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023 All rights reserved</copyright>

namespace UnoResourceStringsIssue.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// The main view model.
    /// </summary>
    public interface IMainViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the paragraph text.
        /// </summary>
        string ParaText { get; }

        /// <summary>
        /// Switch the paragraph text to the alternative text and back again.
        /// </summary>
        void FlipText();
    }
}

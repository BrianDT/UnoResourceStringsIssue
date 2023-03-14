// <copyright file="MainPage.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023 All rights reserved</copyright>

namespace UnoResourceStringsIssue
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;
    using Microsoft.UI.Xaml.Controls;
    using UnoResourceStringsIssue.Services;
    using UnoResourceStringsIssue.ViewModels;
    using Windows.Foundation;
    using Windows.Foundation.Collections;

    // The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

            // This would normally be done using a DI framework, but for brevity...
            var stringResourceServices = new StringResourceServices();
            stringResourceServices.InitialiseSource("UnoResourceStringsIssue");
            this.DataContext = new MainViewModel(stringResourceServices);
        }

        /// <summary>
        /// Gets the viewmodel, this is the prefix used in the XAML for binding.
        /// </summary>
        public IMainViewModel VM => this.DataContext as IMainViewModel;

        /// <summary>
        /// Event handler for the button press
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void Button_Tapped(object sender, Microsoft.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            this.VM.FlipText();
        }
    }
}

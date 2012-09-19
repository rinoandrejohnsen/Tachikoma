// ***********************************************************************
// Assembly         : Tachikoma
// Author           : Rino Andre Johnsen
// Created          : 09-10-2012
//
// Last Modified By : Rino Andre Johnsen
// Last Modified On : 09-11-2012
// ***********************************************************************
// <copyright file="Shell.xaml.cs">
//     Copyright (c) 2012, Author(s) above.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Windows;
using Tachikoma.ViewModels;

namespace Tachikoma
{
    /// <summary>
    /// Class Shell
    /// </summary>
    public partial class Shell : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shell" /> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        public Shell(ShellViewModel viewModel)
        {
            this.DataContext = viewModel;
            this.InitializeComponent();
        }
    }
}

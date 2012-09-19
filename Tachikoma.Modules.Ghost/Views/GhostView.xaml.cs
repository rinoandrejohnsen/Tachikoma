// ***********************************************************************
// Assembly         : Tachikoma.Modules.Ghost
// Author           : Rino Andre Johnsen
// Created          : 09-11-2012
//
// Last Modified By : Rino Andre Johnsen
// Last Modified On : 09-11-2012
// ***********************************************************************
// <copyright file="GhostView.xaml.cs">
//     Copyright (c) 2012, Author(s) above.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Windows.Controls;
using Tachikoma.Modules.Ghost.ViewModels;

namespace Tachikoma.Modules.Ghost.Views
{
    /// <summary>
    /// Class GhostView
    /// </summary>
    public partial class GhostView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GhostView" /> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        public GhostView(GhostViewModel viewModel)
        {
            this.DataContext = viewModel;
            this.InitializeComponent();
        }
    }
}

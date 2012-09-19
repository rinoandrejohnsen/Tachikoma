// ***********************************************************************
// Assembly         : Tachikoma.Modules.Neurochip
// Author           : Rino Andre Johnsen
// Created          : 09-11-2012
//
// Last Modified By : Rino Andre Johnsen
// Last Modified On : 09-11-2012
// ***********************************************************************
// <copyright file="NeurochipView.xaml.cs">
//     Copyright (c) 2012, Author(s) above.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Windows.Controls;
using Tachikoma.Modules.Neurochip.ViewModels;

namespace Tachikoma.Modules.Neurochip.Views
{
    /// <summary>
    /// Class NeurochipView
    /// </summary>
    public partial class NeurochipView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NeurochipView" /> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        public NeurochipView(NeurochipViewModel viewModel)
        {
            this.DataContext = viewModel;
            this.InitializeComponent();
        }
    }
}

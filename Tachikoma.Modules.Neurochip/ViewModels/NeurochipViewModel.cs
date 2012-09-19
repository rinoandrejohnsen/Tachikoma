// ***********************************************************************
// Assembly         : Tachikoma.Modules.Neurochip
// Author           : Rino Andre Johnsen
// Created          : 09-11-2012
//
// Last Modified By : Rino Andre Johnsen
// Last Modified On : 09-11-2012
// ***********************************************************************
// <copyright file="NeurochipViewModel.cs">
//     Copyright (c) 2012, Author(s) above.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Tachikoma.Modules.Neurochip.ViewModels
{
    /// <summary>
    /// Class NeurochipViewModel
    /// </summary>
    public class NeurochipViewModel
    {
        /// <summary>
        /// Gets or sets the header info.
        /// </summary>
        /// <value>The header info.</value>
        public string HeaderInfo { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether this instance is selected.
        /// </summary>
        /// <value><c>true</c> if this instance is selected; otherwise, <c>false</c>.</value>
        public bool IsSelected { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeurochipViewModel" /> class.
        /// </summary>
        public NeurochipViewModel()
        {
            this.HeaderInfo = "NeurochipModule";
            this.IsSelected = true;
        }
    }
}

// ***********************************************************************
// Assembly         : Tachikoma.Modules.Ghost
// Author           : Rino Andre Johnsen
// Created          : 09-11-2012
//
// Last Modified By : Rino Andre Johnsen
// Last Modified On : 09-11-2012
// ***********************************************************************
// <copyright file="GhostViewModel.cs">
//     Copyright (c) 2012, Author(s) above.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Tachikoma.Modules.Ghost.ViewModels
{
    /// <summary>
    /// Class GhostViewModel
    /// </summary>
    public class GhostViewModel
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
        /// Initializes a new instance of the <see cref="GhostViewModel" /> class.
        /// </summary>
        public GhostViewModel()
        {
            this.HeaderInfo = "GhostModule";
            this.IsSelected = false;
        }
    }
}

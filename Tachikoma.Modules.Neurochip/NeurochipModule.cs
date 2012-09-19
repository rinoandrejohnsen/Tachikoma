// ***********************************************************************
// Assembly         : Tachikoma.Modules.Neurochip
// Author           : Rino Andre Johnsen
// Created          : 09-11-2012
//
// Last Modified By : Rino Andre Johnsen
// Last Modified On : 09-11-2012
// ***********************************************************************
// <copyright file="NeurochipModule.cs">
//     Copyright (c) 2012, Author(s) above.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Tachikoma.Modules.Neurochip.Views;

namespace Tachikoma.Modules.Neurochip
{
    /// <summary>
    /// Class NeurochipModule
    /// </summary>
    public class NeurochipModule : IModule
    {
        /// <summary>
        /// The container
        /// </summary>
        private IUnityContainer container;
        /// <summary>
        /// The region manager
        /// </summary>
        private IRegionManager regionManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="NeurochipModule" /> class.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="regionManager">The region manager.</param>
        public NeurochipModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion("MainRegion", () => this.container.Resolve<NeurochipView>());
        }
    }
}

// ***********************************************************************
// Assembly         : Tachikoma
// Author           : Rino Andre Johnsen
// Created          : 09-10-2012
//
// Last Modified By : Rino Andre Johnsen
// Last Modified On : 09-11-2012
// ***********************************************************************
// <copyright file="Bootstrapper.cs">
//     Copyright (c) 2012, Author(s) above.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using Tachikoma.Modules.Ghost;
using Tachikoma.Modules.Neurochip;
using Tachikoma.ViewModels;

namespace Tachikoma
{
    /// <summary>
    /// Class Bootstrapper
    /// </summary>
    class Bootstrapper : UnityBootstrapper
    {
        /// <summary>
        /// Creates the shell or main window of the application.
        /// </summary>
        /// <returns>The shell of the application.</returns>
        /// <remarks>If the returned instance is a <see cref="T:System.Windows.DependencyObject" />, the
        /// <see cref="T:Microsoft.Practices.Prism.Bootstrapper" /> will attach the default <seealso cref="T:Microsoft.Practices.Prism.Regions.IRegionManager" /> of
        /// the application in its <see cref="F:Microsoft.Practices.Prism.Regions.RegionManager.RegionManagerProperty" /> attached property
        /// in order to be able to add regions by using the <seealso cref="F:Microsoft.Practices.Prism.Regions.RegionManager.RegionNameProperty" />
        /// attached property from XAML.</remarks>
        protected override System.Windows.DependencyObject CreateShell()
        {
            Shell shell = Container.Resolve<Shell>();
            shell.Show();
            
            return shell;
        }

        /// <summary>
        /// Configures the <see cref="T:Microsoft.Practices.Unity.IUnityContainer" />. May be overwritten in a derived class to add specific
        /// type mappings required by the application.
        /// </summary>
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.Container.RegisterType<ShellViewModel, ShellViewModel>(new Microsoft.Practices.Unity.ContainerControlledLifetimeManager());
        }

        /// <summary>
        /// Creates the <see cref="T:Microsoft.Practices.Prism.Modularity.IModuleCatalog" /> used by Prism.
        /// </summary>
        /// <returns></returns>
        /// <remarks>The base implementation returns a new ModuleCatalog.</remarks>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            ModuleCatalog catalog = new ModuleCatalog();
            catalog.AddModule(typeof(NeurochipModule));
            catalog.AddModule(typeof(GhostModule));
           
            return catalog;
        }
    }
}

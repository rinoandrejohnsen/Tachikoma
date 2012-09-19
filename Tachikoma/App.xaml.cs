// ***********************************************************************
// Assembly         : Tachikoma
// Author           : Rino Andre Johnsen
// Created          : 09-10-2012
//
// Last Modified By : Rino Andre Johnsen
// Last Modified On : 09-11-2012
// ***********************************************************************
// <copyright file="App.xaml.cs">
//     Copyright (c) 2012, Author(s) above.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Windows;

namespace Tachikoma
{
    /// <summary>
    /// Class App
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Startup" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.StartupEventArgs" /> that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                Bootstrapper bootstrapper = new Bootstrapper();
                bootstrapper.Run();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }

            this.ShutdownMode = ShutdownMode.OnMainWindowClose;
        }

        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void HandleException(Exception ex)
        {
            if (ex == null)
            {
                return;
            }

            MessageBox.Show("An unhandled exception occurred, and the application is terminating. For more information, see your Application log.");
            
            Environment.Exit(1);
        }
    }
}

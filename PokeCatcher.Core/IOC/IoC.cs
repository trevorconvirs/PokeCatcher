﻿using Ninject;
using System;

namespace PokeCatcher.Core
{

    /// <summary>
    /// The IOC container for our application
    /// </summary>
    public static class IoC
    {
        #region Public Properties
        /// <summary>
        /// the kernel for our IOC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        #endregion

        #region Construction
        /// <summary>
        /// Sets up the IOC container, binds all information required and is ready for use
        /// NOTE: Must be called as soon as your application starts up to unsures all
        ///       services can be found
        /// </summary>
        public static void Setup()
        {
            // bind all required view models
            BindViewModels();
        }

        /// <summary>
        /// Binds all singleton view models
        /// </summary>
        private static void BindViewModels()
        {
            // Bind to a single instance of Application View Model
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }
        #endregion
       
        /// <summary>
        /// Gets a service from the IoC, of the specified type
        /// </summary>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

    }
}

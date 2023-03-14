// <copyright file="StringResourceServices.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023 All rights reserved</copyright>

namespace UnoResourceStringsIssue.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Windows.ApplicationModel.Resources;

    /// <summary>
    /// A cut down version of the string resource services service.
    /// </summary>
    internal class StringResourceServices : IStringResourceServices
    {
        /// <summary>
        /// Loads national language resources from a '.resw' file
        /// </summary>
        private ResourceLoader resourceLoader;

        /// <summary>
        /// Initialise the resource loader obtionaly from a non default assembly.
        /// </summary>
        /// <param name="assemblyName">An optional assembly name</param>
        public void InitialiseSource(string assemblyName = null)
        {
            try
            {
                if (assemblyName == null)
                {
#if HAS_UNO
                    this.resourceLoader = ResourceLoader.GetForCurrentView();
#else
                    this.resourceLoader = new ResourceLoader();
#endif
                }
                else
                {
#if HAS_UNO
                    this.resourceLoader = ResourceLoader.GetForCurrentView(assemblyName + "/Resources");
#else
                    this.resourceLoader = ResourceLoader.GetForViewIndependentUse(assemblyName + "/Resources");
#endif
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Finds a national language string resource
        /// </summary>
        /// <param name="key">The string resource name</param>
        /// <returns>The string</returns>
        public string FindNLString(string key)
        {
            return this.resourceLoader.GetString(key);
        }
    }
}

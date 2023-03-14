// <copyright file="IStringResourceServices.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023 All rights reserved</copyright>

namespace UnoResourceStringsIssue.Services
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A cut down version of the string resource services service.
    /// </summary>
    public interface  IStringResourceServices
    {
        /// <summary>
        /// Initialise the resource loader obtionaly from a non default assembly.
        /// </summary>
        /// <param name="assemblyName">An optional assembly name</param>
        void InitialiseSource(string assemblyName = null);

        /// <summary>
        /// Finds a national language string resource
        /// </summary>
        /// <param name="key">The string resource name</param>
        /// <returns>The string</returns>       
        string FindNLString(string key);
    }
}

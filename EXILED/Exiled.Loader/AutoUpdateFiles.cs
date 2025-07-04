// -----------------------------------------------------------------------
// <copyright file="AutoUpdateFiles.cs" company="ExMod Team">
// Copyright (c) ExMod Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Loader
{
    using System;

    /// <summary>
    /// Automatically updates with Reference used to generate Exiled.
    /// </summary>
    public static class AutoUpdateFiles
    {
        /// <summary>
        /// Gets which SCP: SL version generated Exiled.
        /// </summary>
        public static readonly Version RequiredSCPSLVersion = new(14, 1, 0, 1);
    }
}
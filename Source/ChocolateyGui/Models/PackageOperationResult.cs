﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chocolatey" file="PackageOperationResult.cs">
//   Copyright 2014 - Present Rob Reynolds, the maintainers of Chocolatey, and RealDimensions Software, LLC
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace ChocolateyGui.Models
{
    public class PackageOperationResult
    {
        public static readonly PackageOperationResult SuccessfulCached = new PackageOperationResult
        {
            Successful = true
        };

        public bool Successful { get; set; }

        public string[] Messages { get; set; } = new string[0];

        public Exception Exception { get; set; }
    }
}
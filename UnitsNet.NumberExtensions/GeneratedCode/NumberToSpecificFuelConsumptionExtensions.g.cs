﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToSpecificFuelConsumption
{
    /// <summary>
    /// A number to SpecificFuelConsumption Extensions
    /// </summary>
    public static class NumberToSpecificFuelConsumptionExtensions
    {
        /// <inheritdoc cref="SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(UnitsNet.QuantityValue)" />
        public static SpecificFuelConsumption GramsPerKiloNewtonSecond<T>(this T value) =>
            SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificFuelConsumption.FromKilogramsPerKilogramForceHour(UnitsNet.QuantityValue)" />
        public static SpecificFuelConsumption KilogramsPerKilogramForceHour<T>(this T value) =>
            SpecificFuelConsumption.FromKilogramsPerKilogramForceHour(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificFuelConsumption.FromKilogramsPerKiloNewtonSecond(UnitsNet.QuantityValue)" />
        public static SpecificFuelConsumption KilogramsPerKiloNewtonSecond<T>(this T value) =>
            SpecificFuelConsumption.FromKilogramsPerKiloNewtonSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(UnitsNet.QuantityValue)" />
        public static SpecificFuelConsumption PoundsMassPerPoundForceHour<T>(this T value) =>
            SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(Convert.ToDouble(value));

    }
}
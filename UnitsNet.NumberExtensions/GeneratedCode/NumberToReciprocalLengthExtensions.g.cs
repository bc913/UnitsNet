//------------------------------------------------------------------------------
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

namespace UnitsNet.NumberExtensions.NumberToReciprocalLength
{
    /// <summary>
    /// A number to ReciprocalLength Extensions
    /// </summary>
    public static class NumberToReciprocalLengthExtensions
    {
        /// <inheritdoc cref="ReciprocalLength.FromInverseCentimeter(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseCentimeter<T>(this T value) =>
            ReciprocalLength.FromInverseCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalLength.FromInverseFoot(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseFoot<T>(this T value) =>
            ReciprocalLength.FromInverseFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalLength.FromInverseInch(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseInch<T>(this T value) =>
            ReciprocalLength.FromInverseInch(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalLength.FromInverseMeter(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseMeter<T>(this T value) =>
            ReciprocalLength.FromInverseMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalLength.FromInverseMicroinch(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseMicroinch<T>(this T value) =>
            ReciprocalLength.FromInverseMicroinch(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalLength.FromInverseMil(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseMil<T>(this T value) =>
            ReciprocalLength.FromInverseMil(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalLength.FromInverseMile(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseMile<T>(this T value) =>
            ReciprocalLength.FromInverseMile(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalLength.FromInverseMillimeter(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseMillimeter<T>(this T value) =>
            ReciprocalLength.FromInverseMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalLength.FromInverseUsSurveyFeet(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseUsSurveyFeet<T>(this T value) =>
            ReciprocalLength.FromInverseUsSurveyFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalLength.FromInverseYard(UnitsNet.QuantityValue)" />
        public static ReciprocalLength InverseYard<T>(this T value) =>
            ReciprocalLength.FromInverseYard(Convert.ToDouble(value));

    }
}
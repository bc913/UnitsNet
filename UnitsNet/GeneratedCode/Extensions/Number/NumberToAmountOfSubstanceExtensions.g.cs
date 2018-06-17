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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToAmountOfSubstance
{
    public static class NumberToAmountOfSubstanceExtensions
    {
        #region Centimole

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Centimoles(this int value) => AmountOfSubstance.FromCentimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Centimoles(this int? value) => AmountOfSubstance.FromCentimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Centimoles(this long value) => AmountOfSubstance.FromCentimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Centimoles(this long? value) => AmountOfSubstance.FromCentimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Centimoles(this double value) => AmountOfSubstance.FromCentimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Centimoles(this double? value) => AmountOfSubstance.FromCentimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Centimoles(this float value) => AmountOfSubstance.FromCentimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Centimoles(this float? value) => AmountOfSubstance.FromCentimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Centimoles(this decimal value) => AmountOfSubstance.FromCentimoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromCentimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Centimoles(this decimal? value) => AmountOfSubstance.FromCentimoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CentipoundMole

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance CentipoundMoles(this int value) => AmountOfSubstance.FromCentipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? CentipoundMoles(this int? value) => AmountOfSubstance.FromCentipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance CentipoundMoles(this long value) => AmountOfSubstance.FromCentipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? CentipoundMoles(this long? value) => AmountOfSubstance.FromCentipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance CentipoundMoles(this double value) => AmountOfSubstance.FromCentipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? CentipoundMoles(this double? value) => AmountOfSubstance.FromCentipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance CentipoundMoles(this float value) => AmountOfSubstance.FromCentipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? CentipoundMoles(this float? value) => AmountOfSubstance.FromCentipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance CentipoundMoles(this decimal value) => AmountOfSubstance.FromCentipoundMoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromCentipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? CentipoundMoles(this decimal? value) => AmountOfSubstance.FromCentipoundMoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decimole

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Decimoles(this int value) => AmountOfSubstance.FromDecimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Decimoles(this int? value) => AmountOfSubstance.FromDecimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Decimoles(this long value) => AmountOfSubstance.FromDecimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Decimoles(this long? value) => AmountOfSubstance.FromDecimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Decimoles(this double value) => AmountOfSubstance.FromDecimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Decimoles(this double? value) => AmountOfSubstance.FromDecimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Decimoles(this float value) => AmountOfSubstance.FromDecimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Decimoles(this float? value) => AmountOfSubstance.FromDecimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Decimoles(this decimal value) => AmountOfSubstance.FromDecimoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromDecimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Decimoles(this decimal? value) => AmountOfSubstance.FromDecimoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecipoundMole

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance DecipoundMoles(this int value) => AmountOfSubstance.FromDecipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? DecipoundMoles(this int? value) => AmountOfSubstance.FromDecipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance DecipoundMoles(this long value) => AmountOfSubstance.FromDecipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? DecipoundMoles(this long? value) => AmountOfSubstance.FromDecipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance DecipoundMoles(this double value) => AmountOfSubstance.FromDecipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? DecipoundMoles(this double? value) => AmountOfSubstance.FromDecipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance DecipoundMoles(this float value) => AmountOfSubstance.FromDecipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? DecipoundMoles(this float? value) => AmountOfSubstance.FromDecipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance DecipoundMoles(this decimal value) => AmountOfSubstance.FromDecipoundMoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromDecipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? DecipoundMoles(this decimal? value) => AmountOfSubstance.FromDecipoundMoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilomole

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Kilomoles(this int value) => AmountOfSubstance.FromKilomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Kilomoles(this int? value) => AmountOfSubstance.FromKilomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Kilomoles(this long value) => AmountOfSubstance.FromKilomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Kilomoles(this long? value) => AmountOfSubstance.FromKilomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Kilomoles(this double value) => AmountOfSubstance.FromKilomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Kilomoles(this double? value) => AmountOfSubstance.FromKilomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Kilomoles(this float value) => AmountOfSubstance.FromKilomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Kilomoles(this float? value) => AmountOfSubstance.FromKilomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Kilomoles(this decimal value) => AmountOfSubstance.FromKilomoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromKilomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Kilomoles(this decimal? value) => AmountOfSubstance.FromKilomoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundMole

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance KilopoundMoles(this int value) => AmountOfSubstance.FromKilopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? KilopoundMoles(this int? value) => AmountOfSubstance.FromKilopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance KilopoundMoles(this long value) => AmountOfSubstance.FromKilopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? KilopoundMoles(this long? value) => AmountOfSubstance.FromKilopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance KilopoundMoles(this double value) => AmountOfSubstance.FromKilopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? KilopoundMoles(this double? value) => AmountOfSubstance.FromKilopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance KilopoundMoles(this float value) => AmountOfSubstance.FromKilopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? KilopoundMoles(this float? value) => AmountOfSubstance.FromKilopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance KilopoundMoles(this decimal value) => AmountOfSubstance.FromKilopoundMoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromKilopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? KilopoundMoles(this decimal? value) => AmountOfSubstance.FromKilopoundMoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Micromole

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Micromoles(this int value) => AmountOfSubstance.FromMicromoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Micromoles(this int? value) => AmountOfSubstance.FromMicromoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Micromoles(this long value) => AmountOfSubstance.FromMicromoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Micromoles(this long? value) => AmountOfSubstance.FromMicromoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Micromoles(this double value) => AmountOfSubstance.FromMicromoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Micromoles(this double? value) => AmountOfSubstance.FromMicromoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Micromoles(this float value) => AmountOfSubstance.FromMicromoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Micromoles(this float? value) => AmountOfSubstance.FromMicromoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Micromoles(this decimal value) => AmountOfSubstance.FromMicromoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromMicromoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Micromoles(this decimal? value) => AmountOfSubstance.FromMicromoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicropoundMole

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MicropoundMoles(this int value) => AmountOfSubstance.FromMicropoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MicropoundMoles(this int? value) => AmountOfSubstance.FromMicropoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MicropoundMoles(this long value) => AmountOfSubstance.FromMicropoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MicropoundMoles(this long? value) => AmountOfSubstance.FromMicropoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MicropoundMoles(this double value) => AmountOfSubstance.FromMicropoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MicropoundMoles(this double? value) => AmountOfSubstance.FromMicropoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MicropoundMoles(this float value) => AmountOfSubstance.FromMicropoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MicropoundMoles(this float? value) => AmountOfSubstance.FromMicropoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MicropoundMoles(this decimal value) => AmountOfSubstance.FromMicropoundMoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromMicropoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MicropoundMoles(this decimal? value) => AmountOfSubstance.FromMicropoundMoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millimole

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Millimoles(this int value) => AmountOfSubstance.FromMillimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Millimoles(this int? value) => AmountOfSubstance.FromMillimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Millimoles(this long value) => AmountOfSubstance.FromMillimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Millimoles(this long? value) => AmountOfSubstance.FromMillimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Millimoles(this double value) => AmountOfSubstance.FromMillimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Millimoles(this double? value) => AmountOfSubstance.FromMillimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Millimoles(this float value) => AmountOfSubstance.FromMillimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Millimoles(this float? value) => AmountOfSubstance.FromMillimoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Millimoles(this decimal value) => AmountOfSubstance.FromMillimoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromMillimoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Millimoles(this decimal? value) => AmountOfSubstance.FromMillimoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillipoundMole

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MillipoundMoles(this int value) => AmountOfSubstance.FromMillipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MillipoundMoles(this int? value) => AmountOfSubstance.FromMillipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MillipoundMoles(this long value) => AmountOfSubstance.FromMillipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MillipoundMoles(this long? value) => AmountOfSubstance.FromMillipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MillipoundMoles(this double value) => AmountOfSubstance.FromMillipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MillipoundMoles(this double? value) => AmountOfSubstance.FromMillipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MillipoundMoles(this float value) => AmountOfSubstance.FromMillipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MillipoundMoles(this float? value) => AmountOfSubstance.FromMillipoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance MillipoundMoles(this decimal value) => AmountOfSubstance.FromMillipoundMoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromMillipoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? MillipoundMoles(this decimal? value) => AmountOfSubstance.FromMillipoundMoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Mole

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Moles(this int value) => AmountOfSubstance.FromMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Moles(this int? value) => AmountOfSubstance.FromMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Moles(this long value) => AmountOfSubstance.FromMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Moles(this long? value) => AmountOfSubstance.FromMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Moles(this double value) => AmountOfSubstance.FromMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Moles(this double? value) => AmountOfSubstance.FromMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Moles(this float value) => AmountOfSubstance.FromMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Moles(this float? value) => AmountOfSubstance.FromMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Moles(this decimal value) => AmountOfSubstance.FromMoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Moles(this decimal? value) => AmountOfSubstance.FromMoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanomole

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Nanomoles(this int value) => AmountOfSubstance.FromNanomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Nanomoles(this int? value) => AmountOfSubstance.FromNanomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Nanomoles(this long value) => AmountOfSubstance.FromNanomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Nanomoles(this long? value) => AmountOfSubstance.FromNanomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Nanomoles(this double value) => AmountOfSubstance.FromNanomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Nanomoles(this double? value) => AmountOfSubstance.FromNanomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Nanomoles(this float value) => AmountOfSubstance.FromNanomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Nanomoles(this float? value) => AmountOfSubstance.FromNanomoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance Nanomoles(this decimal value) => AmountOfSubstance.FromNanomoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromNanomoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? Nanomoles(this decimal? value) => AmountOfSubstance.FromNanomoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanopoundMole

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance NanopoundMoles(this int value) => AmountOfSubstance.FromNanopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? NanopoundMoles(this int? value) => AmountOfSubstance.FromNanopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance NanopoundMoles(this long value) => AmountOfSubstance.FromNanopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? NanopoundMoles(this long? value) => AmountOfSubstance.FromNanopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance NanopoundMoles(this double value) => AmountOfSubstance.FromNanopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? NanopoundMoles(this double? value) => AmountOfSubstance.FromNanopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance NanopoundMoles(this float value) => AmountOfSubstance.FromNanopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? NanopoundMoles(this float? value) => AmountOfSubstance.FromNanopoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance NanopoundMoles(this decimal value) => AmountOfSubstance.FromNanopoundMoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromNanopoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? NanopoundMoles(this decimal? value) => AmountOfSubstance.FromNanopoundMoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundMole

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance PoundMoles(this int value) => AmountOfSubstance.FromPoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? PoundMoles(this int? value) => AmountOfSubstance.FromPoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance PoundMoles(this long value) => AmountOfSubstance.FromPoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? PoundMoles(this long? value) => AmountOfSubstance.FromPoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance PoundMoles(this double value) => AmountOfSubstance.FromPoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? PoundMoles(this double? value) => AmountOfSubstance.FromPoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance PoundMoles(this float value) => AmountOfSubstance.FromPoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? PoundMoles(this float? value) => AmountOfSubstance.FromPoundMoles(value);

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance PoundMoles(this decimal value) => AmountOfSubstance.FromPoundMoles(Convert.ToDouble(value));

        /// <inheritdoc cref="AmountOfSubstance.FromPoundMoles(UnitsNet.QuantityValue)" />
        public static AmountOfSubstance? PoundMoles(this decimal? value) => AmountOfSubstance.FromPoundMoles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif

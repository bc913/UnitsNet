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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Pressure (symbol: P or p) is the ratio of force to the area over which that force is distributed. Pressure is force per unit area applied in a direction perpendicular to the surface of an object. Gauge pressure (also spelled gage pressure)[a] is the pressure relative to the local atmospheric or ambient pressure. Pressure is measured in any unit of force divided by any unit of area. The SI unit of pressure is the newton per square metre, which is called the pascal (Pa) after the seventeenth-century philosopher and scientist Blaise Pascal. A pressure of 1 Pa is small; it approximately equals the pressure exerted by a dollar bill resting flat on a table. Everyday pressures are often stated in kilopascals (1 kPa = 1000 Pa).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Pressure : IComparable, IComparable<Pressure>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Pressure from nullable Atmospheres.
        /// </summary>
        public static Pressure? FromAtmospheres(QuantityValue? atmospheres)
        {
            return atmospheres.HasValue ? FromAtmospheres(atmospheres.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Bars.
        /// </summary>
        public static Pressure? FromBars(QuantityValue? bars)
        {
            return bars.HasValue ? FromBars(bars.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Centibars.
        /// </summary>
        public static Pressure? FromCentibars(QuantityValue? centibars)
        {
            return centibars.HasValue ? FromCentibars(centibars.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Decapascals.
        /// </summary>
        public static Pressure? FromDecapascals(QuantityValue? decapascals)
        {
            return decapascals.HasValue ? FromDecapascals(decapascals.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Decibars.
        /// </summary>
        public static Pressure? FromDecibars(QuantityValue? decibars)
        {
            return decibars.HasValue ? FromDecibars(decibars.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable FeetOfHead.
        /// </summary>
        public static Pressure? FromFeetOfHead(QuantityValue? feetofhead)
        {
            return feetofhead.HasValue ? FromFeetOfHead(feetofhead.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Gigapascals.
        /// </summary>
        public static Pressure? FromGigapascals(QuantityValue? gigapascals)
        {
            return gigapascals.HasValue ? FromGigapascals(gigapascals.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Hectopascals.
        /// </summary>
        public static Pressure? FromHectopascals(QuantityValue? hectopascals)
        {
            return hectopascals.HasValue ? FromHectopascals(hectopascals.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable InchesOfMercury.
        /// </summary>
        public static Pressure? FromInchesOfMercury(QuantityValue? inchesofmercury)
        {
            return inchesofmercury.HasValue ? FromInchesOfMercury(inchesofmercury.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Kilobars.
        /// </summary>
        public static Pressure? FromKilobars(QuantityValue? kilobars)
        {
            return kilobars.HasValue ? FromKilobars(kilobars.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable KilogramsForcePerSquareCentimeter.
        /// </summary>
        public static Pressure? FromKilogramsForcePerSquareCentimeter(QuantityValue? kilogramsforcepersquarecentimeter)
        {
            return kilogramsforcepersquarecentimeter.HasValue ? FromKilogramsForcePerSquareCentimeter(kilogramsforcepersquarecentimeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable KilogramsForcePerSquareMeter.
        /// </summary>
        public static Pressure? FromKilogramsForcePerSquareMeter(QuantityValue? kilogramsforcepersquaremeter)
        {
            return kilogramsforcepersquaremeter.HasValue ? FromKilogramsForcePerSquareMeter(kilogramsforcepersquaremeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable KilogramsForcePerSquareMillimeter.
        /// </summary>
        public static Pressure? FromKilogramsForcePerSquareMillimeter(QuantityValue? kilogramsforcepersquaremillimeter)
        {
            return kilogramsforcepersquaremillimeter.HasValue ? FromKilogramsForcePerSquareMillimeter(kilogramsforcepersquaremillimeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable KilonewtonsPerSquareCentimeter.
        /// </summary>
        public static Pressure? FromKilonewtonsPerSquareCentimeter(QuantityValue? kilonewtonspersquarecentimeter)
        {
            return kilonewtonspersquarecentimeter.HasValue ? FromKilonewtonsPerSquareCentimeter(kilonewtonspersquarecentimeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable KilonewtonsPerSquareMeter.
        /// </summary>
        public static Pressure? FromKilonewtonsPerSquareMeter(QuantityValue? kilonewtonspersquaremeter)
        {
            return kilonewtonspersquaremeter.HasValue ? FromKilonewtonsPerSquareMeter(kilonewtonspersquaremeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable KilonewtonsPerSquareMillimeter.
        /// </summary>
        public static Pressure? FromKilonewtonsPerSquareMillimeter(QuantityValue? kilonewtonspersquaremillimeter)
        {
            return kilonewtonspersquaremillimeter.HasValue ? FromKilonewtonsPerSquareMillimeter(kilonewtonspersquaremillimeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Kilopascals.
        /// </summary>
        public static Pressure? FromKilopascals(QuantityValue? kilopascals)
        {
            return kilopascals.HasValue ? FromKilopascals(kilopascals.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable KilopoundsForcePerSquareFoot.
        /// </summary>
        public static Pressure? FromKilopoundsForcePerSquareFoot(QuantityValue? kilopoundsforcepersquarefoot)
        {
            return kilopoundsforcepersquarefoot.HasValue ? FromKilopoundsForcePerSquareFoot(kilopoundsforcepersquarefoot.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable KilopoundsForcePerSquareInch.
        /// </summary>
        public static Pressure? FromKilopoundsForcePerSquareInch(QuantityValue? kilopoundsforcepersquareinch)
        {
            return kilopoundsforcepersquareinch.HasValue ? FromKilopoundsForcePerSquareInch(kilopoundsforcepersquareinch.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Megabars.
        /// </summary>
        public static Pressure? FromMegabars(QuantityValue? megabars)
        {
            return megabars.HasValue ? FromMegabars(megabars.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable MeganewtonsPerSquareMeter.
        /// </summary>
        public static Pressure? FromMeganewtonsPerSquareMeter(QuantityValue? meganewtonspersquaremeter)
        {
            return meganewtonspersquaremeter.HasValue ? FromMeganewtonsPerSquareMeter(meganewtonspersquaremeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Megapascals.
        /// </summary>
        public static Pressure? FromMegapascals(QuantityValue? megapascals)
        {
            return megapascals.HasValue ? FromMegapascals(megapascals.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable MetersOfHead.
        /// </summary>
        public static Pressure? FromMetersOfHead(QuantityValue? metersofhead)
        {
            return metersofhead.HasValue ? FromMetersOfHead(metersofhead.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Micropascals.
        /// </summary>
        public static Pressure? FromMicropascals(QuantityValue? micropascals)
        {
            return micropascals.HasValue ? FromMicropascals(micropascals.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Millibars.
        /// </summary>
        public static Pressure? FromMillibars(QuantityValue? millibars)
        {
            return millibars.HasValue ? FromMillibars(millibars.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable MillimetersOfMercury.
        /// </summary>
        public static Pressure? FromMillimetersOfMercury(QuantityValue? millimetersofmercury)
        {
            return millimetersofmercury.HasValue ? FromMillimetersOfMercury(millimetersofmercury.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable NewtonsPerSquareCentimeter.
        /// </summary>
        public static Pressure? FromNewtonsPerSquareCentimeter(QuantityValue? newtonspersquarecentimeter)
        {
            return newtonspersquarecentimeter.HasValue ? FromNewtonsPerSquareCentimeter(newtonspersquarecentimeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable NewtonsPerSquareMeter.
        /// </summary>
        public static Pressure? FromNewtonsPerSquareMeter(QuantityValue? newtonspersquaremeter)
        {
            return newtonspersquaremeter.HasValue ? FromNewtonsPerSquareMeter(newtonspersquaremeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable NewtonsPerSquareMillimeter.
        /// </summary>
        public static Pressure? FromNewtonsPerSquareMillimeter(QuantityValue? newtonspersquaremillimeter)
        {
            return newtonspersquaremillimeter.HasValue ? FromNewtonsPerSquareMillimeter(newtonspersquaremillimeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Pascals.
        /// </summary>
        public static Pressure? FromPascals(QuantityValue? pascals)
        {
            return pascals.HasValue ? FromPascals(pascals.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable PoundsForcePerSquareFoot.
        /// </summary>
        public static Pressure? FromPoundsForcePerSquareFoot(QuantityValue? poundsforcepersquarefoot)
        {
            return poundsforcepersquarefoot.HasValue ? FromPoundsForcePerSquareFoot(poundsforcepersquarefoot.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable PoundsForcePerSquareInch.
        /// </summary>
        public static Pressure? FromPoundsForcePerSquareInch(QuantityValue? poundsforcepersquareinch)
        {
            return poundsforcepersquareinch.HasValue ? FromPoundsForcePerSquareInch(poundsforcepersquareinch.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Psi.
        /// </summary>
        public static Pressure? FromPsi(QuantityValue? psi)
        {
            return psi.HasValue ? FromPsi(psi.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable TechnicalAtmospheres.
        /// </summary>
        public static Pressure? FromTechnicalAtmospheres(QuantityValue? technicalatmospheres)
        {
            return technicalatmospheres.HasValue ? FromTechnicalAtmospheres(technicalatmospheres.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable TonnesForcePerSquareCentimeter.
        /// </summary>
        public static Pressure? FromTonnesForcePerSquareCentimeter(QuantityValue? tonnesforcepersquarecentimeter)
        {
            return tonnesforcepersquarecentimeter.HasValue ? FromTonnesForcePerSquareCentimeter(tonnesforcepersquarecentimeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable TonnesForcePerSquareMeter.
        /// </summary>
        public static Pressure? FromTonnesForcePerSquareMeter(QuantityValue? tonnesforcepersquaremeter)
        {
            return tonnesforcepersquaremeter.HasValue ? FromTonnesForcePerSquareMeter(tonnesforcepersquaremeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable TonnesForcePerSquareMillimeter.
        /// </summary>
        public static Pressure? FromTonnesForcePerSquareMillimeter(QuantityValue? tonnesforcepersquaremillimeter)
        {
            return tonnesforcepersquaremillimeter.HasValue ? FromTonnesForcePerSquareMillimeter(tonnesforcepersquaremillimeter.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Get nullable Pressure from nullable Torrs.
        /// </summary>
        public static Pressure? FromTorrs(QuantityValue? torrs)
        {
            return torrs.HasValue ? FromTorrs(torrs.Value) : default(Pressure?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PressureUnit" /> to <see cref="Pressure" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Pressure unit value.</returns>
        public static Pressure? From(QuantityValue? value, PressureUnit fromUnit)
        {
            return value.HasValue ? new Pressure((double)value.Value, fromUnit) : default(Pressure?);
        }

        #endregion

        #region Arithmetic Operators

        public static Pressure operator -(Pressure right)
        {
            return new Pressure(-right.Value, right.Unit);
        }

        public static Pressure operator +(Pressure left, Pressure right)
        {
            return new Pressure(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Pressure operator -(Pressure left, Pressure right)
        {
            return new Pressure(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Pressure operator *(double left, Pressure right)
        {
            return new Pressure(left * right.Value, right.Unit);
        }

        public static Pressure operator *(Pressure left, double right)
        {
            return new Pressure(left.Value * right, left.Unit);
        }

        public static Pressure operator /(Pressure left, double right)
        {
            return new Pressure(left.Value / right, left.Unit);
        }

        public static double operator /(Pressure left, Pressure right)
        {
            return left.Pascals / right.Pascals;
        }

        #endregion

        public static bool operator <=(Pressure left, Pressure right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Pressure left, Pressure right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Pressure left, Pressure right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Pressure left, Pressure right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Pressure left, Pressure right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Pressure left, Pressure right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Pressure Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<Pressure, PressureUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    PressureUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromPascals(x.Pascals + y.Pascals));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out Pressure result)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            try
            {
                result = Parse(str, provider);
                return true;
            }
            catch
            {
                result = default(Pressure);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static PressureUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<PressureUnit>(str.Trim());

            if (unit == PressureUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized PressureUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(PressureUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(PressureUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(PressureUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}
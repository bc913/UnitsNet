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

using UnitsNet.NumberExtensions.NumberToSpecificEnergy;
using Xunit;

namespace UnitsNet.Tests
{    
    public class NumberToSpecificEnergyExtensionsTests
    {
        [Fact]
        public void NumberToBtuPerPoundTest() =>
            Assert.Equal(SpecificEnergy.FromBtuPerPound(2), 2.BtuPerPound());

        [Fact]
        public void NumberToCaloriesPerGramTest() =>
            Assert.Equal(SpecificEnergy.FromCaloriesPerGram(2), 2.CaloriesPerGram());

        [Fact]
        public void NumberToJoulesPerKilogramTest() =>
            Assert.Equal(SpecificEnergy.FromJoulesPerKilogram(2), 2.JoulesPerKilogram());

        [Fact]
        public void NumberToKilocaloriesPerGramTest() =>
            Assert.Equal(SpecificEnergy.FromKilocaloriesPerGram(2), 2.KilocaloriesPerGram());

        [Fact]
        public void NumberToKilojoulesPerKilogramTest() =>
            Assert.Equal(SpecificEnergy.FromKilojoulesPerKilogram(2), 2.KilojoulesPerKilogram());

        [Fact]
        public void NumberToKilowattHoursPerKilogramTest() =>
            Assert.Equal(SpecificEnergy.FromKilowattHoursPerKilogram(2), 2.KilowattHoursPerKilogram());

        [Fact]
        public void NumberToMegajoulesPerKilogramTest() =>
            Assert.Equal(SpecificEnergy.FromMegajoulesPerKilogram(2), 2.MegajoulesPerKilogram());

        [Fact]
        public void NumberToMegawattHoursPerKilogramTest() =>
            Assert.Equal(SpecificEnergy.FromMegawattHoursPerKilogram(2), 2.MegawattHoursPerKilogram());

        [Fact]
        public void NumberToWattHoursPerKilogramTest() =>
            Assert.Equal(SpecificEnergy.FromWattHoursPerKilogram(2), 2.WattHoursPerKilogram());

    }
}
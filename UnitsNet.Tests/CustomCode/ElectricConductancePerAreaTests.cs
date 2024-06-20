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

using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class ElectricConductancePerAreaTests : ElectricConductancePerAreaTestsBase
    {
        protected override bool SupportsSIUnitSystem => true;
        protected override double FemtosiemensPerSquareMeterInOneSiemensPerSquareMeter => 1E+15;
        protected override double KilosiemensPerSquareMeterInOneSiemensPerSquareMeter => 1E-3;
        protected override double MegasiemensPerSquareMeterInOneSiemensPerSquareMeter => 1E-06;
        protected override double MicrosiemensPerSquareCentimetersInOneSiemensPerSquareMeter => 1E2;
        protected override double MicrosiemensPerSquareMeterInOneSiemensPerSquareMeter => 1E6;
        protected override double MillisiemensPerSquareCentimetersInOneSiemensPerSquareMeter => 1E-1;
        protected override double MillisiemensPerSquareMeterInOneSiemensPerSquareMeter => 1E3;
        protected override double NanosiemensPerSquareMeterInOneSiemensPerSquareMeter => 1E9;
        protected override double PicosiemensPerSquareMeterInOneSiemensPerSquareMeter => 1E+12;
        protected override double SiemensPerSquareCentimetersInOneSiemensPerSquareMeter => 1E-4;
        protected override double SiemensPerSquareDecimetersInOneSiemensPerSquareMeter => 1E-2;
        protected override double SiemensPerSquareFeetInOneSiemensPerSquareMeter => 0.092903;
        protected override double SiemensPerSquareInchesInOneSiemensPerSquareMeter => 0.00064516;
        protected override double SiemensPerSquareMeterInOneSiemensPerSquareMeter => 1;
        protected override double SiemensPerSquareMilesInOneSiemensPerSquareMeter => 2.59E6;
        protected override double SiemensPerSquareMillimetersInOneSiemensPerSquareMeter => 1E-6;
        protected override double SiemensPerSquareYardsInOneSiemensPerSquareMeter => 0.836127;
        protected override double SiemensPerUsSurveySquareFeetInOneSiemensPerSquareMeter => 0.09290341161;

        [Theory]
        [InlineData(10.0, 2.5, 4.0)]
        [InlineData(0.0, 2.5, 0.0)]
        [InlineData(2.5, 0.0, 0.0)]
        public void ElectricConductanceByAreaEqualsElectricConductancePerArea(double electricConductance, double area, double expected)
        {
            ElectricConductancePerArea ecpa = ElectricConductancePerArea.FromElectricConductanceByArea(ElectricConductance.FromSiemens(electricConductance), Area.FromSquareMeters(area));
            Assert.Equal(expected, ecpa.SiemensPerSquareMeter);
        }

        [Fact]
        public void ElectricConductancePerAreaTimesAreaEqualsElectricConductance()
        {
            ElectricConductance ec = ElectricConductancePerArea.FromSiemensPerSquareMeter(10.0) * 
                    Area.FromSquareMeters(3.0);
            Assert.Equal(ElectricConductance.FromSiemens(30.0), ec);
        }
    }
}
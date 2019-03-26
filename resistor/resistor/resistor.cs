
namespace Resistor
{
    using System;

    /// <summary>
    /// Template for a band
    /// </summary>
    class Band
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Band"/> class.
        /// </summary>
        /// <param name="GivenColor">
        /// The given color.
        /// </param>
        /// <param name="GivenDigit">
        /// The given digit.
        /// </param>
        /// <param name="GivenMultiplier">
        /// The given multiplier.
        /// </param>
        /// <param name="GivenTolerance">
        /// The given tolerance.
        /// </param>
        public Band(string GivenColor, string GivenDigit, string GivenMultiplier, string GivenTolerance)
        {
            this.Color = GivenColor;
            
            this.Digit = double.TryParse(GivenDigit, out var TempDigit) ? TempDigit : double.MinValue;

            this.Multiplier = GivenMultiplier;
            
            this.Tolerance = double.TryParse(GivenTolerance, out var TempTolerance) ? TempTolerance : double.MinValue;
        }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the digit.
        /// </summary>
        public double Digit { get; set;}

        /// <summary>
        /// Gets or sets the multiplier.
        /// </summary>
        public string Multiplier { get; set; }

        /// <summary>
        /// Gets or sets the tolerance.
        /// </summary>
        public double Tolerance { get; set; } 
    }

    /// <summary>
    /// models the resistor with the given bands.
    /// </summary>
    class Resistor
    {


        /// <summary>
        /// Gets or sets the band one.
        /// </summary>
        public Band DigitBandOne { get; set; }

        /// <summary>
        /// Gets or sets the bandTwo.
        /// </summary>
        public Band DigitBandTwo { get; set; }

        /// <summary>
        /// Gets or sets the band three.
        /// </summary>
        public Band MultiplierBand { get; set; }

        /// <summary>
        /// Gets or sets the band four.
        /// </summary>
        public Band ToleranceBand { get; set; }

        /// <summary>
        /// Gets the minimum resistance.
        /// </summary>
        public double MinimumResistance { get; private set; }

        /// <summary>
        /// Gets the maximum resistance.
        /// </summary>
        public double MaximumResistance { get; private set; }

        /// <summary>
        /// Gets the real resistance.
        /// </summary>
        public double RealResistance { get; private set; }

        /// <summary>
        /// Gets resistor information.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetResistorInformation()
        {
            var outputString = string.Empty;
            outputString += $"the minimum resistance is {this.MinimumResistance = this.CalculateMin():N1}{Environment.NewLine}";
            outputString += $"the maximum resistance is {this.MaximumResistance = this.CalculateMax():N1}{Environment.NewLine}";
            outputString += $"the real resistance is {this.RealResistance = this.CalculateReal():N1}{Environment.NewLine}";
            return outputString;
        }

        /// <summary>
        /// The multiply.
        /// </summary>
        /// <param name="Digits">
        /// The Digits.
        /// </param>
        /// <param name="Multiplier">
        /// The Multiplier.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private double Multiply(double Digits, double Multiplier)
        {
            return digits * Math.Pow(10, multiplier);
        }

        /// <summary>
        /// The calculate min.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private double CalculateMin()
        {
            
            double digits = this.DigitBandOne.Digit * 10 + this.DigitBandTwo.Digit;
            double resistance = this.Multiply(digits, double.Parse(this.MultiplierBand.Multiplier[this.MultiplierBand.Multiplier.Length - 1].ToString()));
            resistance = resistance - (resistance * this.ToleranceBand.Tolerance / 100);
            return resistance;
        }

        /// <summary>
        /// The calculate min.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private double CalculateMax()
        {
            double digits = this.DigitBandOne.Digit * 10 + this.DigitBandTwo.Digit;
            double resistance = this.Multiply(digits, double.Parse(this.MultiplierBand.Multiplier[this.MultiplierBand.Multiplier.Length - 1].ToString()));
            resistance = resistance + (resistance * this.ToleranceBand.Tolerance / 100);
            return resistance;
        }

        /// <summary>
        /// The calculate real.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private double CalculateReal()
        {
            var rangeUpper = this.ToleranceBand.Tolerance;
            var rangeLower = this.ToleranceBand.Tolerance * -1;
            Random randomTolerance = new Random();
            var number = randomTolerance.NextDouble() * (rangeUpper - rangeLower) + rangeLower;
            double digits = this.DigitBandOne.Digit * 10 + this.DigitBandTwo.Digit;
            double resistance = this.Multiply(digits, double.Parse(this.MultiplierBand.Multiplier[this.MultiplierBand.Multiplier.Length - 1].ToString()));
            resistance = resistance - (resistance * number);
            return resistance;
        }
        
    }
}

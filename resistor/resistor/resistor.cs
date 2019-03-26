using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resistor
{
    using System.Diagnostics;

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

        public Band()
        {
        }

        public string Color { get; set; }

        public double Digit { get; set;}

        public string Multiplier { get; set; }

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

        private double Multiply(double digits, double Multiplier)
        {
            return digits * Math.Pow(10, Multiplier);
        }

        /// <summary>
        /// The calculate min.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private double CalculateMin()
        {
            //double Resistance = 
        }

        /// <summary>
        /// The calculate min.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private double CalculateMax()
        {

        }

        /// <summary>
        /// The calculate real.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private double CalculateReal()
        {

        }

        /// <summary>
        /// The get resistor information.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetResistorInformation()
        {

        }

    }
}

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
        public Band(string GivenColor, string GivenDigit, string GivenMultiplier, string GivenTolerance)
        {
            this.Color = GivenColor;
            this.Digit = GivenDigit;
            this.Multiplier = GivenMultiplier;
            this.Tolerance = GivenTolerance;
        }

        public Band()
        {
        }

        public string Color { get; set; }

        public string Digit { get; set; }

        public string Multiplier { get; set; }

        public string Tolerance { get; set; } 
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
   
        public double 

    }
}

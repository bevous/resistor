// Lewis Nordan
// Resistor
namespace Resistor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// The form 1.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// The bands.
        /// </summary>
        private List<Band> Bands = new List<Band>();

        /// <summary>
        /// My resistor.
        /// </summary>
        private Resistor MyResistor = new Resistor();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            this.ReadBandsFile();
            this.BindToControls();
        }

        /// <summary>
        /// Reads the bands file.
        /// </summary>
        private void ReadBandsFile()
        {
            var Line = string.Empty;
            System.IO.StreamReader File =
                new System.IO.StreamReader(@"BandData.txt");
            while ((Line = File.ReadLine()) != null)
            {
                this.Bands.Add(
                    new Band(
                        Line,
                        Line = File.ReadLine(),
                        Line = File.ReadLine(),
                    Line = File.ReadLine()));
                
            }

            File.Close();
        }

        /// <summary>
        /// Binds the list to the controls.
        /// </summary>
        private void BindToControls()
        {
            var BandDigitQuery = (from band in this.Bands where band.Digit.CompareTo(double.MinValue) != 0 select band).ToList();
            this.BandOneComboBox.DataSource = BandDigitQuery;
            this.BandOneComboBox.DisplayMember = "color";

            var BandDigitQuery2 = (from band in this.Bands where band.Digit.CompareTo(double.MinValue) != 0 select band).ToList();
            this.BandTwoComboBox.DataSource = BandDigitQuery2;
            this.BandTwoComboBox.DisplayMember = "color";

            var BandMultiplierQuery = (from band in this.Bands where band.Multiplier != "NA" select band).ToList();
            this.BandThreeComboBox.DataSource = BandMultiplierQuery;
            this.BandThreeComboBox.DisplayMember = "color";

            var BandToleranceQuery = (from band in this.Bands where band.Tolerance != double.MinValue select band).ToList();
            this.BandFourComboBox.DataSource = BandToleranceQuery;
            this.BandFourComboBox.DisplayMember = "color";
        }

        /// <summary>
        /// The generate button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.MyResistor.DigitBandOne = this.BandOneComboBox.SelectedItem as Band;

            this.MyResistor.DigitBandTwo = this.BandTwoComboBox.SelectedItem as Band;

            this.MyResistor.MultiplierBand = this.BandThreeComboBox.SelectedItem as Band;

            this.MyResistor.ToleranceBand = this.BandFourComboBox.SelectedItem as Band;

            this.ResultRichTextBox.Text = this.MyResistor.GetResistorInformation();
        }
    }
}

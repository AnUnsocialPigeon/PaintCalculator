/// <summary>
/// Jake Turrell
/// Started: 14/07/2021
/// Start: 20:20
/// Finish: 20:50 V1
/// 
/// V2:
/// Start: 21:08
/// Finish: 12:23
/// </summary>
using System.Windows;

namespace Borwell_Software_Challenge___Paint_Calculator__GUI_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            // Start
            InitializeComponent();
        }


        /// <summary>
        /// When the submit button is pressed on MainWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_BTN_Click(object sender, RoutedEventArgs e) {
            // Var init.
            // For storing the data, and also for storing bools of what is valid.
            // This can be used later for more advanced error checking
            bool[] baValids = {
                float.TryParse(Width_TXTBOX.Text, out float fWidth),
                float.TryParse(Length_TXTBOX.Text, out float fLength),
                float.TryParse(Height_TXTBOX.Text, out float fHeight)
            };


            // Upon success -> All are valid reals > 0
            if (baValids[0] && baValids[1] && baValids[2] && fWidth > 0 && fLength > 0 && fHeight > 0) {
                // Calculations (Taken from CLI)
                float fFloorArea = fWidth * fLength;
                float fPaint = 2 * (fWidth + fLength) * fHeight;
                float fVolume = fWidth * fLength * fHeight;

                // Display 
                Results_TXTBLOCK.Text = "Results: " +
                    "\nFloor Area: " + fFloorArea +
                    "m²\nPaint for Walls: " + fPaint +
                    "m²\nRoom Volume: " + fVolume + "m³";
                // Reset all other boxes
                Width_TXTBOX.Text = "";
                Length_TXTBOX.Text = "";
                Height_TXTBOX.Text = "";
            }

            // Upon failure
            else {
                MessageBox.Show(caption: "Error", button: MessageBoxButton.OK,
                    messageBoxText: "Given data was in an incorrect format.\nPlease enter numbers only.\nNumbers cannot be 0 or below."
                );
            }

        }

        /// <summary>
        /// Reset Button pressed
        /// Will reset all boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_BTN_Click(object sender, RoutedEventArgs e) {

            // RESETTTTTTT
            Results_TXTBLOCK.Text = "Results: ";
            Width_TXTBOX.Text = "";
            Length_TXTBOX.Text = "";
            Height_TXTBOX.Text = "";
        }

    }
}   
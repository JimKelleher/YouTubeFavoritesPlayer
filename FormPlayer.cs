using System;
using System.Windows.Forms;
using YouTubeFavorites;

namespace YouTubeFavoritesPlayer
{
    public partial class FormPlayer : Form
    {
        // NOTE: All processing, including the GUI, is implemented
        // from this module:
        YouTubeFavorites.YouTubeFavorites youTubeFavorites;

        // This is the main form of the application:
        public FormPlayer()
        {
            // Framework:
            InitializeComponent();

            // Instantiate the Favorites Player:
            youTubeFavorites = new YouTubeFavorites.YouTubeFavorites();

            // Register all of the GUI controls to the Player.  NOTE: These controls will either:
            // 1) drive on-line processing or 2) be driven by batch processing.
            Form FormPlayer = this;
            youTubeFavorites.RegisterFormControls
            (
              ref FormPlayer, ref dataGridViewResults,

              ref groupBox1, ref radioButtonDataSrcYoutubeFavorites, ref radioButtonDataSrcJimradio, ref radioButtonDataSrcImportFile,

              ref groupBox2, ref radioButtonSortDateSaved, ref radioButtonSortTitle, ref radioButtonSortRandomly,
              ref textBoxYoutubeFavoritesChannel, ref textBoxSearchCriteria,
              ref buttonRetrieve, ref buttonSelectAll, ref buttonPlay, ref buttonDelete, ref buttonExport

            // NOTE: buttonAbout is the About Button which requires no run-time modification
            );
        }

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            youTubeFavorites.Retrieve();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            youTubeFavorites.SelectAll();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            youTubeFavorites.Play();
        }

        // Delete button:
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            youTubeFavorites.Delete();
        }

        // About button:
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // Open the About window as a modal dialog:
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        // Export button:
        private void buttonExport_Click(object sender, EventArgs e)
        {
            youTubeFavorites.ExportAsCsvFile();
        }

        // Form load:
        private void FormPlayer_Load(object sender, EventArgs e)
        {
            youTubeFavorites.FormLoadInit();
        }

        // Required by the framework:
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
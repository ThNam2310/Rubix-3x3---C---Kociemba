namespace VirtualRubiksCube
{
    public partial class ScrambleDialog : Form
    {
        #region Properties
        public int NumberOfMoves = 20;
        public bool IncludeMiddleLayerRotation = false;
        #endregion

        #region Constructor
        public ScrambleDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region Method
        #endregion

        private void numberOfMovesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

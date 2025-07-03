namespace VirtualRubiksCube
{
    partial class AboutBox : Form
    {
        #region Constructor
        public AboutBox()
        {
            InitializeComponent();
            LoadTextFile(@"A:\VirtualRubiksCube-master (1)\about.txt"); // Gọi phương thức để tải nội dung file vào TextBox
        }
        private void LoadTextFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath)) // Kiểm tra xem file có tồn tại không
                {
                    textBoxDescription.Text = File.ReadAllText(filePath);
                }
                else
                {
                    textBoxDescription.Text = "File not found: " + filePath;
                }
            }
            catch (Exception ex)
            {
                textBoxDescription.Text = "Error loading file: " + ex.Message;
            }
        }
        #endregion
    }
}
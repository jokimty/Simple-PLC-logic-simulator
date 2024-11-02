namespace Simulator
{
    #region #Initialization variables

    #endregion

    public partial class Simulator : Form
    {
        public Simulator()
        {
            InitializeComponent();
            //Make the app fill the whole screen -taskbar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; this.WindowState = FormWindowState.Maximized;
            InitializeUIElements();
        }
        private void InitializeUIElements()
        {

        }



        #region
        private void btnChooseIOs_Click(object sender, EventArgs e)
        {

        }
        private void linkToGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Opens the link to the github repository
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/jokimty/Simple-PLC-logic-simulator/tree/main",
                UseShellExecute = true
            });
        }
        private void btnSaveToFiles_Click(object sender, EventArgs e)
        {
            //Likely to be unimplemented for a while.
        }
        private void btnStartStopSimulation_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

using System;

namespace Simulator
{
    #region #Initialize instance variables

    #endregion
    public partial class Simulator : Form
    {
        public Simulator()
        {
            InitializeComponent();
            //Make the app fill the whole screen except the taskbar.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; this.WindowState = FormWindowState.Maximized;
            //This will also trigger the Simulator_Resize eventhandler to call the PositionUIElements method.
            //PositionUIElements(this.Width, this.Height);
        }

        #region #UI elements
        private void PositionUIElements(int width, int height)
        {

        }
        private void CreateInputSwitches(int numberOfInputs)
        {
            for (int i = 0; i < numberOfInputs; i++)
            {

            }
        }
        private void CalculateSwitchSize(int numberOfInputs)
        {
        }
        #endregion






        #region #Eventhandlers
        private void btnChooseIOs_Click(object sender, EventArgs e)
        {
            try
            {
                int inputNumbers = Convert.ToInt32(txtInputNumber.Text);
                int outputNumbers = Convert.ToInt32(txtOutputNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Only enter numbers.");
                txtInputNumber.Clear();
                txtOutputNumber.Clear();
                return;
            }



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
        private void Simulator_Resize(object sender, EventArgs e)
        {
            //This seems agressive, try to find a better way / test this quite a lot. 
            PositionUIElements(this.Width, this.Height);
            //MessageBox.Show("Test!"); //This testing message is also very agressive.
        }
        #endregion
    }
}

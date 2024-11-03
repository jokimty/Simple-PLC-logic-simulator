namespace Simulator
{
    internal class InputButton
    {

        private bool state { get; set; }
        private Button? btnToggleState { get; set; }

        public InputButton(Button button)
        {
            state = false;
            btnToggleState = button;

            btnToggleState.Click += toggleState;
        }
        public void toggleState(object sender, EventArgs e)
        {
            state = !state;
        }
    }
}

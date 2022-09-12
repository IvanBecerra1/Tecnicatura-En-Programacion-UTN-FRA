namespace formApp_01
{
    public partial class isLabelText : Form
    {
        public isLabelText()
        {
            InitializeComponent();

            this.labelText.Visible = false;
        }

        private void idButton_Click(object sender, EventArgs e)
        {

            this.labelText.Visible = true;

        }

    }
}
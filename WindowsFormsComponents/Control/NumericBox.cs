
namespace CustomControl
{
    public partial class NumericBox : NumericUpDown
    {
        public NumericBox()
        {
            Controls[0].Visible = false;
        }

        protected override void OnTextBoxResize(object source, EventArgs e)
        {
            Controls[1].Width = Width - 4;
        }
    }
}


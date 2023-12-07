using System.Drawing.Drawing2D;

namespace CustomControl
{
    public class FlatRoundButton : Button
    {
        // Attributes
        public Color HoverBackColorEnter;
        public Color HoverBackColorLeave;

        // Contructor
        public FlatRoundButton()
        {
            // Set-up button's attributes
            Text = "";
            HoverBackColorEnter = Color.White;
            HoverBackColorLeave = Color.WhiteSmoke;

            // Registers button's events
            MouseEnter += OnMouseEnterButton;
            MouseLeave += OnMouseLeaveButton;
        }

        // On mouse enter event
        private void OnMouseEnterButton(object? sender, EventArgs e)
        {
            BackColor = HoverBackColorEnter;
        }

        // On mouse leave event
        private void OnMouseLeaveButton(object? sender, EventArgs e)
        {
            BackColor = HoverBackColorLeave;
        }

        // On paint event
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            Region = new Region(grPath);
            base.OnPaint(e);
        }
    }

    class FlatTitleBar : Panel
    {
        // Attributes
        private FlatRoundButton? Btn_Minimize;
        private FlatRoundButton? Btn_Close;

        // Contructor
        public FlatTitleBar()
        {
            // Title bar
            Dock = DockStyle.Top;
            BackColor = Color.FromArgb(50, 50, 50);
            Size = new Size(800, 40);
            Margin = new Padding(0);

            // Stores the button's normal colour temporally
            Color ButtonNormalColor = Color.FromArgb(80, 168, 45);

            // Creates button minimize
            Btn_Minimize = CreateButton(new Point(730, 0), ButtonNormalColor);
            Btn_Minimize.HoverBackColorEnter = Color.FromArgb(80, 161, 45);
            Btn_Minimize.HoverBackColorLeave = ButtonNormalColor;
            Btn_Minimize.Click += Btn_Hide_Click;
            Controls.Add(Btn_Minimize);

            // Updates the button's normal colour
            ButtonNormalColor = Color.FromArgb(200, 80, 45);

            // Creates button close
            Btn_Close = CreateButton(new Point(760, 0), ButtonNormalColor);
            Btn_Close.HoverBackColorEnter = Color.FromArgb(255, 80, 45);
            Btn_Close.HoverBackColorLeave = ButtonNormalColor;
            Btn_Close.Click += Btn_Close_Click;
            Controls.Add(Btn_Close);
        }

        // Creates a default title bar's button
        private FlatRoundButton CreateButton(Point Location, Color Color)
        {
            FlatRoundButton Btn_Generic = new FlatRoundButton();
            Btn_Generic.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_Generic.BackColor = Color;
            Btn_Generic.Cursor = Cursors.Hand;
            Btn_Generic.FlatAppearance.BorderSize = 0;
            Btn_Generic.FlatStyle = FlatStyle.Flat;
            Btn_Generic.ForeColor = Color.WhiteSmoke;
            Btn_Generic.Location = Location;
            Btn_Generic.Size = new Size(40, 40);
            Btn_Generic.TabStop = false;
            return Btn_Generic;
        }

        // Button's minimize event
        private void Btn_Hide_Click(object? sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Minimized;
        }

        // Button's close event
        private void Btn_Close_Click(object? sender, EventArgs e)
        {
            FindForm().Close();
        }
    }
}

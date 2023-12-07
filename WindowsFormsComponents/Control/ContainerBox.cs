using System.Windows.Forms;

namespace CustomControl
{
    public class ContainerBox : Panel
    {
        // Attributes
        public string title = "Container Box";
        private bool opened = false;

        private Label header;
        private FlowLayoutPanel background;
        private Button button;
        private ushort defaultHeight;

        public ContainerBox()
        {
            defaultHeight = 250;

            // Master
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Size = new Size(128, 26);
            MinimumSize = new Size(128, 26);
            MaximumSize = new Size(250, 250);

            // Header
            header = new Label();
            header.Text = title;
            header.BackColor = Color.FromArgb(40, 40, 40);
            header.ForeColor = Color.White;
            header.Location = new Point(1, 2);
            Controls.Add(header);

            // Background
            background = new FlowLayoutPanel();
            background.BackColor = Color.FromArgb(40, 40, 40);
            background.Dock = DockStyle.Top;
            background.RightToLeft = RightToLeft.Yes;
            background.Margin = new Padding(0);
            background.Size = new Size(128, 25);
            background.MinimumSize = new Size(128, 26);
            background.MaximumSize = new Size(250, 250);
            Controls.Add(background);

            // Button
            button = new Button();
            button.BackColor = Color.FromArgb(80, 100, 200);
            button.FlatStyle = FlatStyle.Flat;
            button.Cursor = Cursors.Hand;
            button.Size = new Size(24, 24);
            button.Margin = new Padding(0);
            button.Location = new Point(Size.Width - button.Size.Width, 0);
            button.Click += OnClick;
            background.Controls.Add(button);
        }

        // Button's mouse click event
        void OnClick(object? sender, EventArgs e)
        {
            // Open state
            if (!opened)
            {
                Size = new Size(Size.Width, defaultHeight);
                opened = true;
            }

            // Close state
            else
            {
                Size = new Size(Size.Width, 26);
                opened = false;
            }
        }
    }
}

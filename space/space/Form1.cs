namespace space
{
    public partial class Form1 : Form
    {
        private int speed = 15;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            space1.Top += speed;
            space2.Top += speed;

            if(space1.Top >= 720)
            {
                space1.Top = 0;
                space2.Top = -720;
            }
        }
    }
}

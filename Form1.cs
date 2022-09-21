namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const int V = 0;
        private int _ticks;
        private int _clicks;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = $"Terry Clicks: {_clicks}";
            _clicks++;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = button1.BackColor;
            button1.BackColorChanged += (s, e) => {
                button1.FlatAppearance.MouseOverBackColor = button1.BackColor;
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer foe
            _ticks++;
            label1.Text = "Time: " + _ticks;

            if(_ticks == 200)
            {
                timer1.Stop();
                label1.Text = "Game Over Bruh.";
                label2.Text = $"You clicked {_clicks} Terries.";
                _ticks= 0;
                MessageBox.Show("You suck. LOL."); 
                if(_clicks >= 50)
                {
                    MessageBox.Show("Actually damn you got 50+. You did alright.");
                }
                if(_clicks >= 100)
                {
                    MessageBox.Show("Ok NVM you got 100+. You actually did pretty good.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this will reset the game
            timer1.Stop();
            _clicks = 0;
            _ticks = 0;
            label1.Text = "Time: 0";
            label2.Text = "Terry Clicks: ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "Mungus.wav";
                player.Play();

        }
    }
}
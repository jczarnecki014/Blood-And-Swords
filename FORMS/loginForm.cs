using Blood_and_Swords.FORMS;
namespace Blood_and_Swords
{
    public partial class loginForm : Form
    {
        System.Media.SoundPlayer backgroundMusic= new System.Media.SoundPlayer();
        public loginForm()
        {
            InitializeComponent();
            backgroundMusic.SoundLocation = "loginPanelSound.wav";
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            backgroundMusic.Play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreatNewAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }
    }
}
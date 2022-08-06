using Blood_and_Swords.FORMS;
namespace Blood_and_Swords
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            new BackgroundMusic("loginPanelSound");
        }

        private void CreatNewAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register(this).Show();
        }

        private void AppExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(Authentication.Start(LoginTextBox.Text,PasswordTextBox.Text))
            {
                dbAcces newSql = new dbAcces();
                User user = newSql.GetUser(LoginTextBox.Text);
                this.Hide();
                new UserPanelForm(user).Show();
            }
            else{
                MessageBox.Show("Nie uda³o siê");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_and_Swords.FORMS
{
    public partial class Register : Form
    {
        loginForm loginForm{ get; set; }
        private Avatar SelectedAvatar { get; set; }
        public Register(loginForm LoginForm)
        {
            InitializeComponent();
            this.loginForm = LoginForm;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void AppExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if(UserNameTextBox.Text == "" || UserEmailTextBox.Text == "" || PasswordTextBox.Text == "" || ConfirmedPasswordTextBox.Text == "" || ChampNameTextBox.Text == "" || ChampionKindgdomTextBox.Text =="" || SelectedAvatar is null)
            {
                MessageBox.Show("Please type value into every inputs","EmptyInputsWarn");
            }
            else
            {
                RegisterSystem newUser = new RegisterSystem(UserNameTextBox.Text, PasswordTextBox.Text, ConfirmedPasswordTextBox.Text,UserEmailTextBox.Text,ChampNameTextBox.Text,SelectedAvatar);
                bool inputsCorrectnes=newUser.CheckInputsCorrectnes();
                if(inputsCorrectnes)
                {
                    newUser.RegisterUser();
                    this.Close();
                    loginForm.Show();
                    new SuccesRegisterInfoForm().Show();
                }
                else{
                    MessageBox.Show("The form was fill in bad way. Please make sure that passwords are same  or email syntax is mistake free ");
                }
            }
        }

        public void setAvatar(Avatar avatar)
        {
            SelectedAvatar = avatar;
            AvatarFacePictureBox.ImageLocation = @"..\..\..\IMG\Avatars\70x70\" + avatar.AvatarImgSrc;
            AvatarStoryTextBox.Text = avatar.AvatarStory;
        }

        private void AvatarFace_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AvatarSelection(this).Show();
        }
    }
}


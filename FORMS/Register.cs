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

    }
}


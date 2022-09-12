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
    public partial class FighArena : Form
    {   
        User user;
        public FighArena(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FighArena_Load(object sender, EventArgs e)
        {
            
        }

        private void SkipFightButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class UserPanelForm : Form
    {
        public UserPanelForm()
        {
            InitializeComponent();
            ArrmorPictureBoxHoverEfect();
        }
        private void ArrmorPictureBoxHoverEfect()
        {
            void pictureElementMouseHover(object ?sender, EventArgs e)
            { 
                PictureBox picture = (PictureBox) sender;
                picture.BackColor = Color.FromArgb(200, 20,20,20);
            }
            void pictureElementMouseLevel(object ?sender, EventArgs e)
            {
                PictureBox picture = (PictureBox) sender;
                picture.BackColor = Color.FromArgb(220,67,85,84);
            }
            foreach(PictureBox element in UserSetPanel.Controls)
            {
                element.MouseHover += new System.EventHandler(pictureElementMouseHover);
                element.MouseLeave += new System.EventHandler(pictureElementMouseLevel); 
            }
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {
            new BackgroundMusic("UserPanelForm");
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FighArena().Show();
        }
    }
}

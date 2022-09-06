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
    public partial class AvatarSelection : Form
    {
        Register registerForm;
        List<Avatar> avatars;
        PictureBox ?selectedPictureBox;
        Avatar selectedAvatar;
        public AvatarSelection(Register registerForm)
        {
            InitializeComponent();
            this.registerForm = registerForm;
            dbAcces newSql = new dbAcces();
            avatars = newSql.GetAvatars();
        }
        private void LoadAvatars()
        {
            int Xmargin = 30;
            int Ymargin = 10;
            foreach(Avatar avatar in avatars)
            {
                PictureBox avatarIcon = new PictureBox();
                avatarIcon.ImageLocation = @"..\..\..\IMG\Avatars\70x70\" + avatar.AvatarImgSrc;
                avatarIcon.Size = new Size(110,110);
                avatarIcon.Location = new Point(Xmargin,Ymargin);
                avatarIcon.Name = avatar.AvatarId.ToString();
                Xmargin+=110 + 10;
                if (Xmargin == 390)
                {
                    Xmargin = 30;
                    Ymargin += 110 + 10;
                }
                avatarIcon.Click += new EventHandler(this.SelectAvatar);
                AvatarsImgPanel.Controls.Add(avatarIcon);
            }
        }
        private void SelectAvatar(object sender, EventArgs e)
        {
            PictureBox selectedPicture = (PictureBox) sender;
            if(selectedPictureBox is not null)
            {
                this.selectedPictureBox.BorderStyle = BorderStyle.None;
            }
            selectedPicture.BorderStyle = BorderStyle.FixedSingle;

            foreach(Avatar avatar in avatars)
            {
                if(avatar.AvatarId.ToString() == selectedPicture.Name)
                {
                    StoryTextBox.Text = avatar.AvatarStory;
                    AvatarName.Text = avatar.AvatarName;
                    selectedAvatar = avatar;
                    SkillPictureBoxOne.ImageLocation = @"..\..\..\" + avatar.AvatarSkillOne.SkillImgSrc;
                    SkillPictureBoxTwo.ImageLocation = @"..\..\..\" + avatar.AvatarSkillTwo.SkillImgSrc;
                    SkillPictureBoxThree.ImageLocation = @"..\..\..\" + avatar.AvatarSkillThree.SkillImgSrc;
                }
            }
            this.selectedPictureBox = selectedPicture;
            
        }
        private void AvatarSelection_Load(object sender, EventArgs e)
        {
            this.LoadAvatars();
        }

        private void AppExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm.Show();
        }

        private void SelectAvatarBTN_Click(object sender, EventArgs e)
        {
            if(selectedAvatar is not null)
            {
                this.Hide();
                registerForm.setAvatar(selectedAvatar);
                registerForm.Show();
                
            }
            else
            { 
                MessageBox.Show("Please select avatar");
            }
        }

        private void FillSkillPopup(Skill avatarSkill)
        {
            PopupSkillImg.ImageLocation = @"..\..\..\" + avatarSkill.SkillImgSrc;
            PopupSkillName.Text = avatarSkill.SkillName;
            PopupSkillDescription.Text = avatarSkill.SkillDescription;
            PopupSkillCategoryLabel.Text = SkillCategoryDescription.GetDescription(avatarSkill);
        }

        private void SkillPictureBox_MouseEnter(object sender, EventArgs e)
        {
            if(selectedAvatar is not null)
            {
                PictureBox icon = (PictureBox)sender;
                Popup.Visible = true;
                Popup.Location = new Point((icon.Parent.Location.X + icon.Location.X + icon.Width - Popup.Width), icon.Parent.Location.Y - 250);
                switch (icon.Name)
                {
                    case "SkillPictureBoxOne":
                       FillSkillPopup(selectedAvatar.AvatarSkillOne);
                    break;

                    case "SkillPictureBoxTwo":
                        FillSkillPopup(selectedAvatar.AvatarSkillTwo);
                    break;

                    case "SkillPictureBoxThree":
                        FillSkillPopup(selectedAvatar.AvatarSkillThree);
                    break;
                }
            }

        }

        private void SkillPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Popup.Visible = false;
        }
    }
}

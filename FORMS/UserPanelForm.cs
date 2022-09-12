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
        User user;
        Panel PlayerPanel;
        private int i;
        public UserPanelForm(User user)
        {
            InitializeComponent();
            ArrmorPictureBoxHoverEfect();
            this.user = user;
            Player.trackPlayer.SetTimer(PlayerTimer);
            PlayerTimer.Start();
        }
        private void ArrmorPictureBoxHoverEfect()
        {
            void pictureElementMouseHover(object ?sender, EventArgs e)
            { 
                PictureBox picture = (PictureBox) sender;
                picture.BackColor = Color.FromArgb(220,88, 48, 18);
            }
            void pictureElementMouseLevel(object ?sender, EventArgs e)
            {
                PictureBox picture = (PictureBox) sender;
                picture.BackColor = Color.FromArgb(220,118, 78, 48);
            }
            foreach(PictureBox element in UserSetPanel.Controls)
            {
                element.MouseEnter += new System.EventHandler(pictureElementMouseHover);
                element.MouseLeave += new System.EventHandler(pictureElementMouseLevel); 
            }
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {   

            Player.trackPlayer.SetTrack(1); //Number 0-X Index in List of tracks
            PlayerPanel = Player.trackPlayer.GetPlayerPanel(new Point(1284,95));
            Player.trackPlayer.Play();
            LoadingPanel.Visible = true; 
            //Create Panel


            this.Controls.Add(PlayerPanel);


            //Set ChampionInfoPanel
            AvatarpictureBox.ImageLocation = @"..\..\..\IMG\Avatars\200x200\" + user.Avatar.AvatarImgSrc;
            ChampionNameLabel.Text = user.ChampionName;
            //Set avatar skill pictureBoxes
            AvatarSkillOnePictureBoxOne.ImageLocation = @"..\..\..\" + user.Avatar.AvatarSkillOne.SkillImgSrc;
            AvatarSkillTwoPictureBoxOne.ImageLocation = @"..\..\..\" + user.Avatar.AvatarSkillTwo.SkillImgSrc;
            AvatarSkillThreePictureBoxOne.ImageLocation = @"..\..\..\" + user.Avatar.AvatarSkillThree.SkillImgSrc;

            AvatarSkillOnePictureBoxTwo.ImageLocation = @"..\..\..\" + user.Avatar.AvatarSkillOne.SkillImgSrc;
            AvatarSkillTwoPictureBoxTwo.ImageLocation = @"..\..\..\" + user.Avatar.AvatarSkillTwo.SkillImgSrc;
            AvatarSkillThreePictureBoxTwo.ImageLocation = @"..\..\..\" + user.Avatar.AvatarSkillThree.SkillImgSrc;

            //Set avatar skill Labels
            AvatarSkillOneNameLabel.Text = user.Avatar.AvatarSkillOne.SkillName;
            AvatarSkillTwoNameLabel.Text = user.Avatar.AvatarSkillTwo.SkillName;
            AvatarSkillThreeNameLabel.Text = user.Avatar.AvatarSkillThree.SkillName;

            //Set avatar skill forces
            AvatarSkillOneForceDesciption.Text = SkillCategoryDescription.GetDescription(user.Avatar.AvatarSkillOne);
            AvatarSkillTwoForceDesciption.Text = SkillCategoryDescription.GetDescription(user.Avatar.AvatarSkillTwo);
            AvatarSkillThreeForceDesciption.Text = SkillCategoryDescription.GetDescription(user.Avatar.AvatarSkillThree);


            //Set user stats
            UserNameLabel.Text = user.UserName;
            AvatarLvLabel.Text = user.ChampionLevel.ToString();
            AvatarFightsNumberLabel.Text = user.ChampionStats.Fights.ToString();
            AvatarWinsNumberLabel.Text = user.ChampionStats.Wins.ToString();
            AvatarLoseNumberLabel.Text = user.ChampionStats.Lose.ToString();

            //Set user attributes
            AvatarStrengthForceLabel.Text = user.ChampionAttributes.Strength.ToString();
            AvatarHealthForceLabel.Text = user.ChampionAttributes.Health.ToString();
            AvatarIntelligenceForceLabel.Text = user.ChampionAttributes.Inteligence.ToString();
            AvatarDexterityForceLabel.Text = user.ChampionAttributes.Dexterity.ToString();

            //Set user Sets ( equipment )
            HeadImg.ImageLocation = @"..\..\.." + user.ChampionSet.HelmetId.ItemImgSrc;
            BodyArmorImg.ImageLocation = @"..\..\.." + user.ChampionSet.BodyArmorId.ItemImgSrc;
            GloveImg.ImageLocation = @"..\..\.." + user.ChampionSet.GlovesId.ItemImgSrc;
            RingImg.ImageLocation = @"..\..\.." + user.ChampionSet.RingId.ItemImgSrc;
            BottomImg.ImageLocation = @"..\..\.." + user.ChampionSet.BottomId.ItemImgSrc;
            DeffenceImg.ImageLocation = @"..\..\.." + user.ChampionSet.DefenceWeapon.ItemImgSrc;
            WeaponImg.ImageLocation = @"..\..\.." + user.ChampionSet.Weapon.ItemImgSrc;
            
            MessageBox.Show($"Witaj {user.UserName}");
            LoadingPanel.Visible = false;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FightBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            new FighArena(user).Show();
        }

        private void PlayerTimer_Tick(object sender, EventArgs e)
        {
            Player.trackPlayer.PlayerTimer();
        }
        
    }
}

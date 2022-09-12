using System.Media;
using System;
using System.Diagnostics;
      public class Player
    {
            private List<Sounds>Tracks;
            private Sounds ActualTrack;
            private Panel playerPanel;
            private SoundPlayer newPlayer;
            private bool PlayerIsActive = false;
            private System.Windows.Forms.Timer formTimer;
            public static Player trackPlayer { get;set;}
            public decimal TrackTime { get; set; }   

 
            public Player(List<Sounds>Tracks)
            {
                this.Tracks = Tracks;
                this.CreatePlayer();
                newPlayer = new SoundPlayer();
                trackPlayer = this;
            }
            private void CreatePlayer()
            {
                //Create Panel
                Panel player = new Panel();
                player.Name = "MusicPlayer";
                player.BackColor = Color.FromArgb(200,49,29,14);
                player.Size = new Size(250,80);
                player.BorderStyle = BorderStyle.FixedSingle;
                //Track album IMG
                PictureBox trackAlbum = new PictureBox();
                trackAlbum.Name = "TrackAlbumPictureBox";
                trackAlbum.Size = new Size(70,70);
                trackAlbum.Location = new Point(10,5);
                //Track Title
                Label trackTitle = new Label();
                trackTitle.Name = "TrackTitleLabel";
                trackTitle.Font = new Font("Yu Gothic", 11.25F,FontStyle.Regular, GraphicsUnit.Point);
                trackTitle.Location = new Point(90,5);
                trackTitle.ForeColor = SystemColors.Control;
                trackTitle.BackColor = Color.Transparent;
                //trackStatusToggle
                PictureBox trackStatusToggle = new PictureBox();
                trackStatusToggle.Name = "TrackStatusTogglePictureBox";
                trackStatusToggle.ImageLocation = "..\\..\\..\\IMG\\Sounds\\pause_icon.png";
                trackStatusToggle.Location = new Point(108,37);
                trackStatusToggle.Size = new Size(30,30);
                trackStatusToggle.BackColor = Color.Transparent;
                trackStatusToggle.Click += new EventHandler(this.PlayerToggler);
                //nextTrackBtn
                PictureBox nextTrackBtn = new PictureBox();
                nextTrackBtn.Name = "NextTrackBtnPictureBox";
                nextTrackBtn.ImageLocation = "..\\..\\..\\IMG\\Sounds\\next_icon.png";
                nextTrackBtn.Location = new Point(156,37);
                nextTrackBtn.Size = new Size(30,30);
                nextTrackBtn.BackColor = Color.Transparent;
                nextTrackBtn.Click += new EventHandler(this.NextTrack);
                //TimerLabel
                Label TrackTimer = new Label();
                TrackTimer.Name = "TrackTimerLabel";
                TrackTimer.Font = new Font("Times New Roman", 9F,FontStyle.Regular, GraphicsUnit.Point);
                TrackTimer.Text = "00:00";
                TrackTimer.Location = new Point(204,44);
                TrackTimer.ForeColor = SystemColors.Control;
                TrackTimer.BackColor = Color.Transparent;

                //Timer

                //Add controls to panel
                player.Controls.Add(trackAlbum);
                player.Controls.Add(trackTitle);
                player.Controls.Add(trackStatusToggle);
                player.Controls.Add(nextTrackBtn);
                player.Controls.Add(TrackTimer);

                this.playerPanel = player;

            }
            public void SetTrack(int TrackListIndex)
            {
                this.ActualTrack = Tracks[TrackListIndex];
                newPlayer.SoundLocation = ActualTrack.MusicSource;


                PictureBox trackAlbum = (PictureBox)playerPanel.Controls[0];
                Label trackTitle = (Label)playerPanel.Controls[1];
                Label trackTimer = (Label)playerPanel.Controls[4];
                trackAlbum.ImageLocation = ActualTrack.MusicBackGroundSrc;
                trackTitle.Width = 160;
                trackTitle.Text = ActualTrack.MusicTitle;
            }
            public void SetTimer(System.Windows.Forms.Timer formTimer)
            {
                this.formTimer = formTimer;
            }
            public void Play()
            {
                newPlayer.Play();
                PlayerIsActive = true;
            }
            private void PlayerToggler(object sender, EventArgs e)
            {
                PictureBox ToggleBtn = (PictureBox) sender;
                if(PlayerIsActive)
                {
                    TrackTime = 0;
                    newPlayer.Stop();
                    formTimer.Stop();
                    ToggleBtn.ImageLocation = "..\\..\\..\\IMG\\Sounds\\player_icon.png";
                }
                else
                {
                    newPlayer.Play();
                    formTimer.Start();
                    ToggleBtn.ImageLocation = "..\\..\\..\\IMG\\Sounds\\pause_icon.png";
                }
                PlayerIsActive = !PlayerIsActive;
            }
            public Panel GetPlayerPanel(Point location)
            {
                playerPanel.Location = location;
                return playerPanel;
            }
            private void NextTrack(object sender, EventArgs e)
            {
                int TracksNumbers = Tracks.Count;
                int ActualTrackIndex = (ActualTrack.IdMusic);
                if(ActualTrackIndex < TracksNumbers-1)
                {
                    SetTrack(ActualTrackIndex+1);
                }
                else
                {
                    ActualTrack = Tracks[0];
                    SetTrack(1);
                }
                TrackTime = 0;
                this.Play();
            }
            public void PlayerTimer()
            {
                //Timer(text timer)
                decimal minutes = Math.Floor(TrackTime/60);
                decimal seconds = (TrackTime - (minutes*60));
                playerPanel.Controls[4].Text = "0"+(minutes.ToString()) + ":" + ((seconds<10)?$"0{seconds}":$"{seconds}");
                //Music changing
                if(TrackTime > ActualTrack.MusicSecondLength)
                {
                    NextTrack(new object(),new EventArgs());
                }
                TrackTime++;
            }
    }


using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System.IO;
using LMediaPlayer = LibVLCSharp.Shared.MediaPlayer;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        private LibVLC libVLC;
        private LMediaPlayer mediaPlayer;
        private List<string> playList = new List<string>();
        private string currentMediaPlaying = string.Empty;
        private int currentMediaIndex = -1;

        public Form1()
        {
            InitializeComponent();
            InitializeVlc();
        }

        private void UpdatePlayListUi()
        {
            playlistLbox.Items.Clear();
            playlistLbox.Items.AddRange(playList.ToArray());
            playlistLbox.SelectedIndex = 0;
        }

        private void InitializeVlc()
        {
            Core.Initialize();
            libVLC = new LibVLC();
            mediaPlayer = new LMediaPlayer(libVLC);
            videoView1.MediaPlayer = mediaPlayer;
            mediaPlayer.TimeChanged += MediaPlayer_TimeChanged;
        }

        private void MediaPlayer_TimeChanged(object? sender, MediaPlayerTimeChangedEventArgs e)
        {
            if (mediaPlayer.Media != null)
            {
                TimeSpan currentTime = TimeSpan.FromMilliseconds(e.Time);
                TimeSpan totalDuration = TimeSpan.FromMilliseconds(mediaPlayer.Media.Duration);

                // Mettre à jour le Label pour afficher le temps en cours
                var timeLblValue = currentTime.ToString(@"hh\:mm\:ss") + " / " + totalDuration.ToString(@"hh\:mm\:ss");
                Invoke(new Action(() =>
                {
                    timeLbl.Text = timeLblValue;
                }));

                // Mettre à jour le ProgressBar avec la progression de la lecture
                if (mediaPlayer.Media.Duration > 0)
                {
                    double progress = (double)e.Time / mediaPlayer.Media.Duration;
                    var prograssBarValue = (int)(progress * timelineProgBar.Maximum);
                    Invoke(new Action(() =>
                    {
                        timelineProgBar.Value = prograssBarValue;
                    }));
                }
            }
        }

        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            if(mediaPlayer.State == VLCState.Playing)
            {
                mediaPlayer.Pause();
            }

            if(mediaPlayer.State == VLCState.Paused)
            {
                mediaPlayer.Play();
            }

            if(mediaPlayer.State == VLCState.Stopped)
            {
                mediaPlayer.Play();
            }
        }

        private void PlayMedia()
        {
            if (playlistLbox.SelectedItem != null)
            {
                mediaPlayer.Stop();
                var path = playlistLbox.SelectedItem.ToString();
                var uri = new Uri(path);
                var media = new Media(libVLC, uri);
                mediaPlayer.Play(media);
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            mediaPlayer.Stop();
            timeLbl.Text = "00:00:00 / 00:00:00";
            timelineProgBar.Value = 0;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Fichiers MP4 et MP3|*.mp4;*.mp3|Tous les fichiers|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFiles = new List<string>(openFileDialog.FileNames);
                playList.AddRange(selectedFiles);
                UpdatePlayListUi();
            }
        }

        private void playlistLbox_DoubleClick(object sender, EventArgs e)
        {
            PlayMedia();
        }

        private void playlistLbox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void playlistLbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playlistLbox.SelectedIndex != -1)
            {
                currentMediaPlaying = playlistLbox.SelectedItem.ToString();
                currentMediaIndex = playlistLbox.SelectedIndex;
                PlayMedia();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (playlistLbox.SelectedIndex == -1 && playlistLbox.Items.Count > 0)
            {
                playlistLbox.SetSelected(0, true);
                return;
            }

            if (playlistLbox.SelectedIndex != -1 && playlistLbox.Items.Count > 0)
            {
                var nextIndex = currentMediaIndex + 1;
                if (nextIndex < playlistLbox.Items.Count)
                {
                    playlistLbox.SetSelected(nextIndex, true);
                }
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (playlistLbox.SelectedIndex != -1 && playlistLbox.Items.Count > 0)
            {
                var prevIndex = currentMediaIndex - 1;
                if (prevIndex >= 0 && prevIndex < playlistLbox.Items.Count)
                {
                    playlistLbox.SetSelected(prevIndex, true);
                }
            }
        }
    }
}
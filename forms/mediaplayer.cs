using mediaplayer.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mediaplayer
{
    
    public partial class mediaplayer : Form
    {
        private readonly string filepath;
        public mediaplayer()
        {
            InitializeComponent();

            axWindowsMediaPlayer.uiMode = "none";
            axWindowsMediaPlayer.settings.volume = trackBar.Value;
            filepath = "";
            LoadDefaultVideoBox(filepath);
        }

        public mediaplayer(string path)
        {
            InitializeComponent();

            axWindowsMediaPlayer.uiMode = "none";
            axWindowsMediaPlayer.settings.volume = trackBar.Value;
            LoadDefaultVideoBox(path);
            filepath = path;
        }

        private string MakeFormatedPart(int part)
        {
            if (part < 10) { return "0" + part.ToString(); }

            return part.ToString();
        }

        private string MakeFormatedTimeStr(int hours, int minutes, int seconds)
        {
            string hour_str = MakeFormatedPart(hours);
            string minute_str = MakeFormatedPart(minutes);
            string second_str = MakeFormatedPart(seconds);

            return $"{hour_str}:{minute_str}:{second_str}";
        }

        private void ChangeTimePosition(Label track,int seconds)
        {
            int hours = seconds / 3600;
            seconds -= hours * 3600;
            int minutes = seconds / 60;
            seconds -= minutes * 60;

            track.Text = MakeFormatedTimeStr(hours, minutes, seconds);
        }

        private void play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.settings.volume = trackBar.Value;
        }

        private void progressBar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.currentPosition = progressBar.Value;

            int seconds = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;
            ChangeTimePosition(start_track, seconds);
            int seconds_end = (int)axWindowsMediaPlayer.Ctlcontrols.currentItem.duration;
            ChangeTimePosition(end_track, seconds_end - seconds);
        }

        private void openbutton_Click(object sender, EventArgs e)
        {
            try
            {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            
            axWindowsMediaPlayer.URL = openFileDialog1.FileName;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void playlistbutton_Click(object sender, EventArgs e)
        {
            playlistcreate frm = new playlistcreate();
            frm.Show();
            axWindowsMediaPlayer.settings.volume = 0;
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar.Maximum = (int)axWindowsMediaPlayer.currentMedia.duration;
                progressBar.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;

                if (axWindowsMediaPlayer == null)
                {
                    start_track.Text = "0:00:00";
                }
                else
                {
                    int seconds = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;
                    ChangeTimePosition(start_track, seconds);
                    int seconds_end = (int)axWindowsMediaPlayer.Ctlcontrols.currentItem.duration;
                    ChangeTimePosition(end_track, seconds_end - seconds);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void LoadDefaultVideoBox(string filePath) {

            try
            {
                string[] videoPaths = File.ReadAllLines(filePath);

                videoBox.Items.Clear();

                int id = 1;
                foreach (string path in videoPaths)
                {
                    videoBox.Items.Add($"{id++}) {path.Split('\\').Last()} \n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void videoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] videoPaths = File.ReadAllLines(filepath);
                axWindowsMediaPlayer.URL = videoPaths[videoBox.SelectedIndex];

                axWindowsMediaPlayer.Ctlcontrols.play();
                timer1.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            using (StreamWriter add_path = new StreamWriter(File.Open(filepath, FileMode.Append)))
            {
                add_path.WriteLine(openFileDialog1.FileName);
            }
            LoadDefaultVideoBox(filepath);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deletevideo frm = new deletevideo(filepath);
            frm.ShowDialog();
            axWindowsMediaPlayer.settings.volume = 0;
            this.Hide();
        }
    }
}

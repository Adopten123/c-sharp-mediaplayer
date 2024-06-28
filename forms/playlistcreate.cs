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

namespace mediaplayer.forms
{
    public partial class playlistcreate : Form
    {
        private const string path = "";
        public playlistcreate()
        {
            InitializeComponent();
        }

        private void playlistcreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            mediaplayer frm = new mediaplayer();
            frm.Show();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string playlistname = playlist_textBox.Text+"_playlist.txt";
            string result_path = path + "\\" + playlistname;

            if (File.Exists(result_path))
            {
                MessageBox.Show("Плейлист с таким названием уже существует в системе.","Внимание!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                using (File.Create(result_path)) { };

                this.Hide();
                mediaplayer frm = new mediaplayer(result_path);
                frm.Show();
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            string playlistname = playlist_textBox.Text + "_playlist.txt";
            string result_path = path + "\\" + playlistname;

            if (!File.Exists(result_path))
            {
                MessageBox.Show("Плейлист с таким названием не существует в системе.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                mediaplayer frm = new mediaplayer(result_path);
                frm.Show();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string playlistname = playlist_textBox.Text + "_playlist.txt";
            string result_path = path + "\\" + playlistname;
            if (!File.Exists(result_path))
            {
                MessageBox.Show("Плейлист с таким названием не существует в системе.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                File.Delete(result_path);
            }
            
        }
    }
}

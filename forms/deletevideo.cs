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
    public partial class deletevideo : Form
    {
        private readonly string filepath;
        public deletevideo(string path)
        {
            InitializeComponent();
            filepath = path;
            UdpateWindow();
        }

        private void UdpateWindow()
        {
            pathRichTextBox.Clear();

            string[] pathes = File.ReadAllText(filepath).Split(new char[] { '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries);
            int id = 1;
            foreach (string path in pathes) { 
                pathRichTextBox.Text += $"{id++} {path.Split('\\').Last()} \n";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> pathes = File.ReadAllText(filepath).Split(new char[] { '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries).ToList();

                int num = int.Parse(delete_textbox.Text);
                pathes.RemoveAt(num - 1);

                File.WriteAllText(filepath, string.Empty);
                using (StreamWriter add_path = new StreamWriter(File.Open(filepath, FileMode.Append)))
                {
                    foreach (string path in pathes)
                    {
                        add_path.WriteLine(path);
                    }
                }

                UdpateWindow();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletevideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            mediaplayer frm = new mediaplayer(filepath);
            frm.Show();
        }
    }
}

using System.Drawing.Imaging;

namespace CueGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex=0;
            comboBox2.SelectedIndex = 1;
        }

        private void multipleArtistChk_CheckedChanged(object sender, EventArgs e)
        {
            if (multipleArtistChk.Checked)
            {
                artistTxt.Enabled = false;
                label1.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                firstSeparatorTxt.Enabled = true;

            }
            else
            {
                artistTxt.Enabled = true;
                label1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                firstSeparatorTxt.Enabled = false;
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string filePath = new string("");
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Music files (*.mp3; *.flac; *.wav; *.ape)|*.mp3; *.flac; *.wav; *.ape";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            filenameTxt.Text = filePath;
            playlistNameTxt.Text = Operations.RemoveExtension(System.IO.Path.GetFileName(filePath));
        }

        private void artistTxt_Click(object sender, EventArgs e)
        {
            artistTxt.Text = string.Empty;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Clear();
            int order;
            if(comboBox1.SelectedIndex== 0) order= 0;
            else order= 1;

            if(String.IsNullOrEmpty(filenameTxt.Text) || String.IsNullOrEmpty(playlistNameTxt.Text) || String.IsNullOrEmpty(rawTextTxt.Text))
            {
                MessageBox.Show("Not all necessary information is filled in ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(yearTxt.Text, out _) && !String.IsNullOrEmpty(yearTxt.Text))
            {
                MessageBox.Show("Not a valid year ", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (multipleArtistChk.Checked)
            {
                resultTxt.Text = Operations.GenerateMultipleArtists(System.IO.Path.GetFileName(filenameTxt.Text), rawTextTxt.Text, firstSeparatorTxt.Text, playlistNameTxt.Text, order, endingTimestampChk.Checked, orderedListChk.Checked ,genreTxt.Text, yearTxt.Text);
            }
            else if (!multipleArtistChk.Checked)
            {
                resultTxt.Text = Operations.GenerateSingleArtist(System.IO.Path.GetFileName(filenameTxt.Text), artistTxt.Text, rawTextTxt.Text, playlistNameTxt.Text, order, endingTimestampChk.Checked, orderedListChk.Checked, genreTxt.Text, yearTxt.Text);
            }
        }

        private void genreTxt_Click(object sender, EventArgs e)
        {
            genreTxt.Text = string.Empty;
        }

        private void yearTxt_Click(object sender, EventArgs e)
        {
            yearTxt.Text = string.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) { comboBox2.SelectedIndex = 1; }
            else { comboBox2.SelectedIndex = 0; }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) { comboBox1.SelectedIndex = 1; }
            else { comboBox1.SelectedIndex = 0; }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(resultTxt.Text))
            {
                string savedFile = Operations.RemoveExtension(filenameTxt.Text) + ".cue";
                File.WriteAllText(savedFile, resultTxt.Text);
            }
            else
            {
                MessageBox.Show("Generated data is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
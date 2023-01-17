namespace CueGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectBtn = new System.Windows.Forms.Button();
            this.filenameTxt = new System.Windows.Forms.TextBox();
            this.artistTxt = new System.Windows.Forms.TextBox();
            this.multipleArtistChk = new System.Windows.Forms.CheckBox();
            this.rawTextTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.firstSeparatorTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.resultTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playlistNameTxt = new System.Windows.Forms.TextBox();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.endingTimestampChk = new System.Windows.Forms.CheckBox();
            this.orderedListChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(12, 12);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 0;
            this.selectBtn.Text = "Select file";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // filenameTxt
            // 
            this.filenameTxt.Location = new System.Drawing.Point(93, 12);
            this.filenameTxt.Name = "filenameTxt";
            this.filenameTxt.Size = new System.Drawing.Size(397, 23);
            this.filenameTxt.TabIndex = 1;
            // 
            // artistTxt
            // 
            this.artistTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.artistTxt.Location = new System.Drawing.Point(717, 59);
            this.artistTxt.Name = "artistTxt";
            this.artistTxt.Size = new System.Drawing.Size(205, 23);
            this.artistTxt.TabIndex = 2;
            this.artistTxt.Click += new System.EventHandler(this.artistTxt_Click);
            // 
            // multipleArtistChk
            // 
            this.multipleArtistChk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.multipleArtistChk.AutoSize = true;
            this.multipleArtistChk.Location = new System.Drawing.Point(928, 63);
            this.multipleArtistChk.Name = "multipleArtistChk";
            this.multipleArtistChk.Size = new System.Drawing.Size(106, 19);
            this.multipleArtistChk.TabIndex = 3;
            this.multipleArtistChk.Text = "Multiple Artists";
            this.multipleArtistChk.UseVisualStyleBackColor = true;
            this.multipleArtistChk.CheckedChanged += new System.EventHandler(this.multipleArtistChk_CheckedChanged);
            // 
            // rawTextTxt
            // 
            this.rawTextTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rawTextTxt.Location = new System.Drawing.Point(12, 213);
            this.rawTextTxt.Name = "rawTextTxt";
            this.rawTextTxt.Size = new System.Drawing.Size(460, 524);
            this.rawTextTxt.TabIndex = 4;
            this.rawTextTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select the right order and separator(for best results include spacebars):";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Artist Name",
            "Song Name"});
            this.comboBox1.Location = new System.Drawing.Point(12, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Artist Name",
            "Song Name"});
            this.comboBox2.Location = new System.Drawing.Point(190, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // firstSeparatorTxt
            // 
            this.firstSeparatorTxt.Enabled = false;
            this.firstSeparatorTxt.Location = new System.Drawing.Point(139, 142);
            this.firstSeparatorTxt.Name = "firstSeparatorTxt";
            this.firstSeparatorTxt.Size = new System.Drawing.Size(45, 23);
            this.firstSeparatorTxt.TabIndex = 9;
            this.firstSeparatorTxt.Text = "  - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Raw text:";
            // 
            // generateBtn
            // 
            this.generateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateBtn.Location = new System.Drawing.Point(17, 750);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 28);
            this.generateBtn.TabIndex = 12;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // resultTxt
            // 
            this.resultTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTxt.Location = new System.Drawing.Point(556, 213);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(460, 524);
            this.resultTxt.TabIndex = 13;
            this.resultTxt.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Playlist name:";
            // 
            // playlistNameTxt
            // 
            this.playlistNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistNameTxt.Location = new System.Drawing.Point(717, 13);
            this.playlistNameTxt.Name = "playlistNameTxt";
            this.playlistNameTxt.Size = new System.Drawing.Size(205, 23);
            this.playlistNameTxt.TabIndex = 15;
            // 
            // genreTxt
            // 
            this.genreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genreTxt.Location = new System.Drawing.Point(717, 100);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(205, 23);
            this.genreTxt.TabIndex = 17;
            this.genreTxt.Click += new System.EventHandler(this.genreTxt_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Genre:";
            // 
            // yearTxt
            // 
            this.yearTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearTxt.Location = new System.Drawing.Point(717, 148);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(205, 23);
            this.yearTxt.TabIndex = 19;
            this.yearTxt.Click += new System.EventHandler(this.yearTxt_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Year:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(928, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "(Optional)";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(928, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "(Optional)";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(928, 755);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cue file:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(622, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Artist Name:";
            // 
            // endingTimestampChk
            // 
            this.endingTimestampChk.AutoSize = true;
            this.endingTimestampChk.Location = new System.Drawing.Point(12, 50);
            this.endingTimestampChk.Name = "endingTimestampChk";
            this.endingTimestampChk.Size = new System.Drawing.Size(310, 19);
            this.endingTimestampChk.TabIndex = 25;
            this.endingTimestampChk.Text = "Raw text includes timestamps for when the song ends";
            this.endingTimestampChk.UseVisualStyleBackColor = true;
            // 
            // orderedListChk
            // 
            this.orderedListChk.AutoSize = true;
            this.orderedListChk.Location = new System.Drawing.Point(12, 88);
            this.orderedListChk.Name = "orderedListChk";
            this.orderedListChk.Size = new System.Drawing.Size(309, 19);
            this.orderedListChk.TabIndex = 26;
            this.orderedListChk.Text = "Raw text is an ordered list i.e. the songs are numbered";
            this.orderedListChk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 802);
            this.Controls.Add(this.orderedListChk);
            this.Controls.Add(this.endingTimestampChk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playlistNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstSeparatorTxt);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rawTextTxt);
            this.Controls.Add(this.multipleArtistChk);
            this.Controls.Add(this.artistTxt);
            this.Controls.Add(this.filenameTxt);
            this.Controls.Add(this.selectBtn);
            this.Name = "Form1";
            this.Text = "Cue File Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button selectBtn;
        private TextBox filenameTxt;
        private TextBox artistTxt;
        private CheckBox multipleArtistChk;
        private RichTextBox rawTextTxt;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox firstSeparatorTxt;
        private Label label2;
        private Button generateBtn;
        private RichTextBox resultTxt;
        private Label label3;
        private TextBox playlistNameTxt;
        private TextBox genreTxt;
        private Label label4;
        private TextBox yearTxt;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button saveBtn;
        private Label label8;
        private Label label9;
        private CheckBox endingTimestampChk;
        private CheckBox orderedListChk;
    }
}
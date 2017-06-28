namespace YouTubeFavoritesPlayer
{
    partial class FormPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayer));
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSortRandomly = new System.Windows.Forms.RadioButton();
            this.radioButtonSortTitle = new System.Windows.Forms.RadioButton();
            this.radioButtonSortDateSaved = new System.Windows.Forms.RadioButton();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.textBoxSearchCriteria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.radioButtonDataSrcYoutubeFavorites = new System.Windows.Forms.RadioButton();
            this.radioButtonDataSrcJimradio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxYoutubeFavoritesChannel = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioButtonDataSrcImportFile = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.ColumnHeadersVisible = false;
            this.dataGridViewResults.Location = new System.Drawing.Point(13, 317);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResults.Size = new System.Drawing.Size(319, 443);
            this.dataGridViewResults.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSortRandomly);
            this.groupBox2.Controls.Add(this.radioButtonSortTitle);
            this.groupBox2.Controls.Add(this.radioButtonSortDateSaved);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonSortRandomly
            // 
            this.radioButtonSortRandomly.AutoSize = true;
            this.radioButtonSortRandomly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSortRandomly.Location = new System.Drawing.Point(17, 68);
            this.radioButtonSortRandomly.Name = "radioButtonSortRandomly";
            this.radioButtonSortRandomly.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSortRandomly.TabIndex = 2;
            this.radioButtonSortRandomly.TabStop = true;
            this.radioButtonSortRandomly.Text = "randomly";
            this.radioButtonSortRandomly.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortTitle
            // 
            this.radioButtonSortTitle.AutoSize = true;
            this.radioButtonSortTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSortTitle.Location = new System.Drawing.Point(17, 44);
            this.radioButtonSortTitle.Name = "radioButtonSortTitle";
            this.radioButtonSortTitle.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSortTitle.TabIndex = 1;
            this.radioButtonSortTitle.TabStop = true;
            this.radioButtonSortTitle.Text = "by title";
            this.radioButtonSortTitle.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortDateSaved
            // 
            this.radioButtonSortDateSaved.AutoSize = true;
            this.radioButtonSortDateSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSortDateSaved.Location = new System.Drawing.Point(17, 20);
            this.radioButtonSortDateSaved.Name = "radioButtonSortDateSaved";
            this.radioButtonSortDateSaved.Size = new System.Drawing.Size(92, 17);
            this.radioButtonSortDateSaved.TabIndex = 0;
            this.radioButtonSortDateSaved.TabStop = true;
            this.radioButtonSortDateSaved.Text = "by date saved";
            this.radioButtonSortDateSaved.UseVisualStyleBackColor = true;
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieve.Location = new System.Drawing.Point(13, 288);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(61, 23);
            this.buttonRetrieve.TabIndex = 4;
            this.buttonRetrieve.Text = "Retrieve";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectAll.Location = new System.Drawing.Point(78, 288);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(60, 23);
            this.buttonSelectAll.TabIndex = 5;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(142, 288);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(41, 23);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // textBoxSearchCriteria
            // 
            this.textBoxSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCriteria.Location = new System.Drawing.Point(126, 200);
            this.textBoxSearchCriteria.Multiline = true;
            this.textBoxSearchCriteria.Name = "textBoxSearchCriteria";
            this.textBoxSearchCriteria.Size = new System.Drawing.Size(206, 50);
            this.textBoxSearchCriteria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter search criteria separated by commas:";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(288, 288);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(45, 23);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // radioButtonDataSrcYoutubeFavorites
            // 
            this.radioButtonDataSrcYoutubeFavorites.AutoSize = true;
            this.radioButtonDataSrcYoutubeFavorites.Location = new System.Drawing.Point(106, 19);
            this.radioButtonDataSrcYoutubeFavorites.Name = "radioButtonDataSrcYoutubeFavorites";
            this.radioButtonDataSrcYoutubeFavorites.Size = new System.Drawing.Size(115, 17);
            this.radioButtonDataSrcYoutubeFavorites.TabIndex = 0;
            this.radioButtonDataSrcYoutubeFavorites.TabStop = true;
            this.radioButtonDataSrcYoutubeFavorites.Text = "YouTube Favorites";
            this.radioButtonDataSrcYoutubeFavorites.UseVisualStyleBackColor = true;
            // 
            // radioButtonDataSrcJimradio
            // 
            this.radioButtonDataSrcJimradio.AutoSize = true;
            this.radioButtonDataSrcJimradio.Location = new System.Drawing.Point(106, 76);
            this.radioButtonDataSrcJimradio.Name = "radioButtonDataSrcJimradio";
            this.radioButtonDataSrcJimradio.Size = new System.Drawing.Size(133, 17);
            this.radioButtonDataSrcJimradio.TabIndex = 3;
            this.radioButtonDataSrcJimradio.TabStop = true;
            this.radioButtonDataSrcJimradio.Text = "JimRadio (hosted SQL)";
            this.radioButtonDataSrcJimradio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxYoutubeFavoritesChannel);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.radioButtonDataSrcImportFile);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.radioButtonDataSrcJimradio);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.radioButtonDataSrcYoutubeFavorites);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Channel:";
            // 
            // textBoxYoutubeFavoritesChannel
            // 
            this.textBoxYoutubeFavoritesChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYoutubeFavoritesChannel.Location = new System.Drawing.Point(173, 42);
            this.textBoxYoutubeFavoritesChannel.Name = "textBoxYoutubeFavoritesChannel";
            this.textBoxYoutubeFavoritesChannel.Size = new System.Drawing.Size(134, 18);
            this.textBoxYoutubeFavoritesChannel.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::YouTubeFavoritesPlayer.Properties.Resources.text_file;
            this.pictureBox3.Location = new System.Drawing.Point(67, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 36);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // radioButtonDataSrcImportFile
            // 
            this.radioButtonDataSrcImportFile.AutoSize = true;
            this.radioButtonDataSrcImportFile.Location = new System.Drawing.Point(105, 115);
            this.radioButtonDataSrcImportFile.Name = "radioButtonDataSrcImportFile";
            this.radioButtonDataSrcImportFile.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDataSrcImportFile.TabIndex = 4;
            this.radioButtonDataSrcImportFile.TabStop = true;
            this.radioButtonDataSrcImportFile.Text = "Import file";
            this.radioButtonDataSrcImportFile.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YouTubeFavoritesPlayer.Properties.Resources.JimRadio;
            this.pictureBox2.Location = new System.Drawing.Point(16, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 17);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YouTubeFavoritesPlayer.Properties.Resources.YouTubeFavorites;
            this.pictureBox1.Location = new System.Drawing.Point(55, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(239, 288);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(45, 23);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(187, 288);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(48, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 767);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearchCriteria);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.buttonRetrieve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSortRandomly;
        private System.Windows.Forms.RadioButton radioButtonSortTitle;
        private System.Windows.Forms.RadioButton radioButtonSortDateSaved;
        private System.Windows.Forms.Button buttonRetrieve;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox textBoxSearchCriteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.RadioButton radioButtonDataSrcYoutubeFavorites;
        private System.Windows.Forms.RadioButton radioButtonDataSrcJimradio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioButtonDataSrcImportFile;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxYoutubeFavoritesChannel;
        private System.Windows.Forms.Button buttonDelete;
    }
}


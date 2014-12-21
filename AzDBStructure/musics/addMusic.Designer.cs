namespace AzDBStructure.musics
{
    partial class addMusic
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
            this.components = new System.ComponentModel.Container();
            this.lyric = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.album = new System.Windows.Forms.ComboBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicStore = new AzDBStructure.MusicStore();
            this.genersTableAdapter = new AzDBStructure.MusicStoreTableAdapters.genersTableAdapter();
            this.albumsTableAdapter = new AzDBStructure.MusicStoreTableAdapters.albumsTableAdapter();
            this.composer = new System.Windows.Forms.ComboBox();
            this.artistsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistsTableAdapter = new AzDBStructure.MusicStoreTableAdapters.artistsTableAdapter();
            this.poet = new System.Windows.Forms.ComboBox();
            this.gener = new System.Windows.Forms.ComboBox();
            this.genersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.price = new System.Windows.Forms.TextBox();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aToolStrip = new System.Windows.Forms.ToolStrip();
            this.aToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genersBindingSource)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.aToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lyric
            // 
            this.lyric.Location = new System.Drawing.Point(12, 157);
            this.lyric.Multiline = true;
            this.lyric.Name = "lyric";
            this.lyric.Size = new System.Drawing.Size(304, 87);
            this.lyric.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 20);
            this.textBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // album
            // 
            this.album.DataSource = this.albumsBindingSource;
            this.album.DisplayMember = "name";
            this.album.FormattingEnabled = true;
            this.album.Location = new System.Drawing.Point(80, 38);
            this.album.Name = "album";
            this.album.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.album.Size = new System.Drawing.Size(236, 21);
            this.album.TabIndex = 29;
            this.album.ValueMember = "Id";
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "albums";
            this.albumsBindingSource.DataSource = this.musicStore;
            // 
            // musicStore
            // 
            this.musicStore.DataSetName = "MusicStore";
            this.musicStore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genersTableAdapter
            // 
            this.genersTableAdapter.ClearBeforeFill = true;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // composer
            // 
            this.composer.DataSource = this.artistsBindingSource1;
            this.composer.DisplayMember = "name";
            this.composer.FormattingEnabled = true;
            this.composer.Location = new System.Drawing.Point(80, 65);
            this.composer.Name = "composer";
            this.composer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.composer.Size = new System.Drawing.Size(236, 21);
            this.composer.TabIndex = 31;
            this.composer.ValueMember = "Id";
            // 
            // artistsBindingSource1
            // 
            this.artistsBindingSource1.DataMember = "artists";
            this.artistsBindingSource1.DataSource = this.musicStore;
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "artists";
            this.artistsBindingSource.DataSource = this.musicStore;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // poet
            // 
            this.poet.DataSource = this.artistsBindingSource;
            this.poet.DisplayMember = "name";
            this.poet.FormattingEnabled = true;
            this.poet.Location = new System.Drawing.Point(80, 97);
            this.poet.Name = "poet";
            this.poet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.poet.Size = new System.Drawing.Size(236, 21);
            this.poet.TabIndex = 33;
            this.poet.ValueMember = "Id";
            this.poet.SelectedIndexChanged += new System.EventHandler(this.poet_SelectedIndexChanged);
            // 
            // gener
            // 
            this.gener.DataSource = this.genersBindingSource;
            this.gener.DisplayMember = "name";
            this.gener.FormattingEnabled = true;
            this.gener.Location = new System.Drawing.Point(80, 130);
            this.gener.Name = "gener";
            this.gener.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gener.Size = new System.Drawing.Size(236, 21);
            this.gener.TabIndex = 35;
            this.gener.ValueMember = "Id";
            // 
            // genersBindingSource
            // 
            this.genersBindingSource.DataMember = "geners";
            this.genersBindingSource.DataSource = this.musicStore;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(80, 250);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(236, 20);
            this.price.TabIndex = 36;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(390, 25);
            this.fillBy1ToolStrip.TabIndex = 38;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click_1);
            // 
            // aToolStrip
            // 
            this.aToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripButton});
            this.aToolStrip.Location = new System.Drawing.Point(0, 0);
            this.aToolStrip.Name = "aToolStrip";
            this.aToolStrip.Size = new System.Drawing.Size(390, 25);
            this.aToolStrip.TabIndex = 39;
            this.aToolStrip.Text = "aToolStrip";
            this.aToolStrip.Visible = false;
            // 
            // aToolStripButton
            // 
            this.aToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aToolStripButton.Name = "aToolStripButton";
            this.aToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.aToolStripButton.Text = "a";
            this.aToolStripButton.Click += new System.EventHandler(this.aToolStripButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 253);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "قیمت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 133);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "سبک";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 105);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "شاعر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 73);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "آهنگ ساز";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 160);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "شعر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 46);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "آلبوم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "عنوان";
            // 
            // addMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 335);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aToolStrip);
            this.Controls.Add(this.price);
            this.Controls.Add(this.gener);
            this.Controls.Add(this.poet);
            this.Controls.Add(this.composer);
            this.Controls.Add(this.album);
            this.Controls.Add(this.lyric);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Name = "addMusic";
            this.Text = "موزیک جدید";
            this.Load += new System.EventHandler(this.addMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genersBindingSource)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.aToolStrip.ResumeLayout(false);
            this.aToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lyric;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox album;
        private MusicStore musicStore;
        private System.Windows.Forms.BindingSource genersBindingSource;
        private MusicStoreTableAdapters.genersTableAdapter genersTableAdapter;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private MusicStoreTableAdapters.albumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.ComboBox composer;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private MusicStoreTableAdapters.artistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.ComboBox poet;
        private System.Windows.Forms.ComboBox gener;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.BindingSource artistsBindingSource1;
        private System.Windows.Forms.ToolStrip aToolStrip;
        private System.Windows.Forms.ToolStripButton aToolStripButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
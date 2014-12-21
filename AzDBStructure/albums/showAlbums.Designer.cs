namespace AzDBStructure.albums
{
    partial class showAlbums
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showAlbums));
            this.musicStore = new AzDBStructure.MusicStore();
            this.albumsAndArtistViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsAndArtistViewTableAdapter = new AzDBStructure.MusicStoreTableAdapters.AlbumsAndArtistViewTableAdapter();
            this.tableAdapterManager = new AzDBStructure.MusicStoreTableAdapters.TableAdapterManager();
            this.albumsAndArtistViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.albumsAndArtistViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.albumsAndArtistViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.musicStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsAndArtistViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsAndArtistViewBindingNavigator)).BeginInit();
            this.albumsAndArtistViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsAndArtistViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // musicStore
            // 
            this.musicStore.DataSetName = "MusicStore";
            this.musicStore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumsAndArtistViewBindingSource
            // 
            this.albumsAndArtistViewBindingSource.DataMember = "AlbumsAndArtistView";
            this.albumsAndArtistViewBindingSource.DataSource = this.musicStore;
            // 
            // albumsAndArtistViewTableAdapter
            // 
            this.albumsAndArtistViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.albumsTableAdapter = null;
            this.tableAdapterManager.artistsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.genersTableAdapter = null;
            this.tableAdapterManager.musicsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AzDBStructure.MusicStoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // albumsAndArtistViewBindingNavigator
            // 
            this.albumsAndArtistViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.albumsAndArtistViewBindingNavigator.BindingSource = this.albumsAndArtistViewBindingSource;
            this.albumsAndArtistViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.albumsAndArtistViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.albumsAndArtistViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.albumsAndArtistViewBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.albumsAndArtistViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.albumsAndArtistViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.albumsAndArtistViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.albumsAndArtistViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.albumsAndArtistViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.albumsAndArtistViewBindingNavigator.Name = "albumsAndArtistViewBindingNavigator";
            this.albumsAndArtistViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.albumsAndArtistViewBindingNavigator.Size = new System.Drawing.Size(633, 25);
            this.albumsAndArtistViewBindingNavigator.TabIndex = 0;
            this.albumsAndArtistViewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // albumsAndArtistViewBindingNavigatorSaveItem
            // 
            this.albumsAndArtistViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.albumsAndArtistViewBindingNavigatorSaveItem.Enabled = false;
            this.albumsAndArtistViewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("albumsAndArtistViewBindingNavigatorSaveItem.Image")));
            this.albumsAndArtistViewBindingNavigatorSaveItem.Name = "albumsAndArtistViewBindingNavigatorSaveItem";
            this.albumsAndArtistViewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.albumsAndArtistViewBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // albumsAndArtistViewDataGridView
            // 
            this.albumsAndArtistViewDataGridView.AutoGenerateColumns = false;
            this.albumsAndArtistViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumsAndArtistViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn4});
            this.albumsAndArtistViewDataGridView.DataSource = this.albumsAndArtistViewBindingSource;
            this.albumsAndArtistViewDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.albumsAndArtistViewDataGridView.Location = new System.Drawing.Point(0, 25);
            this.albumsAndArtistViewDataGridView.Name = "albumsAndArtistViewDataGridView";
            this.albumsAndArtistViewDataGridView.Size = new System.Drawing.Size(633, 220);
            this.albumsAndArtistViewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "شماره";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام آلبوم";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn5.HeaderText = "نام هنرمند";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "قیمت";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "albumArt";
            this.dataGridViewImageColumn1.HeaderText = "آلبوم آرت";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "created_at";
            this.dataGridViewTextBoxColumn4.HeaderText = "تاریخ ثبت";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // showAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 365);
            this.Controls.Add(this.albumsAndArtistViewDataGridView);
            this.Controls.Add(this.albumsAndArtistViewBindingNavigator);
            this.Name = "showAlbums";
            this.Text = "showAlbums";
            this.Load += new System.EventHandler(this.showAlbums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsAndArtistViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsAndArtistViewBindingNavigator)).EndInit();
            this.albumsAndArtistViewBindingNavigator.ResumeLayout(false);
            this.albumsAndArtistViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsAndArtistViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusicStore musicStore;
        private System.Windows.Forms.BindingSource albumsAndArtistViewBindingSource;
        private MusicStoreTableAdapters.AlbumsAndArtistViewTableAdapter albumsAndArtistViewTableAdapter;
        private MusicStoreTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator albumsAndArtistViewBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton albumsAndArtistViewBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView albumsAndArtistViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;


    }
}
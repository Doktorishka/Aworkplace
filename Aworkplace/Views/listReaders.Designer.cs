namespace Aworkplace.Views
{
    partial class listReaders
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
            this.dataReaders = new System.Windows.Forms.DataGridView();
            this.deleteSelectedItemButton = new System.Windows.Forms.Button();
            this.rebuildDataGrid = new System.Windows.Forms.Button();
            this.addReaderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReaders
            // 
            this.dataReaders.AllowUserToAddRows = false;
            this.dataReaders.AllowUserToDeleteRows = false;
            this.dataReaders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReaders.Location = new System.Drawing.Point(12, 12);
            this.dataReaders.Name = "dataReaders";
            this.dataReaders.RowHeadersWidth = 51;
            this.dataReaders.RowTemplate.Height = 29;
            this.dataReaders.Size = new System.Drawing.Size(870, 342);
            this.dataReaders.TabIndex = 0;
            // 
            // deleteSelectedItemButton
            // 
            this.deleteSelectedItemButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.deleteSelectedItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteSelectedItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteSelectedItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedItemButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteSelectedItemButton.Location = new System.Drawing.Point(644, 360);
            this.deleteSelectedItemButton.Name = "deleteSelectedItemButton";
            this.deleteSelectedItemButton.Size = new System.Drawing.Size(238, 54);
            this.deleteSelectedItemButton.TabIndex = 1;
            this.deleteSelectedItemButton.Text = "Удалить читателя";
            this.deleteSelectedItemButton.UseVisualStyleBackColor = true;
            this.deleteSelectedItemButton.Click += new System.EventHandler(this.deleteSelectedItemButton_Click);
            // 
            // rebuildDataGrid
            // 
            this.rebuildDataGrid.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.rebuildDataGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rebuildDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rebuildDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rebuildDataGrid.ForeColor = System.Drawing.SystemColors.Control;
            this.rebuildDataGrid.Location = new System.Drawing.Point(329, 360);
            this.rebuildDataGrid.Name = "rebuildDataGrid";
            this.rebuildDataGrid.Size = new System.Drawing.Size(238, 54);
            this.rebuildDataGrid.TabIndex = 2;
            this.rebuildDataGrid.Text = "Обновить таблицу";
            this.rebuildDataGrid.UseVisualStyleBackColor = true;
            this.rebuildDataGrid.Click += new System.EventHandler(this.rebuildDataGrid_Click);
            // 
            // addReaderButton
            // 
            this.addReaderButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.addReaderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReaderButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addReaderButton.Location = new System.Drawing.Point(12, 360);
            this.addReaderButton.Name = "addReaderButton";
            this.addReaderButton.Size = new System.Drawing.Size(238, 54);
            this.addReaderButton.TabIndex = 3;
            this.addReaderButton.Text = "Зарегистрировать читателя";
            this.addReaderButton.UseVisualStyleBackColor = true;
            this.addReaderButton.Click += new System.EventHandler(this.addReaderButton_Click);
            // 
            // listReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 426);
            this.Controls.Add(this.addReaderButton);
            this.Controls.Add(this.rebuildDataGrid);
            this.Controls.Add(this.deleteSelectedItemButton);
            this.Controls.Add(this.dataReaders);
            this.Name = "listReaders";
            this.Text = "listReaders";
            ((System.ComponentModel.ISupportInitialize)(this.dataReaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataReaders;
        private Button deleteSelectedItemButton;
        private Button rebuildDataGrid;
        private Button addReaderButton;
    }
}
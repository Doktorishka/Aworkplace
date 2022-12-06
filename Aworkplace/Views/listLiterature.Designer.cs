namespace Aworkplace.Views
{
    partial class listLiterature
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
            this.addLiteratureButton = new System.Windows.Forms.Button();
            this.rebuildDataGrid = new System.Windows.Forms.Button();
            this.deleteSelectedItemButton = new System.Windows.Forms.Button();
            this.dataLiterature = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataLiterature)).BeginInit();
            this.SuspendLayout();
            // 
            // addLiteratureButton
            // 
            this.addLiteratureButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.addLiteratureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addLiteratureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLiteratureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLiteratureButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addLiteratureButton.Location = new System.Drawing.Point(12, 360);
            this.addLiteratureButton.Name = "addLiteratureButton";
            this.addLiteratureButton.Size = new System.Drawing.Size(238, 54);
            this.addLiteratureButton.TabIndex = 7;
            this.addLiteratureButton.Text = "Зарегистрировать экземпляр";
            this.addLiteratureButton.UseVisualStyleBackColor = true;
            this.addLiteratureButton.Click += new System.EventHandler(this.addLiteratureButton_Click);
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
            this.rebuildDataGrid.TabIndex = 6;
            this.rebuildDataGrid.Text = "Обновить таблицу";
            this.rebuildDataGrid.UseVisualStyleBackColor = true;
            this.rebuildDataGrid.Click += new System.EventHandler(this.rebuildDataGrid_Click);
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
            this.deleteSelectedItemButton.TabIndex = 5;
            this.deleteSelectedItemButton.Text = "Удалить экземпляр";
            this.deleteSelectedItemButton.UseVisualStyleBackColor = true;
            this.deleteSelectedItemButton.Click += new System.EventHandler(this.deleteSelectedItemButton_Click);
            // 
            // dataLiterature
            // 
            this.dataLiterature.AllowUserToAddRows = false;
            this.dataLiterature.AllowUserToDeleteRows = false;
            this.dataLiterature.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataLiterature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLiterature.Location = new System.Drawing.Point(12, 12);
            this.dataLiterature.Name = "dataLiterature";
            this.dataLiterature.RowHeadersWidth = 51;
            this.dataLiterature.RowTemplate.Height = 29;
            this.dataLiterature.Size = new System.Drawing.Size(870, 342);
            this.dataLiterature.TabIndex = 4;
            // 
            // listLiterature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 426);
            this.Controls.Add(this.addLiteratureButton);
            this.Controls.Add(this.rebuildDataGrid);
            this.Controls.Add(this.deleteSelectedItemButton);
            this.Controls.Add(this.dataLiterature);
            this.Name = "listLiterature";
            this.Text = "listLiterature";
            ((System.ComponentModel.ISupportInitialize)(this.dataLiterature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button addLiteratureButton;
        private Button rebuildDataGrid;
        private Button deleteSelectedItemButton;
        private DataGridView dataLiterature;
    }
}
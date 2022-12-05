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
            this.listingReaderFromButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addReaderButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReaders
            // 
            this.dataReaders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReaders.Location = new System.Drawing.Point(12, 12);
            this.dataReaders.Name = "dataReaders";
            this.dataReaders.RowHeadersWidth = 51;
            this.dataReaders.RowTemplate.Height = 29;
            this.dataReaders.Size = new System.Drawing.Size(776, 266);
            this.dataReaders.TabIndex = 0;
            // 
            // listingReaderFromButton
            // 
            this.listingReaderFromButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.listingReaderFromButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listingReaderFromButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listingReaderFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listingReaderFromButton.ForeColor = System.Drawing.SystemColors.Control;
            this.listingReaderFromButton.Location = new System.Drawing.Point(550, 284);
            this.listingReaderFromButton.Name = "listingReaderFromButton";
            this.listingReaderFromButton.Size = new System.Drawing.Size(238, 54);
            this.listingReaderFromButton.TabIndex = 1;
            this.listingReaderFromButton.Text = "Удалить читателя";
            this.listingReaderFromButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(285, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить таблицу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addReaderButton
            // 
            this.addReaderButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.addReaderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReaderButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addReaderButton.Location = new System.Drawing.Point(12, 284);
            this.addReaderButton.Name = "addReaderButton";
            this.addReaderButton.Size = new System.Drawing.Size(238, 54);
            this.addReaderButton.TabIndex = 3;
            this.addReaderButton.Text = "Зарегистрировать читателя";
            this.addReaderButton.UseVisualStyleBackColor = true;
            this.addReaderButton.Click += new System.EventHandler(this.addReaderButton_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(12, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Сохранить изменения";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.addReaderButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listingReaderFromButton);
            this.Controls.Add(this.dataReaders);
            this.Name = "listReaders";
            this.Text = "listReaders";
            ((System.ComponentModel.ISupportInitialize)(this.dataReaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataReaders;
        private Button listingReaderFromButton;
        private Button button1;
        private Button addReaderButton;
        private Button button3;
    }
}
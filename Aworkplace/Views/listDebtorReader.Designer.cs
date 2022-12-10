namespace Aworkplace.Views
{
    partial class listDebtorReader
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
            this.dataDebtor = new System.Windows.Forms.DataGridView();
            this.acceptBookFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDebtor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDebtor
            // 
            this.dataDebtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDebtor.Location = new System.Drawing.Point(12, 12);
            this.dataDebtor.Name = "dataDebtor";
            this.dataDebtor.RowHeadersWidth = 51;
            this.dataDebtor.RowTemplate.Height = 29;
            this.dataDebtor.Size = new System.Drawing.Size(776, 233);
            this.dataDebtor.TabIndex = 0;
            // 
            // acceptBookFormButton
            // 
            this.acceptBookFormButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.acceptBookFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acceptBookFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBookFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBookFormButton.ForeColor = System.Drawing.SystemColors.Control;
            this.acceptBookFormButton.Location = new System.Drawing.Point(265, 251);
            this.acceptBookFormButton.Name = "acceptBookFormButton";
            this.acceptBookFormButton.Size = new System.Drawing.Size(238, 54);
            this.acceptBookFormButton.TabIndex = 1;
            this.acceptBookFormButton.Text = "Принять книгу";
            this.acceptBookFormButton.UseVisualStyleBackColor = true;
            // 
            // listDebtorReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.acceptBookFormButton);
            this.Controls.Add(this.dataDebtor);
            this.Name = "listDebtorReader";
            this.Text = "listDebtorReader";
            ((System.ComponentModel.ISupportInitialize)(this.dataDebtor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataDebtor;
        private Button acceptBookFormButton;
    }
}
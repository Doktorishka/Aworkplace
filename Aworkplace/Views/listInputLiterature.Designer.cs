namespace Aworkplace.Views
{
    partial class listInputLiterature
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
            this.dataLiterature = new System.Windows.Forms.DataGridView();
            this.issuesBookFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLiterature)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLiterature
            // 
            this.dataLiterature.AllowUserToAddRows = false;
            this.dataLiterature.AllowUserToDeleteRows = false;
            this.dataLiterature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLiterature.Location = new System.Drawing.Point(12, 12);
            this.dataLiterature.Name = "dataLiterature";
            this.dataLiterature.ReadOnly = true;
            this.dataLiterature.RowHeadersWidth = 51;
            this.dataLiterature.RowTemplate.Height = 29;
            this.dataLiterature.Size = new System.Drawing.Size(776, 289);
            this.dataLiterature.TabIndex = 0;
            // 
            // issuesBookFormButton
            // 
            this.issuesBookFormButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.issuesBookFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.issuesBookFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issuesBookFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuesBookFormButton.ForeColor = System.Drawing.SystemColors.Control;
            this.issuesBookFormButton.Location = new System.Drawing.Point(283, 307);
            this.issuesBookFormButton.Name = "issuesBookFormButton";
            this.issuesBookFormButton.Size = new System.Drawing.Size(238, 54);
            this.issuesBookFormButton.TabIndex = 2;
            this.issuesBookFormButton.Text = "Выдать литературу";
            this.issuesBookFormButton.UseVisualStyleBackColor = true;
            this.issuesBookFormButton.Click += new System.EventHandler(this.issuesBookFormButton_Click);
            // 
            // listInputLiterature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.issuesBookFormButton);
            this.Controls.Add(this.dataLiterature);
            this.Name = "listInputLiterature";
            this.Text = "listInputLiterature";
            ((System.ComponentModel.ISupportInitialize)(this.dataLiterature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataLiterature;
        private Button issuesBookFormButton;
    }
}
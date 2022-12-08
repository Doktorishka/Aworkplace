namespace Aworkplace.Views
{
    partial class inputLiteratureFromReader
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
            this.dataReader = new System.Windows.Forms.DataGridView();
            this.dataOutputLiterature = new System.Windows.Forms.DataGridView();
            this.registerInputButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutputLiterature)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReader
            // 
            this.dataReader.AllowUserToAddRows = false;
            this.dataReader.AllowUserToDeleteRows = false;
            this.dataReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReader.Location = new System.Drawing.Point(12, 12);
            this.dataReader.Name = "dataReader";
            this.dataReader.ReadOnly = true;
            this.dataReader.RowHeadersWidth = 51;
            this.dataReader.RowTemplate.Height = 29;
            this.dataReader.Size = new System.Drawing.Size(347, 188);
            this.dataReader.TabIndex = 0;
            this.dataReader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReader_CellClick);
            // 
            // dataOutputLiterature
            // 
            this.dataOutputLiterature.AllowUserToAddRows = false;
            this.dataOutputLiterature.AllowUserToDeleteRows = false;
            this.dataOutputLiterature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutputLiterature.Location = new System.Drawing.Point(399, 12);
            this.dataOutputLiterature.Name = "dataOutputLiterature";
            this.dataOutputLiterature.ReadOnly = true;
            this.dataOutputLiterature.RowHeadersWidth = 51;
            this.dataOutputLiterature.RowTemplate.Height = 29;
            this.dataOutputLiterature.Size = new System.Drawing.Size(347, 188);
            this.dataOutputLiterature.TabIndex = 0;
            // 
            // registerInputButton
            // 
            this.registerInputButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.registerInputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerInputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerInputButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registerInputButton.Location = new System.Drawing.Point(261, 217);
            this.registerInputButton.Name = "registerInputButton";
            this.registerInputButton.Size = new System.Drawing.Size(238, 54);
            this.registerInputButton.TabIndex = 9;
            this.registerInputButton.Text = "Принять книгу";
            this.registerInputButton.UseVisualStyleBackColor = true;
            this.registerInputButton.Click += new System.EventHandler(this.registerInputButton_Click);
            // 
            // inputLiteratureFromReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 283);
            this.Controls.Add(this.registerInputButton);
            this.Controls.Add(this.dataOutputLiterature);
            this.Controls.Add(this.dataReader);
            this.Name = "inputLiteratureFromReader";
            this.Text = "inputLiteratureFromReader";
            ((System.ComponentModel.ISupportInitialize)(this.dataReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutputLiterature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataReader;
        private DataGridView dataOutputLiterature;
        private Button registerInputButton;
    }
}
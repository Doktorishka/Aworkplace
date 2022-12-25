namespace Aworkplace.Views
{
    partial class outputLiteratureForReader
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
            this.dataReaders = new System.Windows.Forms.DataGridView();
            this.dateOutputLiterature = new System.Windows.Forms.DateTimePicker();
            this.registerOutputButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLiterature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReaders)).BeginInit();
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
            this.dataLiterature.Size = new System.Drawing.Size(485, 188);
            this.dataLiterature.TabIndex = 0;
            // 
            // dataReaders
            // 
            this.dataReaders.AllowUserToAddRows = false;
            this.dataReaders.AllowUserToDeleteRows = false;
            this.dataReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReaders.Location = new System.Drawing.Point(561, 12);
            this.dataReaders.Name = "dataReaders";
            this.dataReaders.ReadOnly = true;
            this.dataReaders.RowHeadersWidth = 51;
            this.dataReaders.Size = new System.Drawing.Size(474, 188);
            this.dataReaders.TabIndex = 0;
            // 
            // dateOutputLiterature
            // 
            this.dateOutputLiterature.Location = new System.Drawing.Point(12, 240);
            this.dateOutputLiterature.Name = "dateOutputLiterature";
            this.dateOutputLiterature.Size = new System.Drawing.Size(250, 27);
            this.dateOutputLiterature.TabIndex = 1;
            // 
            // registerOutputButton
            // 
            this.registerOutputButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.registerOutputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerOutputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerOutputButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registerOutputButton.Location = new System.Drawing.Point(797, 213);
            this.registerOutputButton.Name = "registerOutputButton";
            this.registerOutputButton.Size = new System.Drawing.Size(238, 54);
            this.registerOutputButton.TabIndex = 8;
            this.registerOutputButton.Text = "Выдать литературу";
            this.registerOutputButton.UseVisualStyleBackColor = true;
            this.registerOutputButton.Click += new System.EventHandler(this.registerOutputButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дата возврата экземпляра";
            // 
            // outputLiteratureForReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerOutputButton);
            this.Controls.Add(this.dateOutputLiterature);
            this.Controls.Add(this.dataReaders);
            this.Controls.Add(this.dataLiterature);
            this.Name = "outputLiteratureForReader";
            this.Text = "outputLiteratureForReader";
            ((System.ComponentModel.ISupportInitialize)(this.dataLiterature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataLiterature;
        private DataGridView dataReaders;
        private DateTimePicker dateOutputLiterature;
        private Button registerOutputButton;
        private Label label1;
    }
}
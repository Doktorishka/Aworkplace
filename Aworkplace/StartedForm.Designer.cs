namespace Aworkplace
{
    partial class StartedForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookGroupBox = new System.Windows.Forms.GroupBox();
            this.listingBookFromButton = new System.Windows.Forms.Button();
            this.usedBookFromButton = new System.Windows.Forms.Button();
            this.registerBookFromButton = new System.Windows.Forms.Button();
            this.readerGroupBox = new System.Windows.Forms.GroupBox();
            this.listingReaderFromButton = new System.Windows.Forms.Button();
            this.listingDebtorFromButton = new System.Windows.Forms.Button();
            this.registerReaderFromButton = new System.Windows.Forms.Button();
            this.issueBookFormButton = new System.Windows.Forms.Button();
            this.acceptBookFormButton = new System.Windows.Forms.Button();
            this.titleMainForm = new System.Windows.Forms.Label();
            this.bookGroupBox.SuspendLayout();
            this.readerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookGroupBox
            // 
            this.bookGroupBox.Controls.Add(this.listingBookFromButton);
            this.bookGroupBox.Controls.Add(this.usedBookFromButton);
            this.bookGroupBox.Controls.Add(this.registerBookFromButton);
            this.bookGroupBox.Location = new System.Drawing.Point(12, 48);
            this.bookGroupBox.Name = "bookGroupBox";
            this.bookGroupBox.Size = new System.Drawing.Size(250, 208);
            this.bookGroupBox.TabIndex = 1;
            this.bookGroupBox.TabStop = false;
            this.bookGroupBox.Text = "Каталог";
            // 
            // listingBookFromButton
            // 
            this.listingBookFromButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.listingBookFromButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listingBookFromButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listingBookFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listingBookFromButton.ForeColor = System.Drawing.SystemColors.Control;
            this.listingBookFromButton.Location = new System.Drawing.Point(6, 146);
            this.listingBookFromButton.Name = "listingBookFromButton";
            this.listingBookFromButton.Size = new System.Drawing.Size(238, 54);
            this.listingBookFromButton.TabIndex = 0;
            this.listingBookFromButton.Text = "Список экземпляров";
            this.listingBookFromButton.UseVisualStyleBackColor = true;
            // 
            // usedBookFromButton
            // 
            this.usedBookFromButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.usedBookFromButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usedBookFromButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usedBookFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usedBookFromButton.ForeColor = System.Drawing.SystemColors.Control;
            this.usedBookFromButton.Location = new System.Drawing.Point(6, 86);
            this.usedBookFromButton.Name = "usedBookFromButton";
            this.usedBookFromButton.Size = new System.Drawing.Size(238, 54);
            this.usedBookFromButton.TabIndex = 0;
            this.usedBookFromButton.Text = "Экземпляр в пользовании";
            this.usedBookFromButton.UseVisualStyleBackColor = true;
            // 
            // registerBookFromButton
            // 
            this.registerBookFromButton.BackColor = System.Drawing.Color.Transparent;
            this.registerBookFromButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.registerBookFromButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerBookFromButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBookFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBookFromButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registerBookFromButton.Location = new System.Drawing.Point(6, 26);
            this.registerBookFromButton.Name = "registerBookFromButton";
            this.registerBookFromButton.Size = new System.Drawing.Size(238, 54);
            this.registerBookFromButton.TabIndex = 0;
            this.registerBookFromButton.Text = "Регистрация экземпляра";
            this.registerBookFromButton.UseVisualStyleBackColor = false;
            // 
            // readerGroupBox
            // 
            this.readerGroupBox.Controls.Add(this.listingReaderFromButton);
            this.readerGroupBox.Controls.Add(this.listingDebtorFromButton);
            this.readerGroupBox.Controls.Add(this.registerReaderFromButton);
            this.readerGroupBox.Location = new System.Drawing.Point(268, 48);
            this.readerGroupBox.Name = "readerGroupBox";
            this.readerGroupBox.Size = new System.Drawing.Size(250, 208);
            this.readerGroupBox.TabIndex = 1;
            this.readerGroupBox.TabStop = false;
            this.readerGroupBox.Text = "Читатели";
            // 
            // listingReaderFromButton
            // 
            this.listingReaderFromButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.listingReaderFromButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listingReaderFromButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listingReaderFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listingReaderFromButton.ForeColor = System.Drawing.SystemColors.Control;
            this.listingReaderFromButton.Location = new System.Drawing.Point(6, 146);
            this.listingReaderFromButton.Name = "listingReaderFromButton";
            this.listingReaderFromButton.Size = new System.Drawing.Size(238, 54);
            this.listingReaderFromButton.TabIndex = 0;
            this.listingReaderFromButton.Text = "Список читателей";
            this.listingReaderFromButton.UseVisualStyleBackColor = true;
            this.listingReaderFromButton.Click += new System.EventHandler(this.listingReaderFromButton_Click);
            // 
            // listingDebtorFromButton
            // 
            this.listingDebtorFromButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.listingDebtorFromButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listingDebtorFromButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listingDebtorFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listingDebtorFromButton.ForeColor = System.Drawing.SystemColors.Control;
            this.listingDebtorFromButton.Location = new System.Drawing.Point(6, 86);
            this.listingDebtorFromButton.Name = "listingDebtorFromButton";
            this.listingDebtorFromButton.Size = new System.Drawing.Size(238, 54);
            this.listingDebtorFromButton.TabIndex = 0;
            this.listingDebtorFromButton.Text = "Список должников";
            this.listingDebtorFromButton.UseVisualStyleBackColor = true;
            // 
            // registerReaderFromButton
            // 
            this.registerReaderFromButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.registerReaderFromButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerReaderFromButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerReaderFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerReaderFromButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registerReaderFromButton.Location = new System.Drawing.Point(6, 26);
            this.registerReaderFromButton.Name = "registerReaderFromButton";
            this.registerReaderFromButton.Size = new System.Drawing.Size(238, 54);
            this.registerReaderFromButton.TabIndex = 0;
            this.registerReaderFromButton.Text = "Регистрация читателя";
            this.registerReaderFromButton.UseVisualStyleBackColor = true;
            this.registerReaderFromButton.Click += new System.EventHandler(this.registerReaderFromButton_Click);
            // 
            // issueBookFormButton
            // 
            this.issueBookFormButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.issueBookFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.issueBookFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBookFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBookFormButton.ForeColor = System.Drawing.SystemColors.Control;
            this.issueBookFormButton.Location = new System.Drawing.Point(148, 262);
            this.issueBookFormButton.Name = "issueBookFormButton";
            this.issueBookFormButton.Size = new System.Drawing.Size(238, 54);
            this.issueBookFormButton.TabIndex = 0;
            this.issueBookFormButton.Text = "Выдать книгу";
            this.issueBookFormButton.UseVisualStyleBackColor = true;
            // 
            // acceptBookFormButton
            // 
            this.acceptBookFormButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.acceptBookFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acceptBookFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBookFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBookFormButton.ForeColor = System.Drawing.SystemColors.Control;
            this.acceptBookFormButton.Location = new System.Drawing.Point(148, 322);
            this.acceptBookFormButton.Name = "acceptBookFormButton";
            this.acceptBookFormButton.Size = new System.Drawing.Size(238, 54);
            this.acceptBookFormButton.TabIndex = 0;
            this.acceptBookFormButton.Text = "Принять книгу";
            this.acceptBookFormButton.UseVisualStyleBackColor = true;
            // 
            // titleMainForm
            // 
            this.titleMainForm.AutoSize = true;
            this.titleMainForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleMainForm.Location = new System.Drawing.Point(18, 16);
            this.titleMainForm.Name = "titleMainForm";
            this.titleMainForm.Size = new System.Drawing.Size(293, 24);
            this.titleMainForm.TabIndex = 2;
            this.titleMainForm.Text = "АРМ сотрудника библиотеки";
            // 
            // StartedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 393);
            this.Controls.Add(this.titleMainForm);
            this.Controls.Add(this.acceptBookFormButton);
            this.Controls.Add(this.issueBookFormButton);
            this.Controls.Add(this.readerGroupBox);
            this.Controls.Add(this.bookGroupBox);
            this.Name = "StartedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.bookGroupBox.ResumeLayout(false);
            this.readerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button2;
        private GroupBox bookGroupBox;
        private Button listingBookFromButton;
        private Button usedBookFromButton;
        private Button registerBookFromButton;
        private GroupBox readerGroupBox;
        private Button listingReaderFromButton;
        private Button listingDebtorFromButton;
        private Button registerReaderFromButton;
        private Button issueBookFormButton;
        private Button acceptBookFormButton;
        private Label titleMainForm;
    }
}
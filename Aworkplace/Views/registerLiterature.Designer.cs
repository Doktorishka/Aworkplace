namespace Aworkplace.Views
{
    partial class registerLiterature
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
            this.registrationButton = new System.Windows.Forms.Button();
            this.typeLiterature = new System.Windows.Forms.ComboBox();
            this.typeObjectLiterature = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLiterature = new System.Windows.Forms.TextBox();
            this.errorLabelFirstName = new System.Windows.Forms.Label();
            this.errorLabelLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countLinerature = new System.Windows.Forms.NumericUpDown();
            this.datePublish = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLabelDateBirth = new System.Windows.Forms.Label();
            this.errorLabelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countLinerature)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            this.registrationButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.registrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registrationButton.Location = new System.Drawing.Point(67, 496);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(238, 54);
            this.registrationButton.TabIndex = 17;
            this.registrationButton.Text = "Зарегистрировать";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // typeLiterature
            // 
            this.typeLiterature.FormattingEnabled = true;
            this.typeLiterature.Location = new System.Drawing.Point(9, 359);
            this.typeLiterature.Name = "typeLiterature";
            this.typeLiterature.Size = new System.Drawing.Size(345, 28);
            this.typeLiterature.TabIndex = 16;
            // 
            // typeObjectLiterature
            // 
            this.typeObjectLiterature.Location = new System.Drawing.Point(9, 425);
            this.typeObjectLiterature.Name = "typeObjectLiterature";
            this.typeObjectLiterature.Size = new System.Drawing.Size(345, 27);
            this.typeObjectLiterature.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Тип экземпляра";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Наименование издательства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество экземпляров";
            // 
            // nameAuthor
            // 
            this.nameAuthor.Location = new System.Drawing.Point(11, 111);
            this.nameAuthor.Name = "nameAuthor";
            this.nameAuthor.Size = new System.Drawing.Size(345, 27);
            this.nameAuthor.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Наименование автора *";
            // 
            // nameLiterature
            // 
            this.nameLiterature.Location = new System.Drawing.Point(11, 34);
            this.nameLiterature.Name = "nameLiterature";
            this.nameLiterature.Size = new System.Drawing.Size(345, 27);
            this.nameLiterature.TabIndex = 15;
            // 
            // errorLabelFirstName
            // 
            this.errorLabelFirstName.AutoSize = true;
            this.errorLabelFirstName.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabelFirstName.Location = new System.Drawing.Point(11, 141);
            this.errorLabelFirstName.Name = "errorLabelFirstName";
            this.errorLabelFirstName.Size = new System.Drawing.Size(267, 20);
            this.errorLabelFirstName.TabIndex = 9;
            this.errorLabelFirstName.Text = "Это поле обязательно к заполнению";
            this.errorLabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabelFirstName.Visible = false;
            // 
            // errorLabelLastName
            // 
            this.errorLabelLastName.AutoSize = true;
            this.errorLabelLastName.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabelLastName.Location = new System.Drawing.Point(11, 64);
            this.errorLabelLastName.Name = "errorLabelLastName";
            this.errorLabelLastName.Size = new System.Drawing.Size(267, 20);
            this.errorLabelLastName.TabIndex = 10;
            this.errorLabelLastName.Text = "Это поле обязательно к заполнению";
            this.errorLabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabelLastName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Наименование экземпляра *";
            // 
            // countLinerature
            // 
            this.countLinerature.Location = new System.Drawing.Point(11, 197);
            this.countLinerature.Name = "countLinerature";
            this.countLinerature.Size = new System.Drawing.Size(345, 27);
            this.countLinerature.TabIndex = 18;
            // 
            // datePublish
            // 
            this.datePublish.Location = new System.Drawing.Point(11, 282);
            this.datePublish.Name = "datePublish";
            this.datePublish.Size = new System.Drawing.Size(345, 27);
            this.datePublish.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата публикации экземпляра *";
            // 
            // errorLabelDateBirth
            // 
            this.errorLabelDateBirth.AutoSize = true;
            this.errorLabelDateBirth.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabelDateBirth.Location = new System.Drawing.Point(11, 312);
            this.errorLabelDateBirth.Name = "errorLabelDateBirth";
            this.errorLabelDateBirth.Size = new System.Drawing.Size(267, 20);
            this.errorLabelDateBirth.TabIndex = 20;
            this.errorLabelDateBirth.Text = "Это поле обязательно к заполнению";
            this.errorLabelDateBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabelDateBirth.Visible = false;
            // 
            // errorLabelCount
            // 
            this.errorLabelCount.AutoSize = true;
            this.errorLabelCount.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabelCount.Location = new System.Drawing.Point(12, 227);
            this.errorLabelCount.Name = "errorLabelCount";
            this.errorLabelCount.Size = new System.Drawing.Size(267, 20);
            this.errorLabelCount.TabIndex = 9;
            this.errorLabelCount.Text = "Это поле обязательно к заполнению";
            this.errorLabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabelCount.Visible = false;
            // 
            // registerLiterature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 560);
            this.Controls.Add(this.datePublish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorLabelDateBirth);
            this.Controls.Add(this.countLinerature);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.typeLiterature);
            this.Controls.Add(this.typeObjectLiterature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLiterature);
            this.Controls.Add(this.errorLabelCount);
            this.Controls.Add(this.errorLabelFirstName);
            this.Controls.Add(this.errorLabelLastName);
            this.Controls.Add(this.label1);
            this.Name = "registerLiterature";
            this.Text = "registerLiterature";
            ((System.ComponentModel.ISupportInitialize)(this.countLinerature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button registrationButton;
        private ComboBox typeLiterature;
        private TextBox typeObjectLiterature;
        private Label label5;
        private Label label6;
        private Label label3;
        private TextBox nameAuthor;
        private Label label2;
        private TextBox nameLiterature;
        private Label errorLabelFirstName;
        private Label errorLabelLastName;
        private Label label1;
        private NumericUpDown countLinerature;
        private DateTimePicker datePublish;
        private Label label4;
        private Label errorLabelDateBirth;
        private Label errorLabelCount;
    }
}
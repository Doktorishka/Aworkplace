namespace Aworkplace.Views
{
    partial class registerReader
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
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameReader = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameReader = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patronomycReader = new System.Windows.Forms.TextBox();
            this.dateBirthReader = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.typeReader = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.typeObjectReader = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.errorLabelLastName = new System.Windows.Forms.Label();
            this.errorLabelFirstName = new System.Windows.Forms.Label();
            this.errorLabelDateBirth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия *";
            // 
            // lastNameReader
            // 
            this.lastNameReader.Location = new System.Drawing.Point(10, 35);
            this.lastNameReader.Name = "lastNameReader";
            this.lastNameReader.Size = new System.Drawing.Size(345, 27);
            this.lastNameReader.TabIndex = 1;
            this.lastNameReader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.function_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя *";
            // 
            // firstNameReader
            // 
            this.firstNameReader.Location = new System.Drawing.Point(10, 112);
            this.firstNameReader.Name = "firstNameReader";
            this.firstNameReader.Size = new System.Drawing.Size(345, 27);
            this.firstNameReader.TabIndex = 1;
            this.firstNameReader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.function_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Отчество";
            // 
            // patronomycReader
            // 
            this.patronomycReader.Location = new System.Drawing.Point(10, 198);
            this.patronomycReader.Name = "patronomycReader";
            this.patronomycReader.Size = new System.Drawing.Size(345, 27);
            this.patronomycReader.TabIndex = 1;
            this.patronomycReader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.function_KeyPress);
            // 
            // dateBirthReader
            // 
            this.dateBirthReader.Location = new System.Drawing.Point(10, 270);
            this.dateBirthReader.Name = "dateBirthReader";
            this.dateBirthReader.Size = new System.Drawing.Size(345, 27);
            this.dateBirthReader.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Дата рождения *";
            // 
            // typeReader
            // 
            this.typeReader.FormattingEnabled = true;
            this.typeReader.Location = new System.Drawing.Point(10, 357);
            this.typeReader.Name = "typeReader";
            this.typeReader.Size = new System.Drawing.Size(345, 28);
            this.typeReader.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Тип читателя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Место работы";
            // 
            // typeObjectReader
            // 
            this.typeObjectReader.Location = new System.Drawing.Point(10, 439);
            this.typeObjectReader.Name = "typeObjectReader";
            this.typeObjectReader.Size = new System.Drawing.Size(345, 27);
            this.typeObjectReader.TabIndex = 1;
            this.typeObjectReader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.function_KeyPress);
            // 
            // registrationButton
            // 
            this.registrationButton.BackgroundImage = global::Aworkplace.Properties.Resources.button;
            this.registrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registrationButton.Location = new System.Drawing.Point(66, 497);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(238, 54);
            this.registrationButton.TabIndex = 4;
            this.registrationButton.Text = "Зарегистрировать";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // errorLabelLastName
            // 
            this.errorLabelLastName.AutoSize = true;
            this.errorLabelLastName.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabelLastName.Location = new System.Drawing.Point(10, 65);
            this.errorLabelLastName.Name = "errorLabelLastName";
            this.errorLabelLastName.Size = new System.Drawing.Size(267, 20);
            this.errorLabelLastName.TabIndex = 0;
            this.errorLabelLastName.Text = "Это поле обязательно к заполнению";
            this.errorLabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabelLastName.Visible = false;
            // 
            // errorLabelFirstName
            // 
            this.errorLabelFirstName.AutoSize = true;
            this.errorLabelFirstName.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabelFirstName.Location = new System.Drawing.Point(10, 142);
            this.errorLabelFirstName.Name = "errorLabelFirstName";
            this.errorLabelFirstName.Size = new System.Drawing.Size(267, 20);
            this.errorLabelFirstName.TabIndex = 0;
            this.errorLabelFirstName.Text = "Это поле обязательно к заполнению";
            this.errorLabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabelFirstName.Visible = false;
            // 
            // errorLabelDateBirth
            // 
            this.errorLabelDateBirth.AutoSize = true;
            this.errorLabelDateBirth.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabelDateBirth.Location = new System.Drawing.Point(10, 300);
            this.errorLabelDateBirth.Name = "errorLabelDateBirth";
            this.errorLabelDateBirth.Size = new System.Drawing.Size(267, 20);
            this.errorLabelDateBirth.TabIndex = 0;
            this.errorLabelDateBirth.Text = "Это поле обязательно к заполнению";
            this.errorLabelDateBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabelDateBirth.Visible = false;
            // 
            // registerReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 560);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.typeReader);
            this.Controls.Add(this.dateBirthReader);
            this.Controls.Add(this.typeObjectReader);
            this.Controls.Add(this.patronomycReader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameReader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameReader);
            this.Controls.Add(this.errorLabelDateBirth);
            this.Controls.Add(this.errorLabelFirstName);
            this.Controls.Add(this.errorLabelLastName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "registerReader";
            this.Text = "Регистрация читателя";
            this.Load += new System.EventHandler(this.registerReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox lastNameReader;
        private Label label2;
        private TextBox firstNameReader;
        private Label label3;
        private TextBox patronomycReader;
        private DateTimePicker dateBirthReader;
        private Label label4;
        private ComboBox typeReader;
        private Label label5;
        private Label label6;
        private TextBox typeObjectReader;
        private Button registrationButton;
        private Label errorLabelLastName;
        private Label errorLabelFirstName;
        private Label errorLabelDateBirth;
    }
}
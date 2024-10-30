namespace Laba_6
{
    partial class fPerson
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
            groupBox1 = new GroupBox();
            tbHeight = new TextBox();
            tbWeight = new TextBox();
            tbAge = new TextBox();
            tbGender = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chbHasBike = new CheckBox();
            chbHasAuto = new CheckBox();
            btnOk = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(tbHeight);
            groupBox1.Controls.Add(tbWeight);
            groupBox1.Controls.Add(tbAge);
            groupBox1.Controls.Add(tbGender);
            groupBox1.Controls.Add(tbLastName);
            groupBox1.Controls.Add(tbFirstName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 26);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(391, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Загальні дані";
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(175, 248);
            tbHeight.Margin = new Padding(3, 4, 3, 4);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(136, 27);
            tbHeight.TabIndex = 10;
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(175, 300);
            tbWeight.Margin = new Padding(3, 4, 3, 4);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(136, 27);
            tbWeight.TabIndex = 9;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(175, 189);
            tbAge.Margin = new Padding(3, 4, 3, 4);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(136, 27);
            tbAge.TabIndex = 8;
            // 
            // tbGender
            // 
            tbGender.Location = new Point(175, 136);
            tbGender.Margin = new Padding(3, 4, 3, 4);
            tbGender.Name = "tbGender";
            tbGender.Size = new Size(136, 27);
            tbGender.TabIndex = 7;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(175, 86);
            tbLastName.Margin = new Padding(3, 4, 3, 4);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(136, 27);
            tbLastName.TabIndex = 7;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(175, 40);
            tbFirstName.Margin = new Padding(3, 4, 3, 4);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(136, 27);
            tbFirstName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 304);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 5;
            label6.Text = "Вага";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 251);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 4;
            label5.Text = "Зріст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 192);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 3;
            label4.Text = "Вік";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 140);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Стать";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 90);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Прізвище";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ScrollBar;
            groupBox2.Controls.Add(chbHasBike);
            groupBox2.Controls.Add(chbHasAuto);
            groupBox2.Location = new Point(24, 421);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(391, 126);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Транспорт";
            // 
            // chbHasBike
            // 
            chbHasBike.AutoSize = true;
            chbHasBike.Location = new Point(46, 76);
            chbHasBike.Margin = new Padding(3, 4, 3, 4);
            chbHasBike.Name = "chbHasBike";
            chbHasBike.Size = new Size(137, 24);
            chbHasBike.TabIndex = 3;
            chbHasBike.Text = "Має велосипед";
            chbHasBike.UseVisualStyleBackColor = true;
            // 
            // chbHasAuto
            // 
            chbHasAuto.AutoSize = true;
            chbHasAuto.Location = new Point(46, 44);
            chbHasAuto.Margin = new Padding(3, 4, 3, 4);
            chbHasAuto.Name = "chbHasAuto";
            chbHasAuto.Size = new Size(143, 24);
            chbHasAuto.TabIndex = 2;
            chbHasAuto.Text = "Має автомобіль";
            chbHasAuto.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Cursor = Cursors.Hand;
            btnOk.Location = new Point(441, 50);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(93, 44);
            btnOk.TabIndex = 12;
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(441, 105);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 44);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(547, 562);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "fPerson";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Дані про нову персону";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasBike;
        private System.Windows.Forms.CheckBox chbHasAuto;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
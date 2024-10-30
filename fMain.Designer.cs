namespace Laba_6
{
    partial class fMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            toolStrip1 = new ToolStrip();
            btnADD = new ToolStripButton();
            btnEDIT = new ToolStripButton();
            separator1 = new ToolStripSeparator();
            btnDEL = new ToolStripButton();
            btnCLEAR = new ToolStripButton();
            separator2 = new ToolStripSeparator();
            btnEXIT = new ToolStripButton();
            btnSaveAsText = new ToolStripButton();
            btnSaveAsBinary = new ToolStripButton();
            btnOpenFromText = new ToolStripButton();
            btnOpenFromBinary = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            bindSrcPersons = new BindingSource(components);
            gvPerson = new DataGridView();
            saveFileDialog = new SaveFileDialog();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvPerson).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnADD, btnEDIT, separator1, btnDEL, btnCLEAR, separator2, btnEXIT, btnSaveAsText, btnSaveAsBinary, btnOpenFromText, btnOpenFromBinary, toolStripSeparator1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(867, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnADD
            // 
            btnADD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnADD.Image = (Image)resources.GetObject("btnADD.Image");
            btnADD.ImageTransparentColor = Color.Magenta;
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(29, 24);
            btnADD.Text = "Додати запис про персону";
            btnADD.Click += btnADD_Click;
            // 
            // btnEDIT
            // 
            btnEDIT.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEDIT.Image = (Image)resources.GetObject("btnEDIT.Image");
            btnEDIT.ImageTransparentColor = Color.Magenta;
            btnEDIT.Name = "btnEDIT";
            btnEDIT.Size = new Size(29, 24);
            btnEDIT.Text = "Редагувати запис";
            btnEDIT.Click += btnEDIT_Click;
            // 
            // separator1
            // 
            separator1.Name = "separator1";
            separator1.Size = new Size(6, 27);
            // 
            // btnDEL
            // 
            btnDEL.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDEL.Image = (Image)resources.GetObject("btnDEL.Image");
            btnDEL.ImageTransparentColor = Color.Magenta;
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(29, 24);
            btnDEL.Text = "Видалити запис";
            btnDEL.Click += btnDEL_Click;
            // 
            // btnCLEAR
            // 
            btnCLEAR.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCLEAR.Image = (Image)resources.GetObject("btnCLEAR.Image");
            btnCLEAR.ImageTransparentColor = Color.Magenta;
            btnCLEAR.Name = "btnCLEAR";
            btnCLEAR.Size = new Size(29, 24);
            btnCLEAR.Text = "Очистити дані";
            btnCLEAR.Click += btnCLEAR_Click;
            // 
            // separator2
            // 
            separator2.Name = "separator2";
            separator2.Size = new Size(6, 27);
            // 
            // btnEXIT
            // 
            btnEXIT.Alignment = ToolStripItemAlignment.Right;
            btnEXIT.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEXIT.Image = (Image)resources.GetObject("btnEXIT.Image");
            btnEXIT.ImageTransparentColor = Color.Magenta;
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(29, 24);
            btnEXIT.Text = "Вийти з програми";
            btnEXIT.Click += btnEXIT_Click;
            // 
            // btnSaveAsText
            // 
            btnSaveAsText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveAsText.Image = (Image)resources.GetObject("btnSaveAsText.Image");
            btnSaveAsText.ImageTransparentColor = Color.Magenta;
            btnSaveAsText.Name = "btnSaveAsText";
            btnSaveAsText.Size = new Size(29, 24);
            btnSaveAsText.Text = "\"Зберегти у текстовому форматі";
            btnSaveAsText.ToolTipText = "Зберегти у текстовому форматі";
            btnSaveAsText.Click += btnSaveAsText_Click;
            // 
            // btnSaveAsBinary
            // 
            btnSaveAsBinary.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveAsBinary.Image = (Image)resources.GetObject("btnSaveAsBinary.Image");
            btnSaveAsBinary.ImageTransparentColor = Color.Magenta;
            btnSaveAsBinary.Name = "btnSaveAsBinary";
            btnSaveAsBinary.Size = new Size(29, 24);
            btnSaveAsBinary.Text = "Зберегти у бінарному форматі";
            btnSaveAsBinary.ToolTipText = "Зберегти у бінарному форматі";
            btnSaveAsBinary.Click += btnSaveAsBinary_Click;
            // 
            // btnOpenFromText
            // 
            btnOpenFromText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpenFromText.Image = (Image)resources.GetObject("btnOpenFromText.Image");
            btnOpenFromText.ImageTransparentColor = Color.Magenta;
            btnOpenFromText.Name = "btnOpenFromText";
            btnOpenFromText.Size = new Size(29, 24);
            btnOpenFromText.Text = "Відкрити текстові дані";
            btnOpenFromText.ToolTipText = "Відкрити текстові дані";
            btnOpenFromText.Click += btnOpenFromText_Click;
            // 
            // btnOpenFromBinary
            // 
            btnOpenFromBinary.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpenFromBinary.Image = (Image)resources.GetObject("btnOpenFromBinary.Image");
            btnOpenFromBinary.ImageTransparentColor = Color.Magenta;
            btnOpenFromBinary.Name = "btnOpenFromBinary";
            btnOpenFromBinary.Size = new Size(29, 24);
            btnOpenFromBinary.Text = "Відкрити бінарні дані";
            btnOpenFromBinary.Click += btnOpenFromBinary_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // gvPerson
            // 
            gvPerson.AllowUserToAddRows = false;
            gvPerson.AllowUserToDeleteRows = false;
            gvPerson.AutoGenerateColumns = false;
            gvPerson.BackgroundColor = SystemColors.AppWorkspace;
            gvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvPerson.DataSource = bindSrcPersons;
            gvPerson.Dock = DockStyle.Fill;
            gvPerson.Location = new Point(0, 27);
            gvPerson.Margin = new Padding(3, 4, 3, 4);
            gvPerson.Name = "gvPerson";
            gvPerson.ReadOnly = true;
            gvPerson.RowHeadersWidth = 51;
            gvPerson.Size = new Size(867, 461);
            gvPerson.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 488);
            ControlBox = false;
            Controls.Add(gvPerson);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота 6";
            Load += FORMMAIN_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnADD;
        private ToolStripButton btnEDIT;
        private ToolStripSeparator separator1;
        private ToolStripButton btnDEL;
        private ToolStripButton btnCLEAR;
        private ToolStripSeparator separator2;
        private ToolStripButton btnEXIT;
        private BindingSource bindSrcPersons;
        private DataGridView gvPerson;
        private ToolStripButton btnSaveAsText;
        private ToolStripButton btnSaveAsBinary;
        private ToolStripButton btnOpenFromText;
        private ToolStripButton btnOpenFromBinary;
        private ToolStripSeparator toolStripSeparator1;
        private SaveFileDialog saveFileDialog;
    }
}

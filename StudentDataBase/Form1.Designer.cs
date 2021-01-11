namespace StudentDataBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mark1Form = new System.Windows.Forms.NumericUpDown();
            this.mark2Form = new System.Windows.Forms.NumericUpDown();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.mark3Form = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.mark4Form = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.mark5Form = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.publicWorkCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsXML = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsJson = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadXML = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadJson = new System.Windows.Forms.ToolStripMenuItem();
            this.setScholarshipButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.setScholarshipTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.activistTextBox = new System.Windows.Forms.TextBox();
            this.activistButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark1Form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark2Form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark3Form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark4Form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark5Form)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // studGrid
            // 
            this.studGrid.AllowUserToAddRows = false;
            this.studGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.studGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.studGrid.Location = new System.Drawing.Point(12, 27);
            this.studGrid.Name = "studGrid";
            this.studGrid.Size = new System.Drawing.Size(894, 200);
            this.studGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ім\'я";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(49, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Група";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Предмет 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Предмет 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Предмет 3";
            // 
            // mark1Form
            // 
            this.mark1Form.Location = new System.Drawing.Point(119, 105);
            this.mark1Form.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.mark1Form.Name = "mark1Form";
            this.mark1Form.Size = new System.Drawing.Size(31, 20);
            this.mark1Form.TabIndex = 8;
            this.mark1Form.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // mark2Form
            // 
            this.mark2Form.Location = new System.Drawing.Point(119, 131);
            this.mark2Form.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.mark2Form.Name = "mark2Form";
            this.mark2Form.Size = new System.Drawing.Size(31, 20);
            this.mark2Form.TabIndex = 9;
            this.mark2Form.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Items.AddRange(new object[] {
            "Математика",
            "Середня Освіта",
            "Прикладна Математика",
            "Системний Аналіз"});
            this.groupBox.Location = new System.Drawing.Point(69, 66);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(124, 21);
            this.groupBox.TabIndex = 10;
            // 
            // mark3Form
            // 
            this.mark3Form.Location = new System.Drawing.Point(119, 157);
            this.mark3Form.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.mark3Form.Name = "mark3Form";
            this.mark3Form.Size = new System.Drawing.Size(31, 20);
            this.mark3Form.TabIndex = 11;
            this.mark3Form.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Предмет 4";
            // 
            // mark4Form
            // 
            this.mark4Form.Location = new System.Drawing.Point(119, 183);
            this.mark4Form.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.mark4Form.Name = "mark4Form";
            this.mark4Form.Size = new System.Drawing.Size(31, 20);
            this.mark4Form.TabIndex = 13;
            this.mark4Form.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Предмет 5";
            // 
            // mark5Form
            // 
            this.mark5Form.Location = new System.Drawing.Point(119, 209);
            this.mark5Form.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.mark5Form.Name = "mark5Form";
            this.mark5Form.Size = new System.Drawing.Size(31, 20);
            this.mark5Form.TabIndex = 15;
            this.mark5Form.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.publicWorkCheckBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mark5Form);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mark4Form);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mark3Form);
            this.groupBox1.Controls.Add(this.groupBox);
            this.groupBox1.Controls.Add(this.mark2Form);
            this.groupBox1.Controls.Add(this.mark1Form);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 289);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додавання в таблицю";
            // 
            // publicWorkCheckBox
            // 
            this.publicWorkCheckBox.AutoSize = true;
            this.publicWorkCheckBox.Location = new System.Drawing.Point(193, 190);
            this.publicWorkCheckBox.Name = "publicWorkCheckBox";
            this.publicWorkCheckBox.Size = new System.Drawing.Size(15, 14);
            this.publicWorkCheckBox.TabIndex = 18;
            this.publicWorkCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(156, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 39);
            this.label8.TabIndex = 17;
            this.label8.Text = "Участь в \r\nвгромадських \r\nроботах";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem,
            this.завантажитиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsBinary,
            this.saveAsXML,
            this.saveAsExcel,
            this.saveAsJson});
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // saveAsBinary
            // 
            this.saveAsBinary.Name = "saveAsBinary";
            this.saveAsBinary.Size = new System.Drawing.Size(180, 22);
            this.saveAsBinary.Text = "Бінарний";
            this.saveAsBinary.Click += new System.EventHandler(this.БінарнийToolStripMenuItem_Click);
            // 
            // saveAsXML
            // 
            this.saveAsXML.Name = "saveAsXML";
            this.saveAsXML.Size = new System.Drawing.Size(180, 22);
            this.saveAsXML.Text = "XML";
            this.saveAsXML.Click += new System.EventHandler(this.SaveAsXML_Click);
            // 
            // saveAsExcel
            // 
            this.saveAsExcel.Name = "saveAsExcel";
            this.saveAsExcel.Size = new System.Drawing.Size(180, 22);
            this.saveAsExcel.Text = "Excel";
            this.saveAsExcel.Click += new System.EventHandler(this.SaveAsExcel_Click);
            // 
            // saveAsJson
            // 
            this.saveAsJson.Name = "saveAsJson";
            this.saveAsJson.Size = new System.Drawing.Size(180, 22);
            this.saveAsJson.Text = "Json";
            this.saveAsJson.Click += new System.EventHandler(this.SaveAsJson_Click_1);
            // 
            // завантажитиToolStripMenuItem
            // 
            this.завантажитиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadBinary,
            this.downloadXML,
            this.downloadExcel,
            this.downloadJson});
            this.завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            this.завантажитиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.завантажитиToolStripMenuItem.Text = "Завантажити";
            // 
            // downloadBinary
            // 
            this.downloadBinary.Name = "downloadBinary";
            this.downloadBinary.Size = new System.Drawing.Size(180, 22);
            this.downloadBinary.Text = "Бінарний";
            this.downloadBinary.Click += new System.EventHandler(this.DownloadBinary_Click);
            // 
            // downloadXML
            // 
            this.downloadXML.Name = "downloadXML";
            this.downloadXML.Size = new System.Drawing.Size(180, 22);
            this.downloadXML.Text = "XML";
            this.downloadXML.Click += new System.EventHandler(this.DownloadXML_Click);
            // 
            // downloadExcel
            // 
            this.downloadExcel.Name = "downloadExcel";
            this.downloadExcel.Size = new System.Drawing.Size(180, 22);
            this.downloadExcel.Text = "Excel";
            this.downloadExcel.Click += new System.EventHandler(this.DownloadExcel_Click_1);
            // 
            // downloadJson
            // 
            this.downloadJson.Name = "downloadJson";
            this.downloadJson.Size = new System.Drawing.Size(180, 22);
            this.downloadJson.Text = "Json";
            this.downloadJson.Click += new System.EventHandler(this.DownloadJson_Click_1);
            // 
            // setScholarshipButton
            // 
            this.setScholarshipButton.Location = new System.Drawing.Point(48, 96);
            this.setScholarshipButton.Name = "setScholarshipButton";
            this.setScholarshipButton.Size = new System.Drawing.Size(94, 25);
            this.setScholarshipButton.TabIndex = 20;
            this.setScholarshipButton.Text = "Ввести";
            this.setScholarshipButton.UseVisualStyleBackColor = true;
            this.setScholarshipButton.Click += new System.EventHandler(this.SetScholarshipButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Встановити розмір стипендії";
            // 
            // setScholarshipTextBox
            // 
            this.setScholarshipTextBox.Location = new System.Drawing.Point(32, 51);
            this.setScholarshipTextBox.Name = "setScholarshipTextBox";
            this.setScholarshipTextBox.Size = new System.Drawing.Size(124, 20);
            this.setScholarshipTextBox.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.setScholarshipTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.setScholarshipButton);
            this.groupBox2.Location = new System.Drawing.Point(534, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 174);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "Визначити розмір\r\n стипендії студентів";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 25);
            this.button2.TabIndex = 25;
            this.button2.Text = "Визначити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(723, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 114);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Загальне число активістів в списку";
            // 
            // activistTextBox
            // 
            this.activistTextBox.Location = new System.Drawing.Point(42, 90);
            this.activistTextBox.Name = "activistTextBox";
            this.activistTextBox.Size = new System.Drawing.Size(150, 20);
            this.activistTextBox.TabIndex = 28;
            // 
            // activistButton
            // 
            this.activistButton.Location = new System.Drawing.Point(66, 45);
            this.activistButton.Name = "activistButton";
            this.activistButton.Size = new System.Drawing.Size(84, 29);
            this.activistButton.TabIndex = 29;
            this.activistButton.Text = "Визначити";
            this.activistButton.UseVisualStyleBackColor = true;
            this.activistButton.Click += new System.EventHandler(this.ActivistButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.activistButton);
            this.groupBox4.Controls.Add(this.activistTextBox);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(290, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 144);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(918, 522);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Список студентів";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark1Form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark2Form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark3Form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark4Form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark5Form)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown mark1Form;
        private System.Windows.Forms.NumericUpDown mark2Form;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.NumericUpDown mark3Form;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown mark4Form;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown mark5Form;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox publicWorkCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.Button setScholarshipButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox setScholarshipTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox activistTextBox;
        private System.Windows.Forms.Button activistButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem saveAsBinary;
        private System.Windows.Forms.ToolStripMenuItem saveAsXML;
        private System.Windows.Forms.ToolStripMenuItem saveAsExcel;
        private System.Windows.Forms.ToolStripMenuItem saveAsJson;
        private System.Windows.Forms.ToolStripMenuItem завантажитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadBinary;
        private System.Windows.Forms.ToolStripMenuItem downloadXML;
        private System.Windows.Forms.ToolStripMenuItem downloadExcel;
        private System.Windows.Forms.ToolStripMenuItem downloadJson;
    }
}


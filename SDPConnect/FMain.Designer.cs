namespace SDPConnect
{
    partial class FMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.ofdReestr = new System.Windows.Forms.OpenFileDialog();
            this.tbReestrPath = new System.Windows.Forms.TextBox();
            this.btnLoadReestr = new System.Windows.Forms.Button();
            this.scGridLog = new System.Windows.Forms.SplitContainer();
            this.dgvReestr = new System.Windows.Forms.DataGridView();
            this.scHeadOther = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.scGridLog)).BeginInit();
            this.scGridLog.Panel1.SuspendLayout();
            this.scGridLog.Panel2.SuspendLayout();
            this.scGridLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReestr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scHeadOther)).BeginInit();
            this.scHeadOther.Panel1.SuspendLayout();
            this.scHeadOther.Panel2.SuspendLayout();
            this.scHeadOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(855, 35);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(115, 33);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "button1";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(0, 0);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(1075, 173);
            this.tbLog.TabIndex = 1;
            // 
            // ofdReestr
            // 
            this.ofdReestr.FileName = "openFileDialog1";
            // 
            // tbReestrPath
            // 
            this.tbReestrPath.Location = new System.Drawing.Point(12, 12);
            this.tbReestrPath.Name = "tbReestrPath";
            this.tbReestrPath.Size = new System.Drawing.Size(543, 20);
            this.tbReestrPath.TabIndex = 2;
            // 
            // btnLoadReestr
            // 
            this.btnLoadReestr.Location = new System.Drawing.Point(584, 10);
            this.btnLoadReestr.Name = "btnLoadReestr";
            this.btnLoadReestr.Size = new System.Drawing.Size(118, 23);
            this.btnLoadReestr.TabIndex = 3;
            this.btnLoadReestr.Text = "Загрузить реестр";
            this.btnLoadReestr.UseVisualStyleBackColor = true;
            this.btnLoadReestr.Click += new System.EventHandler(this.btnLoadReestr_Click);
            // 
            // scGridLog
            // 
            this.scGridLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scGridLog.Location = new System.Drawing.Point(0, 0);
            this.scGridLog.Name = "scGridLog";
            this.scGridLog.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scGridLog.Panel1
            // 
            this.scGridLog.Panel1.Controls.Add(this.dgvReestr);
            // 
            // scGridLog.Panel2
            // 
            this.scGridLog.Panel2.Controls.Add(this.tbLog);
            this.scGridLog.Panel2MinSize = 150;
            this.scGridLog.Size = new System.Drawing.Size(1075, 456);
            this.scGridLog.SplitterDistance = 279;
            this.scGridLog.TabIndex = 4;
            // 
            // dgvReestr
            // 
            this.dgvReestr.AllowUserToAddRows = false;
            this.dgvReestr.AllowUserToDeleteRows = false;
            this.dgvReestr.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReestr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReestr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReestr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReestr.Location = new System.Drawing.Point(0, 0);
            this.dgvReestr.Name = "dgvReestr";
            this.dgvReestr.ReadOnly = true;
            this.dgvReestr.RowHeadersVisible = false;
            this.dgvReestr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReestr.Size = new System.Drawing.Size(1075, 279);
            this.dgvReestr.TabIndex = 0;
            // 
            // scHeadOther
            // 
            this.scHeadOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHeadOther.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scHeadOther.IsSplitterFixed = true;
            this.scHeadOther.Location = new System.Drawing.Point(0, 0);
            this.scHeadOther.Name = "scHeadOther";
            this.scHeadOther.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scHeadOther.Panel1
            // 
            this.scHeadOther.Panel1.Controls.Add(this.btnLoadReestr);
            this.scHeadOther.Panel1.Controls.Add(this.tbReestrPath);
            this.scHeadOther.Panel1.Controls.Add(this.btnRun);
            // 
            // scHeadOther.Panel2
            // 
            this.scHeadOther.Panel2.Controls.Add(this.scGridLog);
            this.scHeadOther.Size = new System.Drawing.Size(1075, 540);
            this.scHeadOther.SplitterDistance = 80;
            this.scHeadOther.TabIndex = 5;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 540);
            this.Controls.Add(this.scHeadOther);
            this.Name = "FMain";
            this.Text = "Загрузчик реестра СБОЛ";
            this.scGridLog.Panel1.ResumeLayout(false);
            this.scGridLog.Panel2.ResumeLayout(false);
            this.scGridLog.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGridLog)).EndInit();
            this.scGridLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReestr)).EndInit();
            this.scHeadOther.Panel1.ResumeLayout(false);
            this.scHeadOther.Panel1.PerformLayout();
            this.scHeadOther.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scHeadOther)).EndInit();
            this.scHeadOther.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.OpenFileDialog ofdReestr;
        private System.Windows.Forms.TextBox tbReestrPath;
        private System.Windows.Forms.Button btnLoadReestr;
        private System.Windows.Forms.SplitContainer scGridLog;
        private System.Windows.Forms.DataGridView dgvReestr;
        private System.Windows.Forms.SplitContainer scHeadOther;
    }
}


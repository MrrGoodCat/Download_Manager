namespace DownloadManager
{
    partial class DownloadManagerForm
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
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.lableProgress = new System.Windows.Forms.Label();
            this.lableDownloadURL = new System.Windows.Forms.Label();
            this.lableDownloadPath = new System.Windows.Forms.Label();
            this.textBoxDownloadURL = new System.Windows.Forms.TextBox();
            this.textBoxDownloadPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(336, 64);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(417, 64);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(16, 123);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(480, 23);
            this.progressBarDownload.TabIndex = 2;
            // 
            // lableProgress
            // 
            this.lableProgress.AutoSize = true;
            this.lableProgress.Location = new System.Drawing.Point(13, 95);
            this.lableProgress.Name = "lableProgress";
            this.lableProgress.Size = new System.Drawing.Size(98, 13);
            this.lableProgress.TabIndex = 3;
            this.lableProgress.Text = "Awaiting Download";
            // 
            // lableDownloadURL
            // 
            this.lableDownloadURL.AutoSize = true;
            this.lableDownloadURL.Location = new System.Drawing.Point(13, 15);
            this.lableDownloadURL.Name = "lableDownloadURL";
            this.lableDownloadURL.Size = new System.Drawing.Size(80, 13);
            this.lableDownloadURL.TabIndex = 4;
            this.lableDownloadURL.Text = "Download URL";
            // 
            // lableDownloadPath
            // 
            this.lableDownloadPath.AutoSize = true;
            this.lableDownloadPath.Location = new System.Drawing.Point(13, 41);
            this.lableDownloadPath.Name = "lableDownloadPath";
            this.lableDownloadPath.Size = new System.Drawing.Size(80, 13);
            this.lableDownloadPath.TabIndex = 10;
            this.lableDownloadPath.Text = "Download Path";
            // 
            // textBoxDownloadURL
            // 
            this.textBoxDownloadURL.Location = new System.Drawing.Point(99, 12);
            this.textBoxDownloadURL.Name = "textBoxDownloadURL";
            this.textBoxDownloadURL.Size = new System.Drawing.Size(393, 20);
            this.textBoxDownloadURL.TabIndex = 11;
            // 
            // textBoxDownloadPath
            // 
            this.textBoxDownloadPath.Location = new System.Drawing.Point(99, 38);
            this.textBoxDownloadPath.Name = "textBoxDownloadPath";
            this.textBoxDownloadPath.Size = new System.Drawing.Size(393, 20);
            this.textBoxDownloadPath.TabIndex = 12;
            // 
            // DownloadManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 182);
            this.Controls.Add(this.textBoxDownloadPath);
            this.Controls.Add(this.textBoxDownloadURL);
            this.Controls.Add(this.lableDownloadPath);
            this.Controls.Add(this.lableDownloadURL);
            this.Controls.Add(this.lableProgress);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonDownload);
            this.Name = "DownloadManagerForm";
            this.Text = "Download Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Label lableProgress;
        private System.Windows.Forms.Label lableDownloadURL;
        private System.Windows.Forms.Label lableDownloadPath;
        private System.Windows.Forms.TextBox textBoxDownloadURL;
        private System.Windows.Forms.TextBox textBoxDownloadPath;
    }
}


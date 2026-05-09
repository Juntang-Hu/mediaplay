namespace mediaplay
{
    partial class frmWAVPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPath = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.ofdWAVFile = new System.Windows.Forms.OpenFileDialog();
            this.grpPath.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPath
            // 
            this.grpPath.Controls.Add(this.btnBrowse);
            this.grpPath.Controls.Add(this.txtPath);
            this.grpPath.Location = new System.Drawing.Point(53, 56);
            this.grpPath.Name = "grpPath";
            this.grpPath.Size = new System.Drawing.Size(673, 152);
            this.grpPath.TabIndex = 0;
            this.grpPath.TabStop = false;
            this.grpPath.Text = "音效位置";
            // 
            // txtPath
            // 
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Location = new System.Drawing.Point(71, 55);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(266, 29);
            this.txtPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(433, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(111, 45);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnEnd);
            this.grpButton.Controls.Add(this.btnStop);
            this.grpButton.Controls.Add(this.btnLoop);
            this.grpButton.Controls.Add(this.btnPlay);
            this.grpButton.Location = new System.Drawing.Point(53, 224);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(673, 152);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "播放按鈕";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(71, 67);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(111, 45);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "撥放一次";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(188, 67);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(111, 45);
            this.btnLoop.TabIndex = 2;
            this.btnLoop.Text = "重複播放";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(305, 67);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 45);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止播放";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(422, 67);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(111, 45);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "結束程式";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // ofdWAVFile
            // 
            this.ofdWAVFile.DefaultExt = "wav";
            // 
            // frmWAVPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPath);
            this.Name = "frmWAVPlayer";
            this.Text = "WAV player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWAVPlayer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPath.ResumeLayout(false);
            this.grpPath.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.OpenFileDialog ofdWAVFile;
    }
}


namespace DBProject_github
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.Location = new System.Drawing.Point(251, 77);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(387, 21);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(68, 44);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(140, 84);
            this.buttonDisplay.TabIndex = 1;
            this.buttonDisplay.Text = "출력";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.textBoxMain);
            this.Name = "Form1";
            this.Text = "GitHub 연습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button buttonDisplay;
    }
}


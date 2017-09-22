namespace Powerline
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurDir = new System.Windows.Forms.Label();
            this.txtCurDir = new System.Windows.Forms.TextBox();
            this.btnChangeDir = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.fbdCurDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClassification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurDir
            // 
            this.lblCurDir.AutoSize = true;
            this.lblCurDir.Location = new System.Drawing.Point(12, 9);
            this.lblCurDir.Name = "lblCurDir";
            this.lblCurDir.Size = new System.Drawing.Size(112, 15);
            this.lblCurDir.TabIndex = 0;
            this.lblCurDir.Text = "当前工作目录：";
            // 
            // txtCurDir
            // 
            this.txtCurDir.Location = new System.Drawing.Point(12, 27);
            this.txtCurDir.Multiline = true;
            this.txtCurDir.Name = "txtCurDir";
            this.txtCurDir.ReadOnly = true;
            this.txtCurDir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurDir.Size = new System.Drawing.Size(258, 129);
            this.txtCurDir.TabIndex = 1;
            // 
            // btnChangeDir
            // 
            this.btnChangeDir.Location = new System.Drawing.Point(12, 162);
            this.btnChangeDir.Name = "btnChangeDir";
            this.btnChangeDir.Size = new System.Drawing.Size(258, 23);
            this.btnChangeDir.TabIndex = 2;
            this.btnChangeDir.Text = "更换工作目录";
            this.btnChangeDir.UseVisualStyleBackColor = true;
            this.btnChangeDir.Click += new System.EventHandler(this.btnChangeDir_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(12, 191);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(258, 23);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "训练界面";
            this.btnTrain.UseVisualStyleBackColor = true;
            // 
            // btnClassification
            // 
            this.btnClassification.Location = new System.Drawing.Point(12, 220);
            this.btnClassification.Name = "btnClassification";
            this.btnClassification.Size = new System.Drawing.Size(258, 23);
            this.btnClassification.TabIndex = 4;
            this.btnClassification.Text = "分类界面";
            this.btnClassification.UseVisualStyleBackColor = true;
            this.btnClassification.Click += new System.EventHandler(this.btnClassification_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.btnClassification);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnChangeDir);
            this.Controls.Add(this.txtCurDir);
            this.Controls.Add(this.lblCurDir);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmMain";
            this.Text = "电力线识别主界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurDir;
        private System.Windows.Forms.TextBox txtCurDir;
        private System.Windows.Forms.Button btnChangeDir;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.FolderBrowserDialog fbdCurDir;
        private System.Windows.Forms.Button btnClassification;
    }
}


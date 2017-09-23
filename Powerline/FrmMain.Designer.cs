namespace Powerline
{
    partial class frmMain
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
            this.lblTool = new System.Windows.Forms.Label();
            this.txtToolPath = new System.Windows.Forms.TextBox();
            this.btnChangeToolPath = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.fbdCurDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClassification = new System.Windows.Forms.Button();
            this.lblExample = new System.Windows.Forms.Label();
            this.txtExamplePath = new System.Windows.Forms.TextBox();
            this.btnChangeExamplePath = new System.Windows.Forms.Button();
            this.grpPath = new System.Windows.Forms.GroupBox();
            this.grpSelectEnter = new System.Windows.Forms.GroupBox();
            this.grpPath.SuspendLayout();
            this.grpSelectEnter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Location = new System.Drawing.Point(6, 21);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(122, 15);
            this.lblTool.TabIndex = 0;
            this.lblTool.Text = "Caffe工具目录：";
            // 
            // txtToolPath
            // 
            this.txtToolPath.Location = new System.Drawing.Point(6, 39);
            this.txtToolPath.Multiline = true;
            this.txtToolPath.Name = "txtToolPath";
            this.txtToolPath.ReadOnly = true;
            this.txtToolPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToolPath.Size = new System.Drawing.Size(749, 55);
            this.txtToolPath.TabIndex = 1;
            // 
            // btnChangeToolPath
            // 
            this.btnChangeToolPath.Location = new System.Drawing.Point(6, 176);
            this.btnChangeToolPath.Name = "btnChangeToolPath";
            this.btnChangeToolPath.Size = new System.Drawing.Size(352, 23);
            this.btnChangeToolPath.TabIndex = 2;
            this.btnChangeToolPath.Text = "更换工具目录...";
            this.btnChangeToolPath.UseVisualStyleBackColor = true;
            this.btnChangeToolPath.Click += new System.EventHandler(this.btnChangeDir_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(6, 24);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(352, 23);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "训练（Training）界面";
            this.btnTrain.UseVisualStyleBackColor = true;
            // 
            // btnClassification
            // 
            this.btnClassification.Location = new System.Drawing.Point(403, 24);
            this.btnClassification.Name = "btnClassification";
            this.btnClassification.Size = new System.Drawing.Size(352, 23);
            this.btnClassification.TabIndex = 4;
            this.btnClassification.Text = "分类（Classification）界面";
            this.btnClassification.UseVisualStyleBackColor = true;
            this.btnClassification.Click += new System.EventHandler(this.btnClassification_Click);
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(6, 97);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(191, 15);
            this.lblExample.TabIndex = 5;
            this.lblExample.Text = "数据集目录（examples）：";
            // 
            // txtExamplePath
            // 
            this.txtExamplePath.Location = new System.Drawing.Point(6, 115);
            this.txtExamplePath.Multiline = true;
            this.txtExamplePath.Name = "txtExamplePath";
            this.txtExamplePath.ReadOnly = true;
            this.txtExamplePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExamplePath.Size = new System.Drawing.Size(749, 55);
            this.txtExamplePath.TabIndex = 6;
            // 
            // btnChangeExamplePath
            // 
            this.btnChangeExamplePath.Location = new System.Drawing.Point(403, 176);
            this.btnChangeExamplePath.Name = "btnChangeExamplePath";
            this.btnChangeExamplePath.Size = new System.Drawing.Size(352, 23);
            this.btnChangeExamplePath.TabIndex = 7;
            this.btnChangeExamplePath.Text = "更换数据集目录...";
            this.btnChangeExamplePath.UseVisualStyleBackColor = true;
            this.btnChangeExamplePath.Click += new System.EventHandler(this.btnChangeExamplePath_Click);
            // 
            // grpPath
            // 
            this.grpPath.Controls.Add(this.lblTool);
            this.grpPath.Controls.Add(this.btnChangeExamplePath);
            this.grpPath.Controls.Add(this.txtToolPath);
            this.grpPath.Controls.Add(this.txtExamplePath);
            this.grpPath.Controls.Add(this.lblExample);
            this.grpPath.Controls.Add(this.btnChangeToolPath);
            this.grpPath.Location = new System.Drawing.Point(9, 12);
            this.grpPath.Name = "grpPath";
            this.grpPath.Size = new System.Drawing.Size(761, 216);
            this.grpPath.TabIndex = 8;
            this.grpPath.TabStop = false;
            this.grpPath.Text = "路径设置";
            // 
            // grpSelectEnter
            // 
            this.grpSelectEnter.Controls.Add(this.btnTrain);
            this.grpSelectEnter.Controls.Add(this.btnClassification);
            this.grpSelectEnter.Location = new System.Drawing.Point(9, 234);
            this.grpSelectEnter.Name = "grpSelectEnter";
            this.grpSelectEnter.Size = new System.Drawing.Size(761, 159);
            this.grpSelectEnter.TabIndex = 9;
            this.grpSelectEnter.TabStop = false;
            this.grpSelectEnter.Text = "功能选择";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 405);
            this.Controls.Add(this.grpSelectEnter);
            this.Controls.Add(this.grpPath);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "电力线识别主界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPath.ResumeLayout(false);
            this.grpPath.PerformLayout();
            this.grpSelectEnter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.TextBox txtToolPath;
        private System.Windows.Forms.Button btnChangeToolPath;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.FolderBrowserDialog fbdCurDir;
        private System.Windows.Forms.Button btnClassification;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.TextBox txtExamplePath;
        private System.Windows.Forms.Button btnChangeExamplePath;
        private System.Windows.Forms.GroupBox grpPath;
        private System.Windows.Forms.GroupBox grpSelectEnter;
    }
}


namespace Powerline
{
    partial class frmClassification
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
            this.txtCurDir = new System.Windows.Forms.TextBox();
            this.lblCurDir = new System.Windows.Forms.Label();
            this.btnChangeDir = new System.Windows.Forms.Button();
            this.lblToolPath = new System.Windows.Forms.Label();
            this.txtToolPath = new System.Windows.Forms.TextBox();
            this.btnSelTool = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.lblPrototxt = new System.Windows.Forms.Label();
            this.txtPrototxtPath = new System.Windows.Forms.TextBox();
            this.btnSelectPrototxt = new System.Windows.Forms.Button();
            this.lblCaffemodel = new System.Windows.Forms.Label();
            this.txtCaffemodelPath = new System.Windows.Forms.TextBox();
            this.btnSelectCaffemodel = new System.Windows.Forms.Button();
            this.lblBinaryproto = new System.Windows.Forms.Label();
            this.txtBinaryprotoPath = new System.Windows.Forms.TextBox();
            this.btnSelectBinaryproto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabelsPath = new System.Windows.Forms.TextBox();
            this.btnSelectLabels = new System.Windows.Forms.Button();
            this.lblImg = new System.Windows.Forms.Label();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.picImgInput = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImgInput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurDir
            // 
            this.txtCurDir.Location = new System.Drawing.Point(12, 27);
            this.txtCurDir.Name = "txtCurDir";
            this.txtCurDir.ReadOnly = true;
            this.txtCurDir.Size = new System.Drawing.Size(758, 25);
            this.txtCurDir.TabIndex = 3;
            // 
            // lblCurDir
            // 
            this.lblCurDir.AutoSize = true;
            this.lblCurDir.Location = new System.Drawing.Point(12, 9);
            this.lblCurDir.Name = "lblCurDir";
            this.lblCurDir.Size = new System.Drawing.Size(112, 15);
            this.lblCurDir.TabIndex = 2;
            this.lblCurDir.Text = "当前工作目录：";
            // 
            // btnChangeDir
            // 
            this.btnChangeDir.Location = new System.Drawing.Point(12, 58);
            this.btnChangeDir.Name = "btnChangeDir";
            this.btnChangeDir.Size = new System.Drawing.Size(758, 23);
            this.btnChangeDir.TabIndex = 4;
            this.btnChangeDir.Text = "更换工作目录...";
            this.btnChangeDir.UseVisualStyleBackColor = true;
            // 
            // lblToolPath
            // 
            this.lblToolPath.AutoSize = true;
            this.lblToolPath.Location = new System.Drawing.Point(12, 84);
            this.lblToolPath.Name = "lblToolPath";
            this.lblToolPath.Size = new System.Drawing.Size(286, 15);
            this.lblToolPath.TabIndex = 5;
            this.lblToolPath.Text = "分类程序（Classification.exe）路径：";
            // 
            // txtToolPath
            // 
            this.txtToolPath.Location = new System.Drawing.Point(12, 102);
            this.txtToolPath.Name = "txtToolPath";
            this.txtToolPath.ReadOnly = true;
            this.txtToolPath.Size = new System.Drawing.Size(758, 25);
            this.txtToolPath.TabIndex = 6;
            // 
            // btnSelTool
            // 
            this.btnSelTool.Location = new System.Drawing.Point(12, 133);
            this.btnSelTool.Name = "btnSelTool";
            this.btnSelTool.Size = new System.Drawing.Size(758, 23);
            this.btnSelTool.TabIndex = 7;
            this.btnSelTool.Text = "打开...";
            this.btnSelTool.UseVisualStyleBackColor = true;
            this.btnSelTool.Click += new System.EventHandler(this.btnSelTool_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // lblPrototxt
            // 
            this.lblPrototxt.AutoSize = true;
            this.lblPrototxt.Location = new System.Drawing.Point(12, 159);
            this.lblPrototxt.Name = "lblPrototxt";
            this.lblPrototxt.Size = new System.Drawing.Size(292, 15);
            this.lblPrototxt.TabIndex = 8;
            this.lblPrototxt.Text = "模型描述文件（deploy.prototxt）路径：";
            // 
            // txtPrototxtPath
            // 
            this.txtPrototxtPath.Location = new System.Drawing.Point(12, 177);
            this.txtPrototxtPath.Name = "txtPrototxtPath";
            this.txtPrototxtPath.ReadOnly = true;
            this.txtPrototxtPath.Size = new System.Drawing.Size(758, 25);
            this.txtPrototxtPath.TabIndex = 9;
            // 
            // btnSelectPrototxt
            // 
            this.btnSelectPrototxt.Location = new System.Drawing.Point(12, 208);
            this.btnSelectPrototxt.Name = "btnSelectPrototxt";
            this.btnSelectPrototxt.Size = new System.Drawing.Size(758, 23);
            this.btnSelectPrototxt.TabIndex = 10;
            this.btnSelectPrototxt.Text = "打开...";
            this.btnSelectPrototxt.UseVisualStyleBackColor = true;
            this.btnSelectPrototxt.Click += new System.EventHandler(this.btnSelectPrototxt_Click);
            // 
            // lblCaffemodel
            // 
            this.lblCaffemodel.AutoSize = true;
            this.lblCaffemodel.Location = new System.Drawing.Point(12, 234);
            this.lblCaffemodel.Name = "lblCaffemodel";
            this.lblCaffemodel.Size = new System.Drawing.Size(316, 15);
            this.lblCaffemodel.TabIndex = 11;
            this.lblCaffemodel.Text = "模型均值文件（network.caffemodel）路径：";
            // 
            // txtCaffemodelPath
            // 
            this.txtCaffemodelPath.Location = new System.Drawing.Point(12, 252);
            this.txtCaffemodelPath.Name = "txtCaffemodelPath";
            this.txtCaffemodelPath.ReadOnly = true;
            this.txtCaffemodelPath.Size = new System.Drawing.Size(758, 25);
            this.txtCaffemodelPath.TabIndex = 12;
            // 
            // btnSelectCaffemodel
            // 
            this.btnSelectCaffemodel.Location = new System.Drawing.Point(12, 283);
            this.btnSelectCaffemodel.Name = "btnSelectCaffemodel";
            this.btnSelectCaffemodel.Size = new System.Drawing.Size(758, 23);
            this.btnSelectCaffemodel.TabIndex = 13;
            this.btnSelectCaffemodel.Text = "打开...";
            this.btnSelectCaffemodel.UseVisualStyleBackColor = true;
            this.btnSelectCaffemodel.Click += new System.EventHandler(this.btnSelectCaffemodel_Click);
            // 
            // lblBinaryproto
            // 
            this.lblBinaryproto.AutoSize = true;
            this.lblBinaryproto.Location = new System.Drawing.Point(12, 309);
            this.lblBinaryproto.Name = "lblBinaryproto";
            this.lblBinaryproto.Size = new System.Drawing.Size(300, 15);
            this.lblBinaryproto.TabIndex = 14;
            this.lblBinaryproto.Text = "图像均值文件（mean.binaryproto）路径：";
            // 
            // txtBinaryprotoPath
            // 
            this.txtBinaryprotoPath.Location = new System.Drawing.Point(12, 327);
            this.txtBinaryprotoPath.Name = "txtBinaryprotoPath";
            this.txtBinaryprotoPath.ReadOnly = true;
            this.txtBinaryprotoPath.Size = new System.Drawing.Size(758, 25);
            this.txtBinaryprotoPath.TabIndex = 15;
            // 
            // btnSelectBinaryproto
            // 
            this.btnSelectBinaryproto.Location = new System.Drawing.Point(12, 358);
            this.btnSelectBinaryproto.Name = "btnSelectBinaryproto";
            this.btnSelectBinaryproto.Size = new System.Drawing.Size(758, 23);
            this.btnSelectBinaryproto.TabIndex = 16;
            this.btnSelectBinaryproto.Text = "打开...";
            this.btnSelectBinaryproto.UseVisualStyleBackColor = true;
            this.btnSelectBinaryproto.Click += new System.EventHandler(this.btnSelectBinaryproto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "图像类别标签信息（labels.txt）路径：";
            // 
            // txtLabelsPath
            // 
            this.txtLabelsPath.Location = new System.Drawing.Point(12, 402);
            this.txtLabelsPath.Name = "txtLabelsPath";
            this.txtLabelsPath.ReadOnly = true;
            this.txtLabelsPath.Size = new System.Drawing.Size(758, 25);
            this.txtLabelsPath.TabIndex = 18;
            // 
            // btnSelectLabels
            // 
            this.btnSelectLabels.Location = new System.Drawing.Point(12, 433);
            this.btnSelectLabels.Name = "btnSelectLabels";
            this.btnSelectLabels.Size = new System.Drawing.Size(758, 23);
            this.btnSelectLabels.TabIndex = 19;
            this.btnSelectLabels.Text = "打开...";
            this.btnSelectLabels.UseVisualStyleBackColor = true;
            this.btnSelectLabels.Click += new System.EventHandler(this.btnSelectLabels_Click);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(397, 462);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(213, 15);
            this.lblImg.TabIndex = 20;
            this.lblImg.Text = "待分类图像（img.jpg）路径：";
            // 
            // txtImgPath
            // 
            this.txtImgPath.Location = new System.Drawing.Point(400, 480);
            this.txtImgPath.Multiline = true;
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.ReadOnly = true;
            this.txtImgPath.Size = new System.Drawing.Size(370, 50);
            this.txtImgPath.TabIndex = 21;
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(400, 536);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(370, 23);
            this.btnSelectImg.TabIndex = 22;
            this.btnSelectImg.Text = "打开...";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // picImgInput
            // 
            this.picImgInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImgInput.Location = new System.Drawing.Point(12, 462);
            this.picImgInput.Name = "picImgInput";
            this.picImgInput.Size = new System.Drawing.Size(379, 181);
            this.picImgInput.TabIndex = 23;
            this.picImgInput.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(400, 565);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(370, 78);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "分类测试";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 655);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picImgInput);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.txtImgPath);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.btnSelectLabels);
            this.Controls.Add(this.txtLabelsPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectBinaryproto);
            this.Controls.Add(this.txtBinaryprotoPath);
            this.Controls.Add(this.lblBinaryproto);
            this.Controls.Add(this.btnSelectCaffemodel);
            this.Controls.Add(this.txtCaffemodelPath);
            this.Controls.Add(this.lblCaffemodel);
            this.Controls.Add(this.btnSelectPrototxt);
            this.Controls.Add(this.txtPrototxtPath);
            this.Controls.Add(this.lblPrototxt);
            this.Controls.Add(this.btnSelTool);
            this.Controls.Add(this.txtToolPath);
            this.Controls.Add(this.lblToolPath);
            this.Controls.Add(this.btnChangeDir);
            this.Controls.Add(this.txtCurDir);
            this.Controls.Add(this.lblCurDir);
            this.MaximizeBox = false;
            this.Name = "frmClassification";
            this.Text = "电力线识别分类测试";
            this.Load += new System.EventHandler(this.frmClassification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImgInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurDir;
        private System.Windows.Forms.Label lblCurDir;
        private System.Windows.Forms.Button btnChangeDir;
        private System.Windows.Forms.Label lblToolPath;
        private System.Windows.Forms.TextBox txtToolPath;
        private System.Windows.Forms.Button btnSelTool;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Label lblPrototxt;
        private System.Windows.Forms.TextBox txtPrototxtPath;
        private System.Windows.Forms.Button btnSelectPrototxt;
        private System.Windows.Forms.Label lblCaffemodel;
        private System.Windows.Forms.TextBox txtCaffemodelPath;
        private System.Windows.Forms.Button btnSelectCaffemodel;
        private System.Windows.Forms.Label lblBinaryproto;
        private System.Windows.Forms.TextBox txtBinaryprotoPath;
        private System.Windows.Forms.Button btnSelectBinaryproto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLabelsPath;
        private System.Windows.Forms.Button btnSelectLabels;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.PictureBox picImgInput;
        private System.Windows.Forms.Button btnStart;
    }
}
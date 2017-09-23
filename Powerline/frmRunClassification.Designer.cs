namespace Powerline
{
    partial class frmRunClassification
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
            this.lblArgus = new System.Windows.Forms.Label();
            this.txtArgus = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblStdOut = new System.Windows.Forms.Label();
            this.txtStdOut = new System.Windows.Forms.TextBox();
            this.txtStdErr = new System.Windows.Forms.TextBox();
            this.lblStdErr = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblExecPath = new System.Windows.Forms.Label();
            this.txtExecPath = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArgus
            // 
            this.lblArgus.AutoSize = true;
            this.lblArgus.Location = new System.Drawing.Point(12, 130);
            this.lblArgus.Name = "lblArgus";
            this.lblArgus.Size = new System.Drawing.Size(82, 15);
            this.lblArgus.TabIndex = 0;
            this.lblArgus.Text = "参数列表：";
            // 
            // txtArgus
            // 
            this.txtArgus.Location = new System.Drawing.Point(12, 148);
            this.txtArgus.Multiline = true;
            this.txtArgus.Name = "txtArgus";
            this.txtArgus.ReadOnly = true;
            this.txtArgus.Size = new System.Drawing.Size(755, 100);
            this.txtArgus.TabIndex = 1;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 258);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(67, 15);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "准备就绪";
            // 
            // lblStdOut
            // 
            this.lblStdOut.AutoSize = true;
            this.lblStdOut.Location = new System.Drawing.Point(12, 282);
            this.lblStdOut.Name = "lblStdOut";
            this.lblStdOut.Size = new System.Drawing.Size(225, 15);
            this.lblStdOut.TabIndex = 3;
            this.lblStdOut.Text = "标准输出（Standard Output）:";
            // 
            // txtStdOut
            // 
            this.txtStdOut.Location = new System.Drawing.Point(12, 300);
            this.txtStdOut.Multiline = true;
            this.txtStdOut.Name = "txtStdOut";
            this.txtStdOut.ReadOnly = true;
            this.txtStdOut.Size = new System.Drawing.Size(755, 100);
            this.txtStdOut.TabIndex = 4;
            // 
            // txtStdErr
            // 
            this.txtStdErr.Location = new System.Drawing.Point(12, 421);
            this.txtStdErr.Multiline = true;
            this.txtStdErr.Name = "txtStdErr";
            this.txtStdErr.ReadOnly = true;
            this.txtStdErr.Size = new System.Drawing.Size(755, 100);
            this.txtStdErr.TabIndex = 6;
            // 
            // lblStdErr
            // 
            this.lblStdErr.AutoSize = true;
            this.lblStdErr.Location = new System.Drawing.Point(12, 403);
            this.lblStdErr.Name = "lblStdErr";
            this.lblStdErr.Size = new System.Drawing.Size(217, 15);
            this.lblStdErr.TabIndex = 5;
            this.lblStdErr.Text = "标准错误（Standard Error）:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(692, 254);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "执行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblExecPath
            // 
            this.lblExecPath.AutoSize = true;
            this.lblExecPath.Location = new System.Drawing.Point(12, 9);
            this.lblExecPath.Name = "lblExecPath";
            this.lblExecPath.Size = new System.Drawing.Size(82, 15);
            this.lblExecPath.TabIndex = 8;
            this.lblExecPath.Text = "程序路径：";
            // 
            // txtExecPath
            // 
            this.txtExecPath.Location = new System.Drawing.Point(15, 27);
            this.txtExecPath.Multiline = true;
            this.txtExecPath.Name = "txtExecPath";
            this.txtExecPath.ReadOnly = true;
            this.txtExecPath.Size = new System.Drawing.Size(755, 100);
            this.txtExecPath.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("宋体", 12F);
            this.lblResult.Location = new System.Drawing.Point(12, 524);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(109, 20);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "识别结果：";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("宋体", 24F);
            this.txtResult.Location = new System.Drawing.Point(12, 547);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(755, 96);
            this.txtResult.TabIndex = 11;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmRunClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 655);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtExecPath);
            this.Controls.Add(this.lblExecPath);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtStdErr);
            this.Controls.Add(this.lblStdErr);
            this.Controls.Add(this.txtStdOut);
            this.Controls.Add(this.lblStdOut);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtArgus);
            this.Controls.Add(this.lblArgus);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "frmRunClassification";
            this.Text = "电力线识别执行程序";
            this.Load += new System.EventHandler(this.frmRunClassification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArgus;
        private System.Windows.Forms.TextBox txtArgus;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblStdOut;
        private System.Windows.Forms.TextBox txtStdOut;
        private System.Windows.Forms.TextBox txtStdErr;
        private System.Windows.Forms.Label lblStdErr;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblExecPath;
        private System.Windows.Forms.TextBox txtExecPath;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}
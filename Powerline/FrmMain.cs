using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Powerline
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CGlobal.CurPath = Directory.GetCurrentDirectory();
            CGlobal.ExamplePath = @"E:\DeepLearningEnv\caffe-master\examples\powerline\class";
            CGlobal.ToolPath = @"E:\DeepLearningEnv\caffe-master\Build\x64\Release";
            txtToolPath.Text = CGlobal.ToolPath;
            txtExamplePath.Text = CGlobal.ExamplePath;
        }

        private void btnChangeDir_Click(object sender, EventArgs e)
        {
            fbdCurDir.SelectedPath = CGlobal.ToolPath;
            if (fbdCurDir.ShowDialog() == DialogResult.OK)
            {
                txtToolPath.Text = fbdCurDir.SelectedPath;
                CGlobal.ToolPath = fbdCurDir.SelectedPath;
            }
        }

        private void btnClassification_Click(object sender, EventArgs e)
        {
            frmClassification frmcf = new frmClassification();
            this.Hide();
            frmcf.ShowDialog();
            frmcf.Dispose();
            this.Show();
            this.txtToolPath.Text = CGlobal.ToolPath;
        }

        private void btnChangeExamplePath_Click(object sender, EventArgs e)
        {
            fbdCurDir.SelectedPath = CGlobal.ExamplePath;
            if (fbdCurDir.ShowDialog() == DialogResult.OK)
            {
                txtExamplePath.Text = fbdCurDir.SelectedPath;
                CGlobal.ExamplePath = fbdCurDir.SelectedPath;
            }
        }
    }
}

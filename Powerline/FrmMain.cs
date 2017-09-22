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
            CGlobal.CaffePath = @"E:\DeepLearningEnv\caffe-master\examples\powerline\class";
            CGlobal.CurPath = CGlobal.CaffePath;
            txtCurDir.Text = CGlobal.CurPath;
        }

        private void btnChangeDir_Click(object sender, EventArgs e)
        {
            fbdCurDir.SelectedPath = CGlobal.CurPath;
            if (fbdCurDir.ShowDialog() == DialogResult.OK)
            {
                txtCurDir.Text = fbdCurDir.SelectedPath;
                CGlobal.CurPath = fbdCurDir.SelectedPath;
            }
        }

        private void btnClassification_Click(object sender, EventArgs e)
        {
            frmClassification frmcf = new frmClassification();
            this.Hide();
            frmcf.ShowDialog();
            frmcf.Dispose();
            this.Show();
            this.txtCurDir.Text = CGlobal.CurPath;
        }
    }
}

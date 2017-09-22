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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CGlobal.CurPath = Directory.GetCurrentDirectory();
            CGlobal.CurPath = @"E:\DeepLearningEnv\caffe-master";
            txtCurDir.Text = CGlobal.CurPath;
        }

        private void btnChangeDir_Click(object sender, EventArgs e)
        {
            if (fbdCurDir.ShowDialog() == DialogResult.OK)
            {
                txtCurDir.Text = fbdCurDir.SelectedPath;
                CGlobal.CurPath = fbdCurDir.SelectedPath;
            }
        }

        private void btnClassification_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Powerline
{
    public partial class frmClassification : Form
    {
        public frmClassification()
        {
            InitializeComponent();
        }

        private void frmClassification_Load(object sender, EventArgs e)
        {
            txtCurDir.Text = CGlobal.CurPath;
            ofdFile.InitialDirectory = CGlobal.CurPath;
        }

        private void btnSelTool_Click(object sender, EventArgs e)
        {
            ofdFile.Filter = "分类程序|Classification.exe";
            ofdFile.FileName = "";
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtToolPath.Text = ofdFile.FileName;
            }
        }

        private void btnSelectPrototxt_Click(object sender, EventArgs e)
        {
            ofdFile.Filter = "模型描述文件|*.prototxt";
            ofdFile.FileName = "";
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtPrototxtPath.Text = ofdFile.FileName;
            }
        }

        private void btnSelectCaffemodel_Click(object sender, EventArgs e)
        {
            ofdFile.Filter = "模型均值文件|*.caffemodel";
            ofdFile.FileName = "";
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtCaffemodelPath.Text = ofdFile.FileName;
            }
        }

        private void btnSelectBinaryproto_Click(object sender, EventArgs e)
        {
            ofdFile.Filter = "图像均值文件|*.binaryproto";
            ofdFile.FileName = "";
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtBinaryprotoPath.Text = ofdFile.FileName;
            }
        }

        private void btnSelectLabels_Click(object sender, EventArgs e)
        {
            ofdFile.Filter = "图像均值文件|*.txt";
            ofdFile.FileName = "";
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtLabelsPath.Text = ofdFile.FileName;
            }
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            ofdFile.Filter = "待分类图像|*.jpg";
            ofdFile.FileName = "";
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtImgPath.Text = ofdFile.FileName;
                picImgInput.ImageLocation = txtImgPath.Text;
                picImgInput.Load();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Process proClassification = new Process();
            string strArgu;
            string strError, strOutput;
            strArgu =string.Format(@"""{0}"" ""{1}"" ""{2}"" ""{3}"" ""{4}""",
                txtPrototxtPath.Text, txtCaffemodelPath.Text, txtBinaryprotoPath.Text,
                txtLabelsPath.Text, txtImgPath.Text);
            if (MessageBox.Show(string.Format("Argus:\r\n{0}", strArgu)) == DialogResult.No)
            {
                return;
            }
            proClassification.StartInfo.FileName = txtToolPath.Text;
            proClassification.StartInfo.Arguments = strArgu;
            proClassification.StartInfo.UseShellExecute = false;
            proClassification.StartInfo.CreateNoWindow = true;
            proClassification.StartInfo.RedirectStandardInput = true;
            proClassification.StartInfo.RedirectStandardOutput = true;
            proClassification.StartInfo.RedirectStandardError = true;
            try
            {
                proClassification.Start();
                while (!proClassification.HasExited) ;
                strOutput = proClassification.StandardOutput.ReadToEnd();
                strError = proClassification.StandardError.ReadToEnd();
                MessageBox.Show(string.Format("StandardOutput:\r\n{0}", strOutput));
                MessageBox.Show(string.Format("StandardError:\r\n{0}", strError));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

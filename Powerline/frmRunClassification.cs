using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Powerline
{
    public partial class frmRunClassification : Form
    {
        public frmRunClassification()
        {
            InitializeComponent();
        }

        public frmRunClassification(string strExec, string strArgus)
        {
            InitializeComponent();
            txtArgus.Text = strArgus;
            txtExecPath.Text = strExec;
        }

        private void frmRunClassification_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "正在执行...";
            Process proClassification = new Process();
            proClassification.StartInfo.FileName = txtExecPath.Text;
            proClassification.StartInfo.Arguments = txtArgus.Text;
            proClassification.StartInfo.UseShellExecute = false;
            proClassification.StartInfo.CreateNoWindow = true;
            proClassification.StartInfo.RedirectStandardInput = true;
            proClassification.StartInfo.RedirectStandardOutput = true;
            proClassification.StartInfo.RedirectStandardError = true;
            try
            {
                proClassification.Start();
                while (!proClassification.HasExited) ;
                txtStdOut.Text = proClassification.StandardOutput.ReadToEnd();
                txtStdErr.Text = proClassification.StandardError.ReadToEnd();
                if (proClassification.ExitCode != 0)
                {
                    lblMsg.Text = "异常退出";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "异常退出";
                MessageBox.Show(ex.ToString());
                return;
            }
            lblMsg.Text = "执行完毕";
            this.ShowResult();
        }

        private void ShowResult()
        {
            Regex parttern = new Regex(@"(?<=\"").*?(?=\"")");
            MatchCollection matches = parttern.Matches(txtStdOut.Text);
            if (matches.Count > 0)
            {
                switch (matches[0].ToString())
                {
                    case "1 Sample with line":
                        txtResult.Text = "该图中含电力线区域";
                        break;
                    case "0 No line in sample":
                        txtResult.Text = "该图中不含电力线区域";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                txtResult.Text = "识别有误";
            }
        }
    }
}

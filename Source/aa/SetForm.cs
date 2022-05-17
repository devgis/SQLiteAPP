using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace aa
{
    public partial class SetForm : Form
    {
        string proxyurlsPath = Path.Combine(Application.StartupPath, "proxy.config");
        string showlogPath = Path.Combine(Application.StartupPath, "showlog.config");
        public SetForm()
        {
            InitializeComponent();
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            //读取配置信息
            try
            {
                tbProxyURLS.Text = File.ReadAllText(proxyurlsPath, Encoding.Default);
            }
            catch
            {
               
            }

            //string showlog = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string showlog = "";
            try
            {
                showlog = File.ReadAllText(showlogPath, Encoding.Default);
            }
            catch
            { }
            if ("TRUE".Equals(showlog.ToUpper()))
            {
                cbShowLog.Checked = true;
            }
            else
            {
                cbShowLog.Checked = false;
            }
        }

        private void btSet_Click(object sender, EventArgs e)
        {
            try
            {
                //写配置信息
                try
                {
                    File.WriteAllText(proxyurlsPath, tbProxyURLS.Text, Encoding.Default);
                }
                catch
                {

                }

                if (cbShowLog.Checked)
                {
                    File.WriteAllText(showlogPath, "true", Encoding.Default);
                }
                else
                {
                    File.WriteAllText(showlogPath, "false", Encoding.Default);
                }
                MessageBox.Show("保存成功！");
            }
            catch
            {
                MessageBox.Show("保存失败！");
            }
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

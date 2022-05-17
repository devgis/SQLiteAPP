using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace aa
{
    public partial class AddAndEdit : Form
    {
        public AddAndEdit()
        {
            InitializeComponent();
            this.Text = "添加应用";
        }

        string Pkey = string.Empty;
        public AddAndEdit(string pkey)
        {
            InitializeComponent();
            this.Text = "编辑应用";
            btOK.Text = "保存";
            Pkey = pkey;

            string sql = String.Format("select * from t_appinfo where pkey='{0}'", pkey);
            DataTable dt = SqliteHelper.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                tbID.Text = dt.Rows[0]["id"].ToString();
                tbName.Text = dt.Rows[0]["name"].ToString();
                tbURL.Text = dt.Rows[0]["url"].ToString();
                tbRemarks.Text = dt.Rows[0]["remarks"].ToString();
                
                nudDayRequire.Value = Convert.ToInt32(dt.Rows[0]["dayrequire"]);
                nudDays.Value = Convert.ToInt32(dt.Rows[0]["das"]);
                nudStartno.Value = Convert.ToInt32(dt.Rows[0]["startno"]);
                nudThreads.Value = Convert.ToInt32(dt.Rows[0]["threads"]);
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (string.IsNullOrEmpty(Pkey))
                {
                    //添加
                    string sql = "insert into t_appinfo(pkey,id,name,url,startno,dayrequire,das,threads,remarks)values(@pkey,@id,@name,@url,@startno,@dayrequire,@das,@threads,@remarks)";
                    SQLiteParameter[] parameters = {
                    new SQLiteParameter("@pkey", DbType.String),
                    new SQLiteParameter("@id", DbType.String),
                    new SQLiteParameter("@name", DbType.String),
                    new SQLiteParameter("@url", DbType.String),
                    new SQLiteParameter("@startno", DbType.Int32),
                    new SQLiteParameter("@dayrequire", DbType.Int32),
                    new SQLiteParameter("@das", DbType.Int32),
                    new SQLiteParameter("@threads", DbType.Int32),
                    new SQLiteParameter("@remarks", DbType.String)};
                    parameters[0].Value = Guid.NewGuid().ToString();
                    parameters[1].Value = tbID.Text;
                    parameters[2].Value = tbName.Text;
                    parameters[3].Value = tbURL.Text;
                    parameters[4].Value = nudStartno.Value;
                    parameters[5].Value = nudDayRequire.Value;
                    parameters[6].Value = nudDays.Value;
                    parameters[7].Value = nudThreads.Value;
                    parameters[8].Value = tbRemarks.Text;
                    try
                    {
                        if (SqliteHelper.ExcuteSQL(sql, parameters))
                        {
                            MessageBox.Show("添加成功！");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("保存失败！");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("保存中发生异常:" + ex.Message);
                    }
                }
                else
                {
                    //修改
                    string sql = "update t_appinfo set id=@id,name=@name,url=@url,startno=@startno,dayrequire=@dayrequire,das=@das,threads=@threads,remarks=@remarks where pkey=@pkey";
                    SQLiteParameter[] parameters = {
                    new SQLiteParameter("@pkey", DbType.String),
                    new SQLiteParameter("@id", DbType.String),
                    new SQLiteParameter("@name", DbType.String),
                    new SQLiteParameter("@url", DbType.String),
                    new SQLiteParameter("@startno", DbType.Int32),
                    new SQLiteParameter("@dayrequire", DbType.Int32),
                    new SQLiteParameter("@das", DbType.Int32),
                    new SQLiteParameter("@threads", DbType.Int32),
                    new SQLiteParameter("@remarks", DbType.String)};
                    parameters[0].Value = Pkey;
                    parameters[1].Value = tbID.Text;
                    parameters[2].Value = tbName.Text;
                    parameters[3].Value = tbURL.Text;
                    parameters[4].Value = nudStartno.Value;
                    parameters[5].Value = nudDayRequire.Value;
                    parameters[6].Value = nudDays.Value;
                    parameters[7].Value = nudThreads.Value;
                    parameters[8].Value = tbRemarks.Text;
                    try
                    {
                        if (SqliteHelper.ExcuteSQL(sql, parameters))
                        {
                            MessageBox.Show("保存成功！");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("保存失败！");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("保存中发生异常:" + ex.Message);
                    }
                }
                
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(tbURL.Text.Trim()))
            {
                MessageBox.Show("商店链接不能为空！");
                tbURL.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show("名称不能为空！");
                tbName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbID.Text.Trim()))
            {
                MessageBox.Show("ID不能为空！");
                tbID.Focus();
                return false;
            }

            
            return true;
        }
    }
}

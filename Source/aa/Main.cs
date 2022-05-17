using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aa
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region 菜单
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void System_Exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread(); //退出系统
        }
        #endregion

        #region 工具栏事件
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtAdd_Click(object sender, EventArgs e)
        {
            AddAndEdit frmAddAndEdit = new AddAndEdit();
            frmAddAndEdit.Text = "添加应用";
            if (frmAddAndEdit.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtEdit_Click(object sender, EventArgs e)
        {
            if (dgvTaskList.SelectedRows != null && dgvTaskList.SelectedRows.Count > 0)
            {
                string pkey = dgvTaskList.SelectedRows[0].Cells["CPKey"].Value.ToString();
                AddAndEdit frmAddAndEdit = new AddAndEdit(pkey);
                if (frmAddAndEdit.ShowDialog() == DialogResult.OK)
                {
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("请点击行头选中!");
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtRemove_Click(object sender, EventArgs e)
        {
            if (dgvTaskList.SelectedRows != null && dgvTaskList.SelectedRows.Count > 0)
            {
                string pkey = dgvTaskList.SelectedRows[0].Cells["CPKey"].Value.ToString();
                string sql = string.Format("delete from t_appinfo where pkey='{0}'", pkey);
                try
                {
                    if (SqliteHelper.ExcuteSQL(sql))
                    {
                        MessageBox.Show("删除成功！");
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除中发生异常:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("请点击行头选中!");
            }
        }
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtSet_Click(object sender, EventArgs e)
        {
            SetForm frmSetForm = new SetForm();
            frmSetForm.ShowDialog();
        }
        /// <summary>
        /// 全部开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtStartAll_Click(object sender, EventArgs e)
        {
            //全部开始代码在这里
            MessageBox.Show("全部开始事件触发！");
        }
        /// <summary>
        /// 全部停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtStopAll_Click(object sender, EventArgs e)
        {
            //全部停止代码在这里
            MessageBox.Show("全部停止事件触发！");
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        #endregion

        /// <summary>
        /// 刷新数据
        /// </summary>
        private void RefreshData()
        {
            string sql = "select * from t_appinfo";
            DataTable dt = SqliteHelper.GetDataTable(sql);
            dgvTaskList.Rows.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    int index = dgvTaskList.Rows.Add();
                    dgvTaskList.Rows[index].Cells["CPKey"].Value = dr["pkey"].ToString();
                    dgvTaskList.Rows[index].Cells["CPKey"].Tag = dr["pkey"];

                    dgvTaskList.Rows[index].Cells["CName"].Value = dr["name"].ToString();
                    dgvTaskList.Rows[index].Cells["CThreas"].Value = dr["threads"].ToString();
                    dgvTaskList.Rows[index].Cells["CDays"].Value = dr["das"].ToString();
                    dgvTaskList.Rows[index].Cells["CRemarks"].Value = dr["remarks"].ToString();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrInforCheck
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            DgvMater.AutoGenerateColumns = false;
            DgvMater.RowHeadersDefaultCellStyle.Padding = new Padding(0);
            DgvMater.RowsDefaultCellStyle.BackColor = Color.LightCyan;   //设置隔行变色
            DgvMater.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
        }
        List<scanInfor> mastList = new List<scanInfor>();
        public string curUrl, curBath;  //当前域名、批号

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtNumber.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mastList.Clear();
            RefdgvMaster();
            curBath = string.Empty;
            curUrl = string.Empty;
            txtCurBath.Text = string.Empty;
            txtUrl.Text = string.Empty;
            txtLog.Text = string.Empty;
            lbIsRepass.BackColor = Color.Green;
            lbReBath.BackColor = Color.Green;
            lbIsRepass.Text = "无重复";
            lbReBath.Text = "同批号";
            txtNumber.Focus();
        }

        private void DgvMater_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            for (int i = 0; i < dgv.Rows.Count; i++)  //加序号
            {
                dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
                if (Convert.ToBoolean(dgv.Rows[i].Cells["IsReNumber"].Value) == true) dgv.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                if (Convert.ToBoolean(dgv.Rows[i].Cells["IsBathDif"].Value) == true) dgv.Rows[i].Cells["IsBathDif"].Style.BackColor = Color.RoyalBlue;
            }
            dgv.ClearSelection();
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            string fullInfor = txtNumber.Text.Trim();
            int strLength = fullInfor.Length;
            if (strLength <30)
            {
                txtLog.Text += DateTime.Now.ToString("HH:mm:ss") + " 录入错误信息，长度不够: " + fullInfor + "\n";
                txtNumber.Text = string.Empty;
                txtNumber.Focus();
                return;
            }
            scanInfor temScan = GetScanInfor(fullInfor);
            if (temScan.Batch == null )
            {
                txtLog.Text += DateTime.Now.ToString("HH:mm:ss") + " 录入错误信息，获取批号及号码失败: " + fullInfor + "\r\n";
                txtNumber.Text = string.Empty;
                txtNumber.Focus();
                return;
            }
            if (mastList.Count < 1)   //首次添加
            {
                //temScan.IsReBath = false;
                //temScan.IsReNumber = false;
                curBath = temScan.Batch;
                curUrl = GetUrlByFull(fullInfor);
                txtCurBath.Text = curBath;
                txtUrl.Text = curUrl;
                mastList.Add(temScan);
                RefdgvMaster();
                txtLog.Text += DateTime.Now.ToString("HH:mm:ss") + " 第一枪编号: " + temScan.Number + "\r\n";
                txtNumber.Text = string.Empty;
                txtNumber.Focus();
            }
            else
            {
                if (curUrl != GetUrlByFull(fullInfor))
                {
                    txtLog.Text += DateTime.Now.ToString("HH:mm:ss") + " 录入错误信息，主域名不符： " + fullInfor + "\r\n";
                    txtNumber.Text = string.Empty;
                    txtNumber.Focus();
                    return;
                }
                if (curBath != temScan.Batch)
                { temScan.IsBathDif = true;  //检查批号是否相同
                    lbReBath.Text = "不同批";
                    lbReBath.BackColor = Color.Red;
                    txtLog.Text += DateTime.Now.ToString("HH:mm:ss") + " 发现不同批号： " + fullInfor + "\r\n";
                }

                //下面验证编号重复
                bool isRe = false;
                foreach (scanInfor item in mastList)
                {
                    if (item.Number == temScan.Number)
                    {
                        item.IsReNumber = true;
                        isRe = true;
                        temScan.IsReNumber = true;
                    }
                }
                if (isRe)
                {
                    lbIsRepass.Text = "有重复";
                    lbIsRepass.BackColor = Color.Red;
                    txtLog.Text += DateTime.Now.ToString("HH:mm:ss") + " 发现编号重复： " + fullInfor + "\r\n";
                }     
               



                    mastList.Add(temScan);
                txtNumber.Text = string.Empty;
                txtNumber.Focus();
                RefdgvMaster();
            }

     
        }
        /// <summary>
        /// 根据完整网址获取扫描信息
        /// </summary>
        /// <param name="fullInfor"></param>
        /// <returns></returns>
        private scanInfor GetScanInfor(string fullInfor)
        {
            scanInfor temInfor = new scanInfor();
            fullInfor = fullInfor.Substring(fullInfor.Length - 20);
            if (fullInfor.Substring(0, 2) != "o=")
            {
                return temInfor;
            }
            temInfor .Batch  = fullInfor.Substring(9,6);
            temInfor.Number = fullInfor.Substring(fullInfor.Length - 3, 3);
            return temInfor;
        }
        /// <summary>
        /// 根据完整网址获取主域名
        /// </summary>
        /// <param name="fullUrl"></param>
        /// <returns></returns>
        private string GetUrlByFull(string fullUrl)
        {
            int index = fullUrl.LastIndexOf('/');
            if (index < 0) return string.Empty;
            return fullUrl.Substring(0, index + 1);

        }

        private void RefdgvMaster()
        {
            DgvMater.DataSource = null;
            DgvMater.DataSource =new BindingCollection<scanInfor>(mastList);
            lbCount.Text = mastList.Count.ToString();
        }

    }
}

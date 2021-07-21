using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 使用牌照稅應納稅額試算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, int> Moto = new Dictionary<string, int>();
        Dictionary<string, int> Truck = new Dictionary<string, int>();
        Dictionary<string, int> Bus = new Dictionary<string, int>();
        Dictionary<string, int> Privatecar = new Dictionary<string, int>();
        Dictionary<string, int> Businesscar = new Dictionary<string, int>();
        #region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            Unit();
            {
                for (int A = 0; A <= itemmoto.GetUpperBound(0); A++)
                {
                    Moto.Add(itemmoto[A], motovalue[A]);
                }
                for (int B = 0; B <= itemtruck.GetUpperBound(0); B++)
                {
                    Truck.Add(itemtruck[B], truckvalue[B]);
                }
                for (int C = 0; C <= itembus.GetUpperBound(0); C++)
                {
                    Bus.Add(itembus[C], busvalue[C]);
                }
                for (int D = 0; D <= itemprivatecar.GetUpperBound(0); D++)
                {
                    Privatecar.Add(itemprivatecar[D], privatecarvalue[D]);
                }
                for (int E = 0; E <= itembusinesscar.GetUpperBound(0); E++)
                {
                    Businesscar.Add(itembusinesscar[E], businesscarvalue[E]);
                }
            }
            this.dateTimePicker2To.MinDate = DateTime.Now;

        }
        #endregion
        #region 使用期間按鈕設定
        private void rdb1year_Click(object sender, EventArgs e)
        {
            lblfrom.Visible = false;
            lblto.Visible = false;
            dateTimePicker1From.Visible = false;
            dateTimePicker2To.Visible = false;
            lblstartdate.Visible = false;
            lblenddate.Visible = false;
        }
        private void rdb2interval_Click(object sender, EventArgs e)
        {
            lblfrom.Visible = true;
            lblto.Visible = true;
            dateTimePicker1From.Visible = true;
            dateTimePicker2To.Visible = true;
            lblstartdate.Visible = true;
            lblstartdate.ForeColor = Color.Blue;
            lblenddate.Visible = true;
            lblenddate.ForeColor = Color.Blue;
        }
        #endregion
        #region 確定送出按鍵設定
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            txtBoxShowRes.Clear();
            //判斷使用者選取項目及其對應汽缸CC數，再將稅額值放入
            string select1 = (string)Conbo1purp.SelectedItem;
            string select2 = (string)conbo2CC.SelectedItem;
            int value;
            switch (select1)
            {
                case "機車":
                    value = Moto[select2];
                    break;
                case "貨車":
                    value = Truck[select2];
                    break;
                case "大客車":
                    value = Bus[select2];
                    break;
                case "自用小客車":
                    value = Privatecar[select2];
                    break;
                case "營業用小客車":
                    value = Businesscar[select2];
                    break;
                default:
                    value = 0;
                    break;
            }
            //使用者選取年度或區間
            DateTime DateFrom, DateTo;
            if (rdb1year.Checked) //使用者選取全年度
            {
                lblenddate.Visible = false;
                DateFrom = new DateTime(DateTime.Now.Year, 1, 1);
                DateTo = new DateTime(DateTime.Now.Year, 12, 31);
            }
            else  //使用者選取區間
            {
                DateFrom = dateTimePicker1From.Value.Date;
                DateTo = dateTimePicker2To.Value.Date;
            }
            //  宣告時間計算需要使用的變數及List
            int TotalYear = dateTimePicker2To.Value.Year - dateTimePicker1From.Value.Year + 1;  //跨年份的數量
            List<int> CrossYear = new List<int>();                                              //跨的年份
            List<int> EachyearDays = new List<int>();                                           //每一年的天數
            List<DateTime[]> Days = new List<DateTime[]>();                                     //每一年的天數區間
            List<int> EachYearDaysCount = new List<int>();                                      //每一年區間的天數
            List<int> ResultCount = new List<int>();                                            //每一年區間的稅額計算結果
            //  運用DateFrom和DateTo(使用者選取的值)，並將值填入各個List
            //  確認使用者選取的區間，共為幾年
            for (int i = 0; i < TotalYear ; i++)
            CrossYear.Add(DateFrom.Year + i);
            //  如果使用者選取的年份有閏年即輸入整數366，如無輸入整數365
            foreach (int CrossYearData in CrossYear)
            {
                if (DateTime.IsLeapYear(CrossYearData))
                {
                    EachyearDays.Add(366);
                }
                else
                {
                    EachyearDays.Add(365);
                } 
            }
            for(int i = 0; i < TotalYear ; i++)
            {
                if (i == 0)
                {
                    if (TotalYear == 1)
                    {
                        Days.Add(new DateTime[] { DateFrom, DateTo });                       
                    }
                    else
                    {
                        Days.Add(new DateTime[] { DateFrom, new DateTime(DateFrom.Year, 12, 31) });
                    }
                }
                else if(i == TotalYear -1)
                {
                    Days.Add(new DateTime[] {new DateTime(DateFrom.Year + i, 1, 1), DateTo});
                }
                else 
                {
                    Days.Add(new DateTime[] {new DateTime(DateFrom.Year + i, 1, 1), new DateTime(DateFrom.Year + i, 12, 31)});
                }
            }
            for( int i = 0; i < TotalYear; i++)
            {
                if (i == 0)
                {
                    EachYearDaysCount.Add((Days[i][1] - Days[i][0]).Days + 1);
                }
                else if (i == TotalYear - 1)
                {
                    EachYearDaysCount.Add((Days[i][1] - Days[i][0]).Days + 1);
                }
                else
                {
                    EachYearDaysCount.Add((Days[i][1] - Days[i][0]).Days + 1);
                }
            }
            for (int i = 0; i < TotalYear; i++)
            {
                ResultCount.Add(value* EachYearDaysCount[i] / EachyearDays[i]);
            }
            #endregion
            #region 結果顯示區
            // 結果計算及顯示

                txtBoxShowRes.Visible = true;
            for(int i = 0; i < TotalYear; i++)
            {
            txtBoxShowRes.Text += 
            $"使用期間：{Days[i][0].ToString("yyyy MM dd")} ~ {Days[i][1].ToString("yyyy MM dd")} {Environment.NewLine}" +
            $"計算天數：{EachYearDaysCount[i]}天{ Environment.NewLine}" +
            $"汽缸CC數：{conbo2CC.SelectedItem}{Environment.NewLine}" +
            $"用途：{Conbo1purp.SelectedItem}{Environment.NewLine}" +
            $"計算公式：{value} * {EachYearDaysCount[i]} / {EachyearDays[i]}  = {ResultCount[i]} {Environment.NewLine}" +
            $"應納稅額：{ResultCount[i]}元 {Environment.NewLine}" +
            $"----------------------------- {Environment.NewLine}";
            }
            int totaltax = 0;
            foreach (int totalresult in ResultCount)
            {
                totaltax += totalresult;
            }
            txtBoxShowRes.Text += $"共計{TotalYear}筆，試算結果總計為{totaltax}元";
            #endregion
        }
        #region 重填及離開按鈕設定
        private void btnreset_Click(object sender, EventArgs e)
        {
            Unit();
            txtBoxShowRes.Visible = false;
            lblhint.Visible = true;
            conbo2CC.SelectedIndex = -1;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定離開系統嘛?", "使用牌照稅應納稅額試算", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
                Application.Exit();
        }
        #endregion
        #region 表單啟動初始項
        //表單啟動之初始值設定
        private void Unit() 
        {
            lblhint.Visible = true;
            lblhint.Text = "點選所有選項後，即可啟用本程式";
            lblhint.ForeColor = Color.Blue;
            btnconfirm.Enabled = false;
            rdb1year.PerformClick();
            Conbo1purp.SelectedIndex = 0;
            lblintro.Visible = true;
            lblintro.Text = "備註：本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
        }
        #endregion
        #region 將汽缸CC數傳入選擇之用途
        //使用者選擇用途後，被選定之汽缸CC數傳進汽缸CC數/馬達馬力ConboBox'
        private void Conbo1purp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Conbo1purp.SelectedIndex;
            conbo2CC.Items.Clear();
            if (a == 0)
            {
                conbo2CC.Items.Clear();
                conbo2CC.Text = "";
                txtBoxShowRes.Text = "";
                btnconfirm.Enabled = false;
                conbo2CC.Items.AddRange(itemmoto);
                lblhint.Visible = true;
            }
            else if(a == 1)
            {
                conbo2CC.Items.Clear();
                conbo2CC.Text = "";
                txtBoxShowRes.Text = "";
                btnconfirm.Enabled = false;
                conbo2CC.Items.AddRange(itemtruck);
                lblhint.Visible = true;
            }
            else if (a == 2)
            {
                conbo2CC.Items.Clear();
                conbo2CC.Text = "";
                txtBoxShowRes.Text = "";
                btnconfirm.Enabled = false;
                conbo2CC.Items.AddRange(itembus);
                lblhint.Visible = true;
            }
            else if (a == 3)
            {
                conbo2CC.Items.Clear();
                conbo2CC.Text = "";
                txtBoxShowRes.Text = "";
                btnconfirm.Enabled = false;
                conbo2CC.Items.AddRange(itemprivatecar);
                lblhint.Visible = true;
            }
            else if (a == 4)
            {
                conbo2CC.Items.Clear();
                conbo2CC.Text = "";
                btnconfirm.Enabled = false;
                conbo2CC.Items.AddRange(itembusinesscar);
                lblhint.Visible = true;
            }
        }
        #endregion
        #region 各用途之汽缸數及稅額
        //將用途之汽缸數及稅額，各別裝進一個陣列中。
        private readonly string[] itemmoto = new string[]
        {
            "150以下 / 12HP以下(12.2PS以下)",
            "151-250 / 12.1-20HP(12.3-20.3PS)",
            "251-500 / 20.1HP以上(20.4PS以上)",
            "501-600","601-1200","1201-1800","1801或以上"
        };
        private readonly int[] motovalue = new int[]
        {
            0,800,1620,2160,4320,7120,11230
        };
        private readonly string[] itemtruck = new string[]
        {
            "500以下","501-600", "601-1200","1201-1800",
            "1801-2400","2401-3000 / 138HP以下(140.1PS以下)",
            "3001-3600","3601-4200 / 138.1-200HP(140.2-203.0PS)",
            "4201-4800","4801-5400 / 200.1-247HP(203.1-250.7PS)",
            "5401-6000","6001-6600 / 247.1-286HP(250.8-290.3PS)",
            "6601-7200","7201-7800 / 286.1-336HP(290.4-341.0PS)",
            "7801-8400","8401-9000 / 336.1-361HP(341.1-366.4PS)",
            "9001-9600","9601-10200 / 361.1HP以上(366.5PS以上)","10201以上"
        };
        private readonly int[] truckvalue = new int[]
        {
            900, 1080,1800,2700,3600,4500,5400,6300,7200,8100,9000,
            9900,10800,11700,12600,13500,14400,15300,16200 
        };
        private readonly string[] itembus = new string[]
        {
            "600以下","601-1200","1201-1800","1801-2400",
            "2401-3000 / 138HP以下(140.1PS以下)","3001-3600",
            "3601-4200 / 138.1-200HP(140.2-203.0PS)","4201-4800",
            "4801-5400 / 200.1-247HP(203.1-250.7PS)","5401-6000",
            "6001-6600 / 247.1-286HP(250.8-290.3PS)",
            "6601-7200","7201-7800 / 286.1-336HP(290.4-341.0PS)",
            "7801-8400","8401-9000 / 336.1-361HP(341.1-366.4PS)",
            "9001-9600","9601-10200 / 361.1HP以上(366.5PS以上)","10201以上"
        };
        private readonly int[] busvalue = new int[]
        {
            1080,1800,2700,3600,4500,5400,6300,7200,8100,
            9000,9900,10800,11700,12600,13500,14400,15300,16200
        };
        private readonly string[] itemprivatecar = new string[]
        {
           "500以下 / 38HP以下(38.6PS以下)","501~600 / 38.1-56HP(38.7-56.8PS)",
           "601~1200 / 56.1-83HP(56.9-84.2PS)","1201~1800 / 83.1-182HP(84.3-184.7PS)",
           "1801~2400 / 182.1-262HP(184.8-265.9PS)","2401~3000 / 262.1-322HP(266-326.8PS)",
           "3001-4200 / 322.1-414HP(326.9-420.2PS","4201-5400 / 414.1-469HP(420.3-476.0PS)",
           "5401-6600 / 469.1-509HP(476.1-516.6PS)",
            "6601-7800 / 509.1HP以上(516.7PS以上)","7801以上",
        };
        private readonly int[] privatecarvalue = new int[]
        {
            1620,2160,4320,7120,11230,15210,28220,46170,
            69690,117000,151200
        };
        private readonly string[] itembusinesscar = new string[]
        {
            "500以下 / 38HP以下(38.6PS以下)","501~600 / 38.1-56HP(38.7-56.8PS)",
            "601~1200 / 56.1-83HP(56.9-84.2PS)","1201~1800 / 83.1-182HP(84.3-184.7PS)",
            "1801~2400 / 182.1-262HP(184.8-265.9PS)","2401~3000 / 262.1-322HP(266-326.8PS)",
            "3001-4200 / 322.1-414HP(326.9-420.2PS)","4201-5400 / 414.1-469HP(420.3-476.0PS)",
            "5401-6600 / 469.1-509HP(476.1-516.6PS)",
            "6601-7800 / 509.1HP以上(516.7PS以上)","7801以上"
        };
        private readonly int[] businesscarvalue = new int[]
        {
            900,1260,2160,3060,6480,9900,16380,24300,
            33660,44460,56700
        };
        #endregion
        private void linkLabel1Content_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://law-out.mof.gov.tw/LawContent.aspx?id=FL006130");
        }
        //汽缸CC數／馬達馬力選單設定
        private void conbo2CC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = conbo2CC.SelectedIndex;
            if (b == -1)
            {
                btnconfirm.Enabled = false;
            }
            else if (b != -1)
            {
                btnconfirm.Enabled = true;
                lblhint.Visible = false;
            }
        }
        //設定結束日期的最小日為開始日期
        private void dateTimePicker1From_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2To.MinDate = dateTimePicker1From.Value;
        }
    }
}


namespace 使用牌照稅應納稅額試算
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblduration = new System.Windows.Forms.Label();
            this.lblpurpose = new System.Windows.Forms.Label();
            this.lblccCount = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.conbo2CC = new System.Windows.Forms.ComboBox();
            this.Conbo1purp = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2To = new System.Windows.Forms.DateTimePicker();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtBoxShowRes = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.linkLabel1Content = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdb1year = new System.Windows.Forms.RadioButton();
            this.rdb2interval = new System.Windows.Forms.RadioButton();
            this.lblintro = new System.Windows.Forms.Label();
            this.lblhint = new System.Windows.Forms.Label();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.lblenddate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblduration.Location = new System.Drawing.Point(29, 112);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(80, 18);
            this.lblduration.TabIndex = 0;
            this.lblduration.Text = "使用期間";
            // 
            // lblpurpose
            // 
            this.lblpurpose.AutoSize = true;
            this.lblpurpose.Location = new System.Drawing.Point(29, 152);
            this.lblpurpose.Name = "lblpurpose";
            this.lblpurpose.Size = new System.Drawing.Size(44, 18);
            this.lblpurpose.TabIndex = 1;
            this.lblpurpose.Text = "用途";
            // 
            // lblccCount
            // 
            this.lblccCount.AutoSize = true;
            this.lblccCount.Location = new System.Drawing.Point(29, 198);
            this.lblccCount.Name = "lblccCount";
            this.lblccCount.Size = new System.Drawing.Size(174, 18);
            this.lblccCount.TabIndex = 2;
            this.lblccCount.Text = "汽缸CC數／馬達馬力";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(29, 265);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(80, 18);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "試算結果";
            // 
            // conbo2CC
            // 
            this.conbo2CC.FormattingEnabled = true;
            this.conbo2CC.Location = new System.Drawing.Point(229, 192);
            this.conbo2CC.Name = "conbo2CC";
            this.conbo2CC.Size = new System.Drawing.Size(456, 26);
            this.conbo2CC.TabIndex = 5;
            this.conbo2CC.SelectedIndexChanged += new System.EventHandler(this.conbo2CC_SelectedIndexChanged);
            // 
            // Conbo1purp
            // 
            this.Conbo1purp.FormattingEnabled = true;
            this.Conbo1purp.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.Conbo1purp.Location = new System.Drawing.Point(229, 149);
            this.Conbo1purp.Name = "Conbo1purp";
            this.Conbo1purp.Size = new System.Drawing.Size(250, 26);
            this.Conbo1purp.TabIndex = 6;
            this.Conbo1purp.SelectedIndexChanged += new System.EventHandler(this.Conbo1purp_SelectedIndexChanged);
            // 
            // dateTimePicker1From
            // 
            this.dateTimePicker1From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1From.Location = new System.Drawing.Point(494, 105);
            this.dateTimePicker1From.Name = "dateTimePicker1From";
            this.dateTimePicker1From.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1From.TabIndex = 9;
            this.dateTimePicker1From.Visible = false;
            this.dateTimePicker1From.ValueChanged += new System.EventHandler(this.dateTimePicker1From_ValueChanged);
            // 
            // dateTimePicker2To
            // 
            this.dateTimePicker2To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2To.Location = new System.Drawing.Point(735, 105);
            this.dateTimePicker2To.Name = "dateTimePicker2To";
            this.dateTimePicker2To.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2To.TabIndex = 10;
            this.dateTimePicker2To.Visible = false;
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Location = new System.Drawing.Point(453, 109);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(26, 18);
            this.lblfrom.TabIndex = 13;
            this.lblfrom.Text = "從";
            this.lblfrom.Visible = false;
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Location = new System.Drawing.Point(702, 110);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(26, 18);
            this.lblto.TabIndex = 14;
            this.lblto.Text = "至";
            this.lblto.Visible = false;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(225, 434);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(104, 41);
            this.btnconfirm.TabIndex = 15;
            this.btnconfirm.Text = "確定送出";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(346, 434);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(104, 41);
            this.btnreset.TabIndex = 16;
            this.btnreset.Text = "取消重填";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtBoxShowRes
            // 
            this.txtBoxShowRes.Location = new System.Drawing.Point(229, 250);
            this.txtBoxShowRes.Multiline = true;
            this.txtBoxShowRes.Name = "txtBoxShowRes";
            this.txtBoxShowRes.ReadOnly = true;
            this.txtBoxShowRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxShowRes.Size = new System.Drawing.Size(478, 169);
            this.txtBoxShowRes.TabIndex = 17;
            this.txtBoxShowRes.Visible = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle.Location = new System.Drawing.Point(29, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(285, 24);
            this.lbltitle.TabIndex = 18;
            this.lbltitle.Text = "使用牌照稅應納稅額試算";
            // 
            // linkLabel1Content
            // 
            this.linkLabel1Content.AutoSize = true;
            this.linkLabel1Content.Location = new System.Drawing.Point(765, 445);
            this.linkLabel1Content.Name = "linkLabel1Content";
            this.linkLabel1Content.Size = new System.Drawing.Size(170, 18);
            this.linkLabel1Content.TabIndex = 19;
            this.linkLabel1Content.TabStop = true;
            this.linkLabel1Content.Text = "法規詳細內容請點我";
            this.linkLabel1Content.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1Content_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(467, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 41);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "離開系統";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdb1year
            // 
            this.rdb1year.AutoSize = true;
            this.rdb1year.Location = new System.Drawing.Point(225, 109);
            this.rdb1year.Name = "rdb1year";
            this.rdb1year.Size = new System.Drawing.Size(87, 22);
            this.rdb1year.TabIndex = 7;
            this.rdb1year.TabStop = true;
            this.rdb1year.Text = "全年度";
            this.rdb1year.UseVisualStyleBackColor = true;
            this.rdb1year.Click += new System.EventHandler(this.rdb1year_Click);
            // 
            // rdb2interval
            // 
            this.rdb2interval.AutoSize = true;
            this.rdb2interval.Location = new System.Drawing.Point(346, 108);
            this.rdb2interval.Name = "rdb2interval";
            this.rdb2interval.Size = new System.Drawing.Size(87, 22);
            this.rdb2interval.TabIndex = 8;
            this.rdb2interval.TabStop = true;
            this.rdb2interval.Text = "依區間";
            this.rdb2interval.UseVisualStyleBackColor = true;
            this.rdb2interval.Click += new System.EventHandler(this.rdb2interval_Click);
            // 
            // lblintro
            // 
            this.lblintro.AutoSize = true;
            this.lblintro.Location = new System.Drawing.Point(30, 44);
            this.lblintro.Name = "lblintro";
            this.lblintro.Size = new System.Drawing.Size(44, 18);
            this.lblintro.TabIndex = 22;
            this.lblintro.Text = "備註";
            this.lblintro.Visible = false;
            // 
            // lblhint
            // 
            this.lblhint.AutoSize = true;
            this.lblhint.Location = new System.Drawing.Point(492, 152);
            this.lblhint.Name = "lblhint";
            this.lblhint.Size = new System.Drawing.Size(80, 18);
            this.lblhint.TabIndex = 23;
            this.lblhint.Text = "提示訊息";
            this.lblhint.Visible = false;
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Location = new System.Drawing.Point(492, 73);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(134, 18);
            this.lblstartdate.TabIndex = 24;
            this.lblstartdate.Text = "請輸入開始日期";
            this.lblstartdate.Visible = false;
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Location = new System.Drawing.Point(732, 73);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(134, 18);
            this.lblenddate.TabIndex = 25;
            this.lblenddate.Text = "請輸入結束日期";
            this.lblenddate.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 491);
            this.Controls.Add(this.txtBoxShowRes);
            this.Controls.Add(this.lblenddate);
            this.Controls.Add(this.lblstartdate);
            this.Controls.Add(this.lblhint);
            this.Controls.Add(this.lblintro);
            this.Controls.Add(this.rdb2interval);
            this.Controls.Add(this.rdb1year);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.linkLabel1Content);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.dateTimePicker2To);
            this.Controls.Add(this.dateTimePicker1From);
            this.Controls.Add(this.Conbo1purp);
            this.Controls.Add(this.conbo2CC);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblccCount);
            this.Controls.Add(this.lblpurpose);
            this.Controls.Add(this.lblduration);
            this.Name = "Form1";
            this.Text = "VehicleLicenseTaxForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblpurpose;
        private System.Windows.Forms.Label lblccCount;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.ComboBox conbo2CC;
        private System.Windows.Forms.ComboBox Conbo1purp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1From;
        private System.Windows.Forms.DateTimePicker dateTimePicker2To;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtBoxShowRes;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.LinkLabel linkLabel1Content;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdb1year;
        private System.Windows.Forms.RadioButton rdb2interval;
        private System.Windows.Forms.Label lblintro;
        private System.Windows.Forms.Label lblhint;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.Label lblenddate;
    }
}


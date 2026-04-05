namespace MortgagePaymentCalculator
{
    partial class MortgagePayment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltotalinterest = new System.Windows.Forms.Label();
            this.lfirstloan = new System.Windows.Forms.Label();
            this.ltotalloan = new System.Windows.Forms.Label();
            this.lfirstinterest = new System.Windows.Forms.Label();
            this.totalinterest = new System.Windows.Forms.Label();
            this.ltotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.firstinterest = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstloan = new System.Windows.Forms.Label();
            this.totalloan = new System.Windows.Forms.Label();
            this.totalhouse = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.rateyear = new System.Windows.Forms.Label();
            this.downpayment = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.Label();
            this.ttotalhouse = new System.Windows.Forms.TextBox();
            this.trateyear = new System.Windows.Forms.TextBox();
            this.tdownpayment = new System.Windows.Forms.TextBox();
            this.tyear = new System.Windows.Forms.TextBox();
            this.cperiod = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbAvgPrincipalInterest = new System.Windows.Forms.RadioButton();
            this.rdbAvgPrincipal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDownPaymentHint = new System.Windows.Forms.Label();
            this.lblPeriodHint = new System.Windows.Forms.Label();
            this.lblRateHint = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalloan);
            this.panel1.Controls.Add(this.firstloan);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.firstinterest);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.ltotal);
            this.panel1.Controls.Add(this.totalinterest);
            this.panel1.Controls.Add(this.lfirstinterest);
            this.panel1.Controls.Add(this.ltotalloan);
            this.panel1.Controls.Add(this.lfirstloan);
            this.panel1.Controls.Add(this.ltotalinterest);
            this.panel1.Location = new System.Drawing.Point(453, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 444);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ltotalinterest
            // 
            this.ltotalinterest.AutoSize = true;
            this.ltotalinterest.Font = new System.Drawing.Font("Noto Sans HK Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltotalinterest.Location = new System.Drawing.Point(146, 204);
            this.ltotalinterest.Name = "ltotalinterest";
            this.ltotalinterest.Size = new System.Drawing.Size(0, 32);
            this.ltotalinterest.TabIndex = 18;
            // 
            // lfirstloan
            // 
            this.lfirstloan.AutoSize = true;
            this.lfirstloan.Font = new System.Drawing.Font("Noto Sans HK Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lfirstloan.Location = new System.Drawing.Point(145, 136);
            this.lfirstloan.Name = "lfirstloan";
            this.lfirstloan.Size = new System.Drawing.Size(0, 32);
            this.lfirstloan.TabIndex = 19;
            // 
            // ltotalloan
            // 
            this.ltotalloan.AutoSize = true;
            this.ltotalloan.Font = new System.Drawing.Font("Noto Sans TC Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotalloan.Location = new System.Drawing.Point(180, 22);
            this.ltotalloan.Name = "ltotalloan";
            this.ltotalloan.Size = new System.Drawing.Size(0, 32);
            this.ltotalloan.TabIndex = 17;
            // 
            // lfirstinterest
            // 
            this.lfirstinterest.AutoSize = true;
            this.lfirstinterest.Font = new System.Drawing.Font("Noto Sans HK Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lfirstinterest.Location = new System.Drawing.Point(145, 74);
            this.lfirstinterest.Name = "lfirstinterest";
            this.lfirstinterest.Size = new System.Drawing.Size(0, 32);
            this.lfirstinterest.TabIndex = 20;
            // 
            // totalinterest
            // 
            this.totalinterest.AutoSize = true;
            this.totalinterest.Location = new System.Drawing.Point(18, 204);
            this.totalinterest.Name = "totalinterest";
            this.totalinterest.Size = new System.Drawing.Size(122, 28);
            this.totalinterest.TabIndex = 16;
            this.totalinterest.Text = "總利息支出";
            // 
            // ltotal
            // 
            this.ltotal.AutoSize = true;
            this.ltotal.Font = new System.Drawing.Font("Noto Sans HK Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltotal.Location = new System.Drawing.Point(155, 263);
            this.ltotal.Name = "ltotal";
            this.ltotal.Size = new System.Drawing.Size(0, 32);
            this.ltotal.TabIndex = 22;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(18, 263);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(122, 28);
            this.total.TabIndex = 15;
            this.total.Text = "總還款金額";
            // 
            // firstinterest
            // 
            this.firstinterest.AutoSize = true;
            this.firstinterest.Location = new System.Drawing.Point(18, 74);
            this.firstinterest.Name = "firstinterest";
            this.firstinterest.Size = new System.Drawing.Size(100, 28);
            this.firstinterest.TabIndex = 12;
            this.firstinterest.Text = "首期利息";
            this.firstinterest.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(393, 393);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // firstloan
            // 
            this.firstloan.AutoSize = true;
            this.firstloan.Location = new System.Drawing.Point(18, 136);
            this.firstloan.Name = "firstloan";
            this.firstloan.Size = new System.Drawing.Size(100, 28);
            this.firstloan.TabIndex = 11;
            this.firstloan.Text = "首期本金";
            // 
            // totalloan
            // 
            this.totalloan.AutoSize = true;
            this.totalloan.Location = new System.Drawing.Point(18, 22);
            this.totalloan.Name = "totalloan";
            this.totalloan.Size = new System.Drawing.Size(122, 28);
            this.totalloan.TabIndex = 14;
            this.totalloan.Text = "貸款總金額";
            // 
            // totalhouse
            // 
            this.totalhouse.AutoSize = true;
            this.totalhouse.Location = new System.Drawing.Point(21, 56);
            this.totalhouse.Name = "totalhouse";
            this.totalhouse.Size = new System.Drawing.Size(100, 28);
            this.totalhouse.TabIndex = 0;
            this.totalhouse.Text = "房屋總價";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(21, 279);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 28);
            this.year.TabIndex = 1;
            this.year.Text = "貸款年限";
            // 
            // rateyear
            // 
            this.rateyear.AutoSize = true;
            this.rateyear.Location = new System.Drawing.Point(21, 201);
            this.rateyear.Name = "rateyear";
            this.rateyear.Size = new System.Drawing.Size(100, 28);
            this.rateyear.TabIndex = 2;
            this.rateyear.Text = "貸款利率";
            // 
            // downpayment
            // 
            this.downpayment.AutoSize = true;
            this.downpayment.Location = new System.Drawing.Point(21, 131);
            this.downpayment.Name = "downpayment";
            this.downpayment.Size = new System.Drawing.Size(122, 28);
            this.downpayment.TabIndex = 3;
            this.downpayment.Text = "自備款比例";
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Location = new System.Drawing.Point(21, 355);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(78, 28);
            this.period.TabIndex = 4;
            this.period.Text = "寬限期";
            // 
            // ttotalhouse
            // 
            this.ttotalhouse.BackColor = System.Drawing.SystemColors.Window;
            this.ttotalhouse.Location = new System.Drawing.Point(174, 53);
            this.ttotalhouse.Name = "ttotalhouse";
            this.ttotalhouse.Size = new System.Drawing.Size(152, 37);
            this.ttotalhouse.TabIndex = 5;
            this.ttotalhouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trateyear
            // 
            this.trateyear.BackColor = System.Drawing.SystemColors.Window;
            this.trateyear.Location = new System.Drawing.Point(174, 198);
            this.trateyear.Name = "trateyear";
            this.trateyear.Size = new System.Drawing.Size(152, 37);
            this.trateyear.TabIndex = 6;
            this.trateyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tdownpayment
            // 
            this.tdownpayment.BackColor = System.Drawing.SystemColors.Window;
            this.tdownpayment.Location = new System.Drawing.Point(174, 128);
            this.tdownpayment.Name = "tdownpayment";
            this.tdownpayment.Size = new System.Drawing.Size(152, 37);
            this.tdownpayment.TabIndex = 7;
            this.tdownpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tyear
            // 
            this.tyear.BackColor = System.Drawing.SystemColors.Window;
            this.tyear.Location = new System.Drawing.Point(174, 279);
            this.tyear.Name = "tyear";
            this.tyear.Size = new System.Drawing.Size(152, 37);
            this.tyear.TabIndex = 8;
            this.tyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cperiod
            // 
            this.cperiod.FormattingEnabled = true;
            this.cperiod.Items.AddRange(new object[] {
            "0年",
            "1年",
            "2年",
            "3年",
            "4年",
            "5年",
            "6年",
            "7年",
            "8年",
            "9年",
            "10年",
            "11年",
            "12年",
            "13年",
            "14年",
            "15年",
            "16年",
            "17年",
            "18年",
            "19年",
            "20年",
            "21年",
            "22年",
            "23年",
            "24年"});
            this.cperiod.Location = new System.Drawing.Point(176, 352);
            this.cperiod.Name = "cperiod";
            this.cperiod.Size = new System.Drawing.Size(149, 36);
            this.cperiod.TabIndex = 9;
            this.cperiod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCalculate.Location = new System.Drawing.Point(59, 474);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(201, 44);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "計算";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "%";
            // 
            // rdbAvgPrincipalInterest
            // 
            this.rdbAvgPrincipalInterest.AutoSize = true;
            this.rdbAvgPrincipalInterest.Checked = true;
            this.rdbAvgPrincipalInterest.Location = new System.Drawing.Point(26, 424);
            this.rdbAvgPrincipalInterest.Name = "rdbAvgPrincipalInterest";
            this.rdbAvgPrincipalInterest.Size = new System.Drawing.Size(191, 32);
            this.rdbAvgPrincipalInterest.TabIndex = 25;
            this.rdbAvgPrincipalInterest.TabStop = true;
            this.rdbAvgPrincipalInterest.Text = "本息平均攤還法";
            this.rdbAvgPrincipalInterest.UseVisualStyleBackColor = true;
            // 
            // rdbAvgPrincipal
            // 
            this.rdbAvgPrincipal.AutoSize = true;
            this.rdbAvgPrincipal.Location = new System.Drawing.Point(227, 424);
            this.rdbAvgPrincipal.Name = "rdbAvgPrincipal";
            this.rdbAvgPrincipal.Size = new System.Drawing.Size(191, 32);
            this.rdbAvgPrincipal.TabIndex = 26;
            this.rdbAvgPrincipal.Text = "本金平均攤還法";
            this.rdbAvgPrincipal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRateHint);
            this.groupBox1.Controls.Add(this.lblPeriodHint);
            this.groupBox1.Controls.Add(this.lblDownPaymentHint);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbAvgPrincipal);
            this.groupBox1.Controls.Add(this.rdbAvgPrincipalInterest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCalculate);
            this.groupBox1.Controls.Add(this.cperiod);
            this.groupBox1.Controls.Add(this.tyear);
            this.groupBox1.Controls.Add(this.tdownpayment);
            this.groupBox1.Controls.Add(this.trateyear);
            this.groupBox1.Controls.Add(this.ttotalhouse);
            this.groupBox1.Controls.Add(this.period);
            this.groupBox1.Controls.Add(this.downpayment);
            this.groupBox1.Controls.Add(this.rateyear);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.totalhouse);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(16, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 583);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "年";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "新台幣";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "%";
            // 
            // lblDownPaymentHint
            // 
            this.lblDownPaymentHint.AutoSize = true;
            this.lblDownPaymentHint.Location = new System.Drawing.Point(171, 167);
            this.lblDownPaymentHint.Name = "lblDownPaymentHint";
            this.lblDownPaymentHint.Size = new System.Drawing.Size(0, 28);
            this.lblDownPaymentHint.TabIndex = 31;
            this.lblDownPaymentHint.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPeriodHint
            // 
            this.lblPeriodHint.AutoSize = true;
            this.lblPeriodHint.Location = new System.Drawing.Point(171, 319);
            this.lblPeriodHint.Name = "lblPeriodHint";
            this.lblPeriodHint.Size = new System.Drawing.Size(0, 28);
            this.lblPeriodHint.TabIndex = 32;
            // 
            // lblRateHint
            // 
            this.lblRateHint.AutoSize = true;
            this.lblRateHint.Location = new System.Drawing.Point(171, 239);
            this.lblRateHint.Name = "lblRateHint";
            this.lblRateHint.Size = new System.Drawing.Size(0, 28);
            this.lblRateHint.TabIndex = 33;
            // 
            // MortgagePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 696);
            this.Controls.Add(this.groupBox1);
            this.Name = "MortgagePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸計算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalloan;
        private System.Windows.Forms.Label firstloan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label firstinterest;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label ltotal;
        private System.Windows.Forms.Label totalinterest;
        private System.Windows.Forms.Label lfirstinterest;
        private System.Windows.Forms.Label ltotalloan;
        private System.Windows.Forms.Label lfirstloan;
        private System.Windows.Forms.Label ltotalinterest;
        private System.Windows.Forms.Label totalhouse;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label rateyear;
        private System.Windows.Forms.Label downpayment;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.TextBox ttotalhouse;
        private System.Windows.Forms.TextBox trateyear;
        private System.Windows.Forms.TextBox tdownpayment;
        private System.Windows.Forms.TextBox tyear;
        private System.Windows.Forms.ComboBox cperiod;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbAvgPrincipalInterest;
        private System.Windows.Forms.RadioButton rdbAvgPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDownPaymentHint;
        private System.Windows.Forms.Label lblRateHint;
        private System.Windows.Forms.Label lblPeriodHint;
    }
}


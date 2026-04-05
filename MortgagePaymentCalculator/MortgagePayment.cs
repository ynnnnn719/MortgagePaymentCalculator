using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MortgagePaymentCalculator
{
    public partial class MortgagePayment : Form
    {
        public MortgagePayment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 整體背景
            this.BackColor = Color.FromArgb(240, 248, 255);


            // DataGridView
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.GridColor = ColorTranslator.FromHtml("#E5EAF3");
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#EEF4FF");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#1F2937");
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#1F2937");
            dataGridView1.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#DCE8FF");
            dataGridView1.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#1F2937");
            dataGridView1.RowHeadersVisible = false;

            // 按鈕
            buttonCalculate.BackColor = Color.FromArgb(205, 92, 92);
            buttonCalculate.ForeColor = Color.White;
            buttonCalculate.FlatStyle = FlatStyle.Flat;
            buttonCalculate.FlatAppearance.BorderSize = 0;
            buttonCalculate.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);



            // 結果數字
            ltotalloan.ForeColor = Color.FromArgb(0,0,128);
            lfirstinterest.ForeColor = Color.FromArgb(0, 0, 128);
            lfirstloan.ForeColor = Color.FromArgb(0, 0, 128);
            ltotalinterest.ForeColor = Color.FromArgb(0, 0, 128);
            ltotal.ForeColor = Color.FromArgb(0, 0, 128);




            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Month", "期數");
            dataGridView1.Columns.Add("MonthPayment", "每月應繳金額（本＋息）");

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = Color.White;

            // 預設選本息平均攤還法
            rdbAvgPrincipalInterest.Checked = true;
            panel1.Visible = false;
            this.AcceptButton = buttonCalculate;

            // 提示 Label 樣式
            lblDownPaymentHint.ForeColor = Color.Red;
            lblDownPaymentHint.Font = new Font("Microsoft JhengHei UI", 8F);
            lblDownPaymentHint.Text = "";

            lblRateHint.ForeColor = Color.Red;
            lblRateHint.Font = new Font("Microsoft JhengHei UI", 8F);
            lblRateHint.Text = "";

            lblPeriodHint.ForeColor = Color.Red;
            lblPeriodHint.Font = new Font("Microsoft JhengHei UI", 8F);
            lblPeriodHint.Text = "";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs()
        {
            bool isValid = true;

            // 清空提示
            lblDownPaymentHint.Text = "";
            lblRateHint.Text = "";
            lblPeriodHint.Text = "";

            // ===== 自備款比例檢查 =====
            if (!string.IsNullOrWhiteSpace(tdownpayment.Text))
            {
                if (double.TryParse(tdownpayment.Text.Trim(), out double downpaymentValue))
                {
                    if (downpaymentValue > 100)
                    {
                        lblDownPaymentHint.Text = "自備款比例不可大於 100%";
                        isValid = false;
                    }
                    else if (downpaymentValue < 0)
                    {
                        lblDownPaymentHint.Text = "自備款比例不可小於 0%";
                        isValid = false;
                    }
                }
                else
                {
                    lblDownPaymentHint.Text = "請輸入正確數字";
                    isValid = false;
                }
            }

            // ===== 年利率檢查 =====
            if (!string.IsNullOrWhiteSpace(trateyear.Text))
            {
                if (double.TryParse(trateyear.Text.Trim(), out double rateValue))
                {
                    if (rateValue > 100)
                    {
                        lblRateHint.Text = "年利率不可大於 100%";
                        isValid = false;
                    }
                    else if (rateValue < 0)
                    {
                        lblRateHint.Text = "年利率不可小於 0%";
                        isValid = false;
                    }
                }
                else
                {
                    lblRateHint.Text = "請輸入正確數字";
                    isValid = false;
                }
            }

            // ===== 貸款年限 / 寬限期檢查 =====
            int yearValue = 0;
            int periodValue = 0;

            bool yearOk = int.TryParse(tyear.Text.Trim(), out yearValue);

            string periodText = cperiod.Text.Trim();
            periodText = periodText.Replace("年", "")
                                   .Replace("（無寬限期）", "")
                                   .Trim();

            bool periodOk = true;
            if (!string.IsNullOrEmpty(periodText))
            {
                periodOk = int.TryParse(periodText, out periodValue);
            }

            if (!string.IsNullOrWhiteSpace(tyear.Text) && !yearOk)
            {
                lblPeriodHint.Text = "貸款年限格式錯誤";
                isValid = false;
            }
            else if (!periodOk)
            {
                lblPeriodHint.Text = "寬限期格式錯誤";
                isValid = false;
            }
            else if (yearOk && periodOk && periodValue > yearValue)
            {
                lblPeriodHint.Text = "寬限期不可大於貸款年限";
                isValid = false;
            }

            return isValid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                // ===== 使用者輸入 =====
                double totalhouse = double.Parse(ttotalhouse.Text.Trim());
                double downpayment = double.Parse(tdownpayment.Text.Trim()) / 100.0;
                double rateyear = double.Parse(trateyear.Text.Trim()) / 100.0;
                int year = int.Parse(tyear.Text.Trim());

                string text = cperiod.Text.Trim();
                text = text.Replace("年", "")
                           .Replace("（無寬限期）", "")
                           .Trim();
                int period = string.IsNullOrEmpty(text) ? 0 : int.Parse(text);

                // ===== 前置計算 =====
                double totalloan = totalhouse * (1 - downpayment);
                double ratemonth = rateyear / 12.0;
                int month = year * 12;
                int gracemonth = period * 12;
                int remainterm = month - gracemonth;

                double Mg = 0;
                double Mr = 0;
                double monthpayment = 0;
                double firstinterest = 0;
                double firstloan = 0;
                double total = 0;
                double totalinterest = 0;

                if (remainterm <= 0)
                {
                    lblPeriodHint.Text = "寬限期不可大於或等於貸款年限";
                    return;
                }

                dataGridView1.Rows.Clear();

                if (ratemonth == 0)
                {
                    double principalPerMonth = totalloan / remainterm;

                    if (period > 0)
                    {
                        Mg = 0;
                        monthpayment = Mg;
                        firstinterest = 0;
                        firstloan = 0;

                        for (int i = 1; i <= gracemonth; i++)
                        {
                            dataGridView1.Rows.Add(i, Mg.ToString("N2"));
                        }

                        for (int i = gracemonth + 1; i <= month; i++)
                        {
                            dataGridView1.Rows.Add(i, principalPerMonth.ToString("N2"));
                            total += principalPerMonth;
                        }
                    }
                    else
                    {
                        monthpayment = principalPerMonth;
                        firstinterest = 0;
                        firstloan = principalPerMonth;

                        for (int i = 1; i <= month; i++)
                        {
                            dataGridView1.Rows.Add(i, principalPerMonth.ToString("N2"));
                            total += principalPerMonth;
                        }
                    }

                    totalinterest = total - totalloan;
                }
                else
                {
                    Mg = totalloan * ratemonth;

                    if (rdbAvgPrincipalInterest.Checked)
                    {
                        Mr = totalloan * ratemonth * Math.Pow(1 + ratemonth, remainterm)
                           / (Math.Pow(1 + ratemonth, remainterm) - 1);

                        if (period > 0)
                        {
                            monthpayment = Mg;
                            firstinterest = totalloan * ratemonth;
                            firstloan = 0;
                            total = (Mg * gracemonth) + (Mr * remainterm);
                        }
                        else
                        {
                            monthpayment = Mr;
                            firstinterest = totalloan * ratemonth;
                            firstloan = Mr - firstinterest;
                            total = Mr * month;
                        }

                        totalinterest = total - totalloan;

                        for (int i = 1; i <= month; i++)
                        {
                            double payment = (i <= gracemonth) ? Mg : Mr;
                            dataGridView1.Rows.Add(i, payment.ToString("N2"));
                        }
                    }
                    else if (rdbAvgPrincipal.Checked)
                    {
                        double balance = totalloan;
                        double principalPerMonth = totalloan / remainterm;
                        total = 0;

                        if (period > 0)
                        {
                            monthpayment = Mg;
                            firstinterest = totalloan * ratemonth;
                            firstloan = 0;

                            for (int i = 1; i <= gracemonth; i++)
                            {
                                dataGridView1.Rows.Add(i, Mg.ToString("N2"));
                                total += Mg;
                            }

                            for (int i = gracemonth + 1; i <= month; i++)
                            {
                                double interest = balance * ratemonth;
                                double payment = principalPerMonth + interest;

                                dataGridView1.Rows.Add(i, payment.ToString("N2"));
                                total += payment;
                                balance -= principalPerMonth;
                            }
                        }
                        else
                        {
                            firstinterest = balance * ratemonth;
                            firstloan = principalPerMonth;
                            monthpayment = firstloan + firstinterest;

                            for (int i = 1; i <= month; i++)
                            {
                                double interest = balance * ratemonth;
                                double payment = principalPerMonth + interest;

                                dataGridView1.Rows.Add(i, payment.ToString("N2"));
                                total += payment;
                                balance -= principalPerMonth;
                            }
                        }

                        totalinterest = total - totalloan;
                    }
                }

                // ===== 顯示結果 =====
                ltotalloan.Text = totalloan.ToString("N2");
        
                lfirstinterest.Text = firstinterest.ToString("N2");
                lfirstloan.Text = firstloan.ToString("N2");
                ltotalinterest.Text = totalinterest.ToString("N2");
                ltotal.Text = total.ToString("N2");

                panel1.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("請確認所有欄位都已輸入正確數字。", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}


namespace TipCalculatorr
{
    partial class TipCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipCalculator));
            this.lblBill = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.btnTipMinus = new System.Windows.Forms.Button();
            this.btnTipPlus = new System.Windows.Forms.Button();
            this.btnNumberPlus = new System.Windows.Forms.Button();
            this.btnNumberMinus = new System.Windows.Forms.Button();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.rightLbl1 = new System.Windows.Forms.Label();
            this.rightLbl2 = new System.Windows.Forms.Label();
            this.rightlbl4 = new System.Windows.Forms.Label();
            this.rightLbl3 = new System.Windows.Forms.Label();
            this.txtTipPerPerson = new System.Windows.Forms.TextBox();
            this.txtTotalPerPerson = new System.Windows.Forms.TextBox();
            this.line = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBill.Location = new System.Drawing.Point(25, 56);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(33, 20);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "Bill";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTip.Location = new System.Drawing.Point(25, 136);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(50, 20);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Tip %";
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPeople.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumberOfPeople.Location = new System.Drawing.Point(25, 218);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(174, 20);
            this.lblNumberOfPeople.TabIndex = 3;
            this.lblNumberOfPeople.Text = "Number Of People";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(28, 80);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(236, 35);
            this.txtBill.TabIndex = 4;
            this.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBill_KeyPress);
            // 
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTip.Location = new System.Drawing.Point(73, 160);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(146, 34);
            this.txtTip.TabIndex = 5;
            this.txtTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            this.txtTip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTip_KeyPress);
            // 
            // btnTipMinus
            // 
            this.btnTipMinus.BackColor = System.Drawing.Color.LightGray;
            this.btnTipMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipMinus.Location = new System.Drawing.Point(28, 160);
            this.btnTipMinus.Name = "btnTipMinus";
            this.btnTipMinus.Size = new System.Drawing.Size(47, 34);
            this.btnTipMinus.TabIndex = 7;
            this.btnTipMinus.Text = "-";
            this.btnTipMinus.UseVisualStyleBackColor = false;
            this.btnTipMinus.Click += new System.EventHandler(this.btnTipMinus_Click);
            // 
            // btnTipPlus
            // 
            this.btnTipPlus.BackColor = System.Drawing.Color.LightGray;
            this.btnTipPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipPlus.Location = new System.Drawing.Point(217, 161);
            this.btnTipPlus.Name = "btnTipPlus";
            this.btnTipPlus.Size = new System.Drawing.Size(47, 34);
            this.btnTipPlus.TabIndex = 8;
            this.btnTipPlus.Text = "+";
            this.btnTipPlus.UseVisualStyleBackColor = false;
            this.btnTipPlus.Click += new System.EventHandler(this.btnTipPlus_Click);
            // 
            // btnNumberPlus
            // 
            this.btnNumberPlus.BackColor = System.Drawing.Color.LightGray;
            this.btnNumberPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberPlus.Location = new System.Drawing.Point(218, 242);
            this.btnNumberPlus.Name = "btnNumberPlus";
            this.btnNumberPlus.Size = new System.Drawing.Size(47, 34);
            this.btnNumberPlus.TabIndex = 11;
            this.btnNumberPlus.Text = "+";
            this.btnNumberPlus.UseVisualStyleBackColor = false;
            this.btnNumberPlus.Click += new System.EventHandler(this.btnNumberPlus_Click);
            // 
            // btnNumberMinus
            // 
            this.btnNumberMinus.BackColor = System.Drawing.Color.LightGray;
            this.btnNumberMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberMinus.Location = new System.Drawing.Point(29, 241);
            this.btnNumberMinus.Name = "btnNumberMinus";
            this.btnNumberMinus.Size = new System.Drawing.Size(47, 34);
            this.btnNumberMinus.TabIndex = 10;
            this.btnNumberMinus.Text = "-";
            this.btnNumberMinus.UseVisualStyleBackColor = false;
            this.btnNumberMinus.Click += new System.EventHandler(this.btnNumberMinus_Click);
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfPeople.Location = new System.Drawing.Point(73, 241);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(146, 34);
            this.txtNumberOfPeople.TabIndex = 9;
            this.txtNumberOfPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumberOfPeople.TextChanged += new System.EventHandler(this.txtNumberOfPeople_TextChanged);
            this.txtNumberOfPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfPeople_KeyPress);
            // 
            // rightLbl1
            // 
            this.rightLbl1.AutoSize = true;
            this.rightLbl1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLbl1.ForeColor = System.Drawing.Color.Black;
            this.rightLbl1.Location = new System.Drawing.Point(346, 100);
            this.rightLbl1.Name = "rightLbl1";
            this.rightLbl1.Size = new System.Drawing.Size(40, 23);
            this.rightLbl1.TabIndex = 12;
            this.rightLbl1.Text = "Tip";
            // 
            // rightLbl2
            // 
            this.rightLbl2.AutoSize = true;
            this.rightLbl2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLbl2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightLbl2.Location = new System.Drawing.Point(347, 125);
            this.rightLbl2.Name = "rightLbl2";
            this.rightLbl2.Size = new System.Drawing.Size(75, 19);
            this.rightLbl2.TabIndex = 13;
            this.rightLbl2.Text = "per person";
            // 
            // rightlbl4
            // 
            this.rightlbl4.AutoSize = true;
            this.rightlbl4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightlbl4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightlbl4.Location = new System.Drawing.Point(346, 205);
            this.rightlbl4.Name = "rightlbl4";
            this.rightlbl4.Size = new System.Drawing.Size(75, 19);
            this.rightlbl4.TabIndex = 15;
            this.rightlbl4.Text = "per person";
            // 
            // rightLbl3
            // 
            this.rightLbl3.AutoSize = true;
            this.rightLbl3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLbl3.ForeColor = System.Drawing.Color.Black;
            this.rightLbl3.Location = new System.Drawing.Point(346, 180);
            this.rightLbl3.Name = "rightLbl3";
            this.rightLbl3.Size = new System.Drawing.Size(58, 23);
            this.rightLbl3.TabIndex = 14;
            this.rightLbl3.Text = "Total";
            // 
            // txtTipPerPerson
            // 
            this.txtTipPerPerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTipPerPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipPerPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipPerPerson.Location = new System.Drawing.Point(441, 103);
            this.txtTipPerPerson.Name = "txtTipPerPerson";
            this.txtTipPerPerson.ReadOnly = true;
            this.txtTipPerPerson.Size = new System.Drawing.Size(212, 31);
            this.txtTipPerPerson.TabIndex = 16;
            this.txtTipPerPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPerPerson
            // 
            this.txtTotalPerPerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalPerPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPerPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPerPerson.Location = new System.Drawing.Point(441, 192);
            this.txtTotalPerPerson.Name = "txtTotalPerPerson";
            this.txtTotalPerPerson.ReadOnly = true;
            this.txtTotalPerPerson.Size = new System.Drawing.Size(212, 37);
            this.txtTotalPerPerson.TabIndex = 17;
            this.txtTotalPerPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Gainsboro;
            this.line.Location = new System.Drawing.Point(321, 0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(2, 310);
            this.line.TabIndex = 18;
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 308);
            this.Controls.Add(this.line);
            this.Controls.Add(this.txtTotalPerPerson);
            this.Controls.Add(this.txtTipPerPerson);
            this.Controls.Add(this.rightlbl4);
            this.Controls.Add(this.rightLbl3);
            this.Controls.Add(this.rightLbl2);
            this.Controls.Add(this.rightLbl1);
            this.Controls.Add(this.btnNumberPlus);
            this.Controls.Add(this.btnNumberMinus);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.btnTipPlus);
            this.Controls.Add(this.btnTipMinus);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblNumberOfPeople);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TipCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Calculator";
            this.Click += new System.EventHandler(this.TipPerperson_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnTipMinus;
        private System.Windows.Forms.Button btnTipPlus;
        private System.Windows.Forms.Button btnNumberPlus;
        private System.Windows.Forms.Button btnNumberMinus;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.Label rightLbl1;
        private System.Windows.Forms.Label rightLbl2;
        private System.Windows.Forms.Label rightlbl4;
        private System.Windows.Forms.Label rightLbl3;
        private System.Windows.Forms.TextBox txtTipPerPerson;
        private System.Windows.Forms.TextBox txtTotalPerPerson;
        private System.Windows.Forms.Label line;
    }
}


namespace BankAccount
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lstActionHistory = new System.Windows.Forms.ListBox();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(30, 54);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(224, 22);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank account number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.Location = new System.Drawing.Point(30, 115);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(224, 22);
            this.txtInitialBalance.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(411, 44);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(236, 22);
            this.txtAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(408, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sum:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opening balance:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateAccount.Location = new System.Drawing.Point(30, 156);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(224, 52);
            this.btnCreateAccount.TabIndex = 7;
            this.btnCreateAccount.Text = "Create an account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.LightGray;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeposit.Location = new System.Drawing.Point(411, 78);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(236, 34);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Top up the account";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.LightGray;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWithdraw.Location = new System.Drawing.Point(412, 118);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(235, 30);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Withdraw funds";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowInfo.Location = new System.Drawing.Point(411, 166);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(246, 42);
            this.btnShowInfo.TabIndex = 10;
            this.btnShowInfo.Text = "Show information";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lstActionHistory
            // 
            this.lstActionHistory.FormattingEnabled = true;
            this.lstActionHistory.ItemHeight = 16;
            this.lstActionHistory.Location = new System.Drawing.Point(30, 344);
            this.lstActionHistory.Name = "lstActionHistory";
            this.lstActionHistory.Size = new System.Drawing.Size(727, 164);
            this.lstActionHistory.TabIndex = 12;
            this.lstActionHistory.SelectedIndexChanged += new System.EventHandler(this.lstActionHistory_SelectedIndexChanged);
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccountInfo.Location = new System.Drawing.Point(27, 242);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(47, 16);
            this.lblAccountInfo.TabIndex = 13;
            this.lblAccountInfo.Text = "Status:";
            this.lblAccountInfo.Click += new System.EventHandler(this.lblAccountInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Action archive ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAccountInfo);
            this.Controls.Add(this.lstActionHistory);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtInitialBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Банк";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.ListBox lstActionHistory;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Label label4;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class Form1 : Form
    {
      
        private BankAccount account;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;
            if (double.TryParse(txtInitialBalance.Text, out double initialBalance))
            {
                account = new BankAccount(accountNumber, initialBalance);
                lblAccountInfo.Text = "Account successfully created!";
                UpdateActionHistory();
            }
            else
            {
                lblAccountInfo.Text = "Error: please enter a valid opening balance";
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                if (double.TryParse(txtAmount.Text, out double amount))
                {
                    try
                    {
                        account.Deposit(amount);
                        lblAccountInfo.Text = $"Your account was topped up by {amount} UAH.";
                        UpdateActionHistory();
                    }
                    catch (ArgumentException ex)
                    {
                        lblAccountInfo.Text = ex.Message;
                    }
                }
                else
                {
                    lblAccountInfo.Text = "Error: enter a valid amount";
                }
            }
            else
            {
                lblAccountInfo.Text = "Create an account first";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                if (double.TryParse(txtAmount.Text, out double amount))
                {
                    try
                    {
                        account.Withdraw(amount);
                        lblAccountInfo.Text = $"UAH {amount} was withdraw from your account";
                        UpdateActionHistory();
                    }
                    catch (InvalidOperationException ex)
                    {
                        lblAccountInfo.Text = ex.Message;
                    }
                }
                else
                {
                    lblAccountInfo.Text = "Error: please enter a valid amount";
                }
            }
            else
            {
                lblAccountInfo.Text = "Create an account first";
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                lblAccountInfo.Text = account.GetAccountInfo();
                UpdateActionHistory();
            }
            else
            {
                lblAccountInfo.Text = "Create an account first";
            }
        }


        private void UpdateActionHistory()
        {
            lstActionHistory.Items.Clear();
            if (account != null)
            {
                var history = account.GetActionHistory();
                foreach (var action in history)
                {
                    lstActionHistory.Items.Add(action);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtAccountInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lstActionHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAccountInfo_Click(object sender, EventArgs e)
        {

        }
    }
}

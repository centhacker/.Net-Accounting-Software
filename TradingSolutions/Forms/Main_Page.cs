using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TradingSolutions
{
    public partial class Main_Page : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.ShowDialog();
        }

        private void freightForwarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Freight fre = new Freight();
            fre.ShowDialog();
        }

        private void buyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buyer buy = new Buyer();
            buy.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Order ord = new Forms.Order();
            ord.ShowDialog();
        }

        private void currencyExchangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void shipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.To_Inventory ToInv = new Forms.To_Inventory();
            ToInv.ShowDialog();
        }

        private void toOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.To_Order ToOrd = new Forms.To_Order();
            ToOrd.ShowDialog();
        }

        private void sUPPLIERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.InvoiceSupplier InvSupp = new Reports.InvoiceSupplier();
            InvSupp.ShowDialog();
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void currentInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.CurrentInventory CurrInv = new Reports.CurrentInventory();
            CurrInv.ShowDialog();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bUYERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.InvoiceBuyer InvB = new Reports.InvoiceBuyer();
            InvB.ShowDialog();
        }

        private void inventoryTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.InventoryTransactions InvTra = new Reports.InventoryTransactions();
            InvTra.ShowDialog();
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Chart_Of_Accounts CharObj = new Forms.Chart_Of_Accounts();
            CharObj.ShowDialog();
        }

        private void bankAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Bank ObjBank = new Forms.Bank();
            ObjBank.ShowDialog();
        }

        private void paymentTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.Payment_To_Order objPay = new Forms.Payment_To_Order();
            objPay.ShowDialog();
        }

        private void fromSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Payment_To_Supplier objPay = new Forms.Payment_To_Supplier();
            objPay.ShowDialog();
        }

        private void generalVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.GeneralJournal objGen = new Forms.GeneralJournal();
            objGen.ShowDialog();
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.TrialBalance ObjTra = new Reports.TrialBalance();
            ObjTra.ShowDialog();
        }

        private void financialStatmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fiscalYearClosingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.GenerateFinancialStatements ObjFis = new Forms.GenerateFinancialStatements();
            ObjFis.ShowDialog();
        }

        private void bankTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void incomeStatemntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.IncomeStatement objIn = new Reports.IncomeStatement();
            objIn.ShowDialog();
        }

        private void ownerEquityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.OwnerEquity ObjOwn = new Reports.OwnerEquity();
            ObjOwn.ShowDialog();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.BalanceSheet ObjBal = new Reports.BalanceSheet();
            ObjBal.ShowDialog();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.RefundDuty obj = new Forms.RefundDuty();
            obj.ShowDialog();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.RefundSupplier obj = new Forms.RefundSupplier();
            obj.ShowDialog();
        }

        private void orderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Forms.PackingListBuyer obj = new Forms.PackingListBuyer();
            obj.ShowDialog();
        }

        private void supplierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Forms.PackingListSupplier obj = new Forms.PackingListSupplier();
            obj.ShowDialog();
        }

        private void showProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ShowProductsByPackingList obj = new Forms.ShowProductsByPackingList();
            obj.ShowDialog();
        }

        private void searchInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.grdInventoryGrid obj = new Forms.grdInventoryGrid();
            obj.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BackUpDB Objback = new Forms.BackUpDB();
            Objback.ShowDialog();
        }

        private void paymentTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.Payments pay = new Forms.Payments();
            pay.ShowDialog();
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Currency curr = new Forms.Currency();
            curr.ShowDialog();
        }

        private void bankTransactionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.AccountTransaction ObjAcc = new Forms.AccountTransaction();
            ObjAcc.ShowDialog();
        }

        private void viewBankTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.AccountTransactions obj = new Reports.AccountTransactions();
            obj.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports.CurrentInventory obj = new Reports.CurrentInventory();
            obj.ShowDialog();
        }

        private void inventoryTransactionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports.InventoryTransactions obj = new Reports.InventoryTransactions();
            obj.ShowDialog();

        }

        private void supplierInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.InvoiceSupplier obj = new Reports.InvoiceSupplier();
            obj.ShowDialog();

        }

        private void buyerInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.InvoiceBuyer obj = new Reports.InvoiceBuyer();
            obj.ShowDialog();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Bank obj = new Forms.Bank();
            obj.ShowDialog();
        }

        private void chartOfAccountsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Forms.Chart_Of_Accounts obj = new Forms.Chart_Of_Accounts();
            obj.ShowDialog();
        }

        private void generalPostingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.GeneralJournal obj = new Forms.GeneralJournal();
            obj.ShowDialog();
        }

        private void fiscalYearClosingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Forms.FiscalYearClosing obj = new Forms.FiscalYearClosing();
            obj.ShowDialog();
        }
    }
}

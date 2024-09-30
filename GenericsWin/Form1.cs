using Generics;
namespace GenericsWin
{
    public partial class Form1 : Form
    {
        List<Account> accounts = new List<Account>();


        public Form1()
        {
            InitializeComponent();
            resetpanel();


        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedIndex == 1)
            {
                panelAddAcc.Visible = true;

            }

            if (listBoxMenu.SelectedIndex == 2)
            {
                DisplayAllData();

            }

            if (listBoxMenu.SelectedIndex == 3)
            {
                panelsrcdata.Visible = true;

            }

            if (listBoxMenu.SelectedIndex == 4)
            {

            }

            if (listBoxMenu.SelectedIndex == 5)
            {

                paneldelete.Visible = true;
            }
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {

            Account account;
            if (comboBoxAcctype.SelectedItem.ToString() == "Saving")
            {
                account = new Saving();
            }
            else
            {
                account = new Current();
            }

            account.AccNo = int.Parse(txtAccNo.Text);
            account.CustName = txtCName.Text;
            account.Balance = decimal.Parse(txtboxinitamt.Text);

            accounts.Add(account);

            // Clear TextBoxes
            txtAccNo.Clear();
            txtCName.Clear();
            txtboxinitamt.Clear();
        }


        private void DisplayAllData()
        {
            foreach (var account in accounts)
            {

                lblDisplayData.Text += $"Account No : {account.AccNo} , Customer Name : {account.CustName} , Balance : {account.Balance}\n";
            }

        }

        private void SearchData()
        {
            foreach (var account in accounts)
            {
                if (account.AccNo == int.Parse(txtAccSrc.Text))
                {
                    lblDisplayData.Text += $"Account No : {account.AccNo} , Customer Name : {account.CustName} , Balance : {account.Balance}";

                }
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int accNo = int.Parse(txtboxdelete.Text);
            accounts.RemoveAll(acc => acc.AccNo == accNo);
            lblDisplay.Text = "Account deleted!";
        }



        private void resetpanel()
        {
            panelsrcdata.Visible = false;
            panelAddAcc.Visible = false;
            paneldelete.Visible = false;
        }
    }   
}

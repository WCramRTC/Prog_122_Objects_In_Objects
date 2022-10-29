using System;

namespace WinForm_Examples
{
    public partial class Form1 : Form
    {
        List<Person> _customers = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            Preload();
          
        }

        public void Preload()
        {
            // Create a new person instance for Will
            Person will = new Person("William", "Cram");
            BankAccount willSavings = new BankAccount("Savings", 500);
            BankAccount willChecking = new BankAccount("Checking", 40);
            will.Accounts.Add(willSavings);
            will.Accounts.Add(willChecking);


            //---------------------------------------------------------------------------------

            // Creating a new person object, Hannah, with her on list of accounts
            Person hannah = new Person("Hannah", "Angel");

            BankAccount hannahSavings = new BankAccount("Savings", 500000);
            BankAccount hannahChecking = new BankAccount("Checking", 1000000);


            hannah.Accounts.Add(hannahSavings);
            hannah.Accounts.Add(hannahChecking);
  




        }


        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        private void rtbDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
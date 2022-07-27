using AccountMicroservice.Models;
using System.Collections.Generic;

namespace AccountMicroservice.Repository
{
    public static class GetListRep
    {

        public static List<Statement> accountStatements = new List<Statement>()
            {


            new Statement(){ AccountId=101,Date="2020-10-30",Narration="Deposit from Bank",Refno="Ref75",ValueDate="2020-11-02",Withdrawal=0,Deposit=200,ClosingBalance=1200},
            new Statement(){ AccountId=101,Date="2020-10-20",Narration="Deposit from Bank",Refno="Ref76",ValueDate="2020-10-20",Withdrawal=100,Deposit=0,ClosingBalance=1100},
            new Statement(){ AccountId=102,Date="2020-10-05",Narration="Deposit from Bank",Refno="Ref77",ValueDate="2020-10-05",Withdrawal=0,Deposit=600,ClosingBalance=1600},
            new Statement(){ AccountId=102,Date="2020-10-06",Narration="Deposit from Bank",Refno="Ref78",ValueDate="2020-10-06",Withdrawal=200,Deposit=0,ClosingBalance=1400}
         };
        public static List<CurrentAccount> currentAccountsList = new List<CurrentAccount>()
        {
            new CurrentAccount{CAId=101,CBal=5000,MinBalance=500},
            new CurrentAccount{CAId=201,CBal=7000,MinBalance=500},
            new CurrentAccount{CAId=301,CBal=10000,MinBalance=500}
        };
        public static List<SavingsAccount> savingsAccountsList = new List<SavingsAccount>()
        {
            new SavingsAccount{SAId=102,SBal=2000,MinBalance=200},
            new SavingsAccount{SAId=202,SBal=3000,MinBalance=200},
            new SavingsAccount{SAId=302,SBal=5000,MinBalance=200}
        };

        public static List<Statement> GetAccountStatementsList()
        {

            return accountStatements;
        }



        public static List<customeraccount> GetCustomeraccountsList()
        {
            List<customeraccount> customeraccounts = new List<customeraccount>()
            {
                new customeraccount{custId=1,CAId=101,SAId=102},
                new customeraccount{custId=2,CAId=201,SAId=202},
                new customeraccount{custId=3,CAId=301,SAId=302}
            };
            return customeraccounts;
        }



    }
}

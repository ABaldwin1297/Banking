using Banking;

var acct1 = new Account() {
    Name = "Checking 1"
};
var acct2 = new Account() {
    Name = "Checking 2"
};

acct1.Deposit(1000);
acct2.Deposit(500);

acct1.Withdraw(200);
acct2.Withdraw(300);

Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");

acct1.Withdraw(1200); // shows insufficient funds b/c account only has $1,000
Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");

acct2.Transfer(100, acct1);
Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");

acct1.Deposit(100);
Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");

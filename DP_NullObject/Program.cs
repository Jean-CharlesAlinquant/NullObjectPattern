using DesignPatterns.NullObject;

var log = new NullLog();
var account = new BankAccount(log);
account.Deposit(100);

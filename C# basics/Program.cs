// See https://aka.ms/new-console-template for more information
using System;
namespace project{

  //Simple String

  public class abc{
    public static void Main(string [] args){
    string a= "Sree";
    string b= "Priya";
    Console.WriteLine($"My friends are {a} and {b}");
  

 //Replace

 string c= "Good Morning";
Console.WriteLine(c);
c = c.Replace("Morning", "Afternoon");
Console.WriteLine(c);

  

  //integer

     abcd S = new abcd();
     S.Add();
     S.Sub();
     S.Mul();
     S.Div();
     def P = new def();
     P.Something();
    

     // if else statements

        int x = 12;
        int y = 5;

        // if
      if (x + y > 10)
        Console.WriteLine("Output is greater than 10");

        // if else
      if (x + y > 10)
        Console.WriteLine("Output is greater than 10");

      else{
        Console.WriteLine("Output is not greater than 10");
     }

          // while
          int k = 0;
         while (k < 5)
          {
            Console.WriteLine($"Counter is {k}");
               k++;
            }

          //do while
            int l= 0;
            do
             {
                Console.WriteLine($"Counter is {l}");
                l++;
              }
                 while (l < 10);
          //for loop
          for (int i = 0; i < 20; i++)
          Console.WriteLine($"Counter is {i}");
        
    


 //lists in strings
 
    var items = new List<string> { "Book", "Pen", "Laptop" ,"Charger"};
    //List<string> items = new List<string> { "Book", "Pen", "Laptop" ,"Charger"};
    foreach (var item in items)
{
  Console.WriteLine($"{item}");

}
foreach (var item in items)
{
  Console.WriteLine($"{item.ToUpper()}");
}
  foreach (var item1 in items)
  {
  Console.WriteLine($"{item1.ToLower()}");
}

   // Adding and removing items
items.Add("Bag");
items.Add("Mouse");
items.Remove("Pen");
items.Remove("Charger");
foreach (var item in items)
{
  Console.WriteLine($"{item}");
}

 // Sort

items.Sort();
foreach (var item in items)
{
  Console.WriteLine($"{item}");
}
     // lists in integer

      var nums = new List<int> {500, 213, 564, 34, 78};
foreach (var num in nums)
{
  Console.WriteLine($"{num}");

}

   // Adding and removing nums
nums.Add(200);
nums.Remove(213);
nums.Remove(34);
foreach (var num in nums)
{
  Console.WriteLine($"{num}");
}

    // Fibonacci Series
       
        var fN = new List<int> {1, 1};

       while (fN.Count < 20)
   {
    var u = fN[fN.Count - 1];
    var v = fN[fN.Count - 2];

    fN.Add(u + v);
   }
   foreach(var p in fN)
  {
    Console.WriteLine(p);
  }

    //OOP

BankAccount account = new BankAccount("Sreepriya", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
account.MakeWithdrawal(500, DateTime.Now, "payment");
Console.WriteLine(account.Balance);
Console.WriteLine(account.Number);
Console.WriteLine(account.Owner);
account.MakeDeposit(100, DateTime.Now, "credited");
Console.WriteLine(account.Balance);
Console.WriteLine(account.Number);
Console.WriteLine(account.Owner);
// Test for a negative balance.
try
{
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}
Console.WriteLine(account.GetAccountHistory());
// Test that the initial balances must be positive.
BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
   
    return;
  
}


    }
  }
}

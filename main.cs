using System;

class Program {
  public static void Main (string[] args) {
 
      int print;
      int age;
      string name;
      string answer;
  // Console.WriteLine("what is your name");  
  
  // name = Console.ReadLine();
  
  // Console.WriteLine("hello " + name);
  
  // Console.WriteLine("what is your age?");  
  
  // age = Convert.ToInt32(Console.ReadLine());
  // // Convert.ToInt32
  // if (age >= 13) {
  //   Console.WriteLine("Yay! " + name + " You can sign up for our class ");  
  // }else{
  //   Console.WriteLine("No " + name +" You can't sign up for our class ");

    Console.WriteLine("Now you have too beat me at Rock Paper Scissors p=paper s=scissors r= rock");
    answer = Console.ReadLine();
    string[] RPS = {"Rock","Paper","Scissors"};
    Random rd = new Random();
    print = rd.Next(0,2);
    Console.WriteLine(RPS[print]);
    
    if (answer == "p" && print == 0){
      Console.WriteLine("You Win!");
      
    }
    if (answer == "p" && print == 1){
      Console.WriteLine("You Tied!");
      
    }
     if (answer == "p" && print == 2){
      Console.WriteLine("You Lose!");
      
    }
     if (answer == "r" && print == 0){
      Console.WriteLine("You Tied!");
      
    }
    if (answer == "r" && print == 1){
      Console.WriteLine("You Lost!");
      
    }
    if (answer == "r" && print == 2){
      Console.WriteLine("You Won!");
      
    }
    if (answer == "s" && print == 0){
      Console.WriteLine("You Lost!");
      
    }
    if (answer == "s" && print == 1){
      Console.WriteLine("You Won!");
      
    }
    if (answer == "s" && print == 2){
      Console.WriteLine("You Tied!");
      
    }
  
  }
  
}

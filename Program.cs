// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
static float change_to_give(float n){
    float quater = Single.Parse("0.25"); 
    float dime = Single.Parse("0.10");
    float nickel = Single.Parse("0.05");
    float penny = Single.Parse("0.01");

    float num_of_quaters = n/ quater;
    num_of_quaters = Convert.ToInt32(Math.Floor(num_of_quaters));
    Console.WriteLine("0.25: "+num_of_quaters);//!for testing\
    Console.WriteLine("n: "+ n);//!for testing\
    n = n - (num_of_quaters*quater);
    Console.WriteLine("After,N: "+ n);//!for testing\

    float num_of_dimes = n/ dime;
    num_of_dimes = Convert.ToInt32(Math.Floor(num_of_dimes));
    Console.WriteLine("0.10: "+num_of_dimes);//!for testing\
    Console.WriteLine("n: "+ n);//!for testing\
    n = n - (num_of_dimes*dime);
    Console.WriteLine("After,N: "+ n);//!for testing\

    float num_of_nickels = n/ nickel;
    num_of_nickels = Convert.ToInt32(Math.Floor(num_of_nickels));
    Console.WriteLine("0.05: "+num_of_nickels);//!for testing\
    Console.WriteLine("n: "+ n);//!for testing\
    n = n - (num_of_nickels*nickel);
    Console.WriteLine("After,N: "+ n);//!for testing\

    int total_change = 0;
    total_change = Convert.ToInt32(num_of_quaters + num_of_dimes + num_of_nickels);
    Console.WriteLine("Total Change: "+total_change);
    return (n);
}

// Console.WriteLine("Enter change: ");
// float change = Single.Parse(Console.ReadLine());
// Console.WriteLine(change);
//! tests
// float change = Single.Parse("2"); // 8 
float amount = Single.Parse("0.66"); // 3
change_to_give(amount); 

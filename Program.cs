// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
static float change_to_give(float n){
    float quater = Single.Parse("0.25"); 
    float dime = Single.Parse("0.10");
    float nickel = Single.Parse("0.05");
    float penny = Single.Parse("0.01");

    float num_of_quaters = n/ quater;
    num_of_quaters = Convert.ToInt32(Math.Floor(num_of_quaters));
    Console.WriteLine(num_of_quaters);
    // n = n - (num_of_quaters*quater);
    // Console.WriteLine('n'+ n);

    // float num_of_dimes = n/ dime;
    // num_of_dimes = Convert.ToInt32(num_of_dimes);
    // n = n - (num_of_dimes*dime);
    // Console.WriteLine('n'+ n);

    // float num_of_nickels = n/ nickel;
    // num_of_nickels = Convert.ToInt32(num_of_nickels);
    // n = n - (num_of_dimes*dime);

    // float num_of_nickels = change/ quater;
    // num_of_quaters = Convert.ToInt32(num_of_quaters);
    // change = change - (num_of_quaters*quater);
    // change = change/ dimes;
    // change = change/ quater;
    // change = change/ quater;

    // int total_change = 0;
    // total_change = Convert.ToInt32(num_of_quaters + num_of_dimes + num_of_nickels);

    // Console.WriteLine(num_of_quaters);
    // Console.WriteLine(num_of_nickels);
    // Console.WriteLine(change);
    return (n);
}

// Console.WriteLine("Enter change: ");
// float change = Single.Parse(Console.ReadLine());
// Console.WriteLine(change);
//! tests
// float change = Single.Parse("2"); // 8 
float change = Single.Parse("0.65"); // 3
change_to_give(change); 
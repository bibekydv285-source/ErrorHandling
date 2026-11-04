int speed = 0;

try
{
    Console.WriteLine("Enter a distance:");
    int distance = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Enter a time:");
    int time = Convert.ToInt32(Console.ReadLine());

    speed = distance / time;
}
catch (FormatException ex)
{
    Console.WriteLine("Wrong Fomrat.");

}

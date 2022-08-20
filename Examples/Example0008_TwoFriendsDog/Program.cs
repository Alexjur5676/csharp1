Console.Write("firstFriendSpeed: ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("secondFriendSpeed: ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("dogSpeed: ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("distance: ");
double distance = Convert.ToDouble(Console.ReadLine());
int count = 0;
int friend = 2;
double time = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
    Console.Write("distance = ");
    Console.WriteLine(distance);
    Console.Write("time = ");
    Console.WriteLine(time);
}
Console.Write("count = ");
Console.WriteLine(count);

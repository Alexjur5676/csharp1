double firstFriendSpeed = new Random().Next(1, 3); 
Console.Write("firstFriendSpeed = ");
Console.WriteLine(firstFriendSpeed);
double secondFriendSpeed = new Random().Next(1, 3);
Console.Write("fsecondFriendSpeed = ");
double dogSpeed = new Random().Next(1, 10);
Console.WriteLine(secondFriendSpeed);
Console.Write("dogSpeed = ");
Console.WriteLine(dogSpeed);
int count = 0;
double distance = 1000;
int friend = 2;
double time = 0;
while(distance > 10)
{
    if(friend == 1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
    count++;
    Console.Write("distance = ");
    Console.WriteLine(distance);
    Console.Write("time = ");
    Console.WriteLine(time);
}
Console.Write("count = ");
Console.WriteLine(count);

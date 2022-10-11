Console.Clear();

int count = 0, distance = 10000, firstFriendSpeed = 1, SecondFriendSpeed = 2, dogSpeed = 5, time = 0, friend = 2;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (SecondFriendSpeed + dogSpeed);
        friend = 1;
    }
    if (friend == 2)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }

    distance = distance - ((firstFriendSpeed + SecondFriendSpeed) * time);
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз");


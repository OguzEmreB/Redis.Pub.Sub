
using StackExchange.Redis;

ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:1453");

ISubscriber subscriber = connection.GetSubscriber();

while (true)
{
    Console.WriteLine("ChannelPattern : ");  //channel1 , channel1.* , channel1.p1 , channel1.p2
    string patternOrChannel = Console.ReadLine();
    Console.WriteLine("Nesaj : ");
    string message = Console.ReadLine();
    await subscriber.PublishAsync(patternOrChannel, message);

}

//while (true)
//{
//    Console.WriteLine("Nesaj : ");
//    string message = Console.ReadLine();
//    await subscriber.PublishAsync("mychannel", message);

//}

using StackExchange.Redis;

ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:1453");

ISubscriber subscriber = connection.GetSubscriber();

Console.WriteLine("patternOrChannel : ");  //channel1 , channel1.* , channel1.p1 , channel1.p2
string patternOrChannel = Console.ReadLine();

await subscriber.SubscribeAsync(patternOrChannel, (channel, message) =>
{
    Console.WriteLine(message);
});
Console.ReadLine();
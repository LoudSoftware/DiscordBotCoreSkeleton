using System;
using System.Threading.Tasks;
using DiscordBotCoreTut.Discord;
using DiscordBotCoreTut.Discord.Entities;
using DiscordBotCoreTut.Storage;

namespace DiscordBotCoreTut
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello Discord!");

            var storage = Unity.Resolve<IDataStorage>();


            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new BotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });
        }
    }
}
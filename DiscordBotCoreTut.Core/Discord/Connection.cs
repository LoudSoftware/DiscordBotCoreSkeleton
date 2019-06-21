using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using DiscordBotCoreTut.Discord.Entities;

namespace DiscordBotCoreTut.Discord
{
    public class Connection
    {
        private readonly DiscordLogger _logger;
        private readonly DiscordSocketClient _client;

        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        }

        internal async Task ConnectAsync(BotConfig config)
        {
            _client.Log += _logger.Log;

            await _client.LoginAsync(TokenType.Bot, config.Token);
            await _client.StartAsync();
            await Task.Delay(-1);
        }
    }
}
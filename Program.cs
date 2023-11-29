using Microsoft.Extensions.DependencyInjection;

namespace TheCountGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IGame, Game>()
                .AddSingleton<IGameSettingManage, GameSettingManage>()
                .BuildServiceProvider();

            var _game = serviceProvider.GetService<IGame>();

            while (true)
            {
                _game.Start();
                Console.WriteLine("Для продолжения нажмите любую кнопку. \nЕсли хотите выйти, введите q.\nДля изменения настроек введите s ");

                string input = Console.ReadLine() ?? string.Empty;

                if (input == "q")
                {
                    break;
                }
                else if (input == "s")
                {
                    _game.SetSettings();
                }
            }
        }
    }
}
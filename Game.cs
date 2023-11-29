namespace TheCountGame
{
    public class Game : IGame
    {
        private readonly IGameSettingManage _set;

        public Game(IGameSettingManage set)
        {
            _set = set;
        }

        public void Start()
        {
            if (!_set.GetIsSet())
            {
                Console.WriteLine("Кажется это наша первая игра! Привет!");
                _set.SetSettings();
            }

            int TheNum = (new Random()).Next(_set.GetLowBorder(), _set.GetHighBorder());
            int step = 0;

            while (_set.GetTry() != 0)
            {
                Console.WriteLine($"[Попытка {step + 1} из {step + _set.GetTry()}] Какое число загадано?");

                int guess;

                while (!int.TryParse(Console.ReadLine(), out guess))
                    Console.WriteLine("Число должно быть целочисленным.");

                if (guess == TheNum)
                {
                    Console.WriteLine($"Поздравляю! Ты отгадал число {TheNum} с {step + 1} попытки.");
                    _set.SetTry(0);
                }
                else if (guess < TheNum)
                {
                    if (_set.GetTry() == 1)
                    {
                        Console.WriteLine($"К сожалению у тебя закончились попытки и ты не угадал число {TheNum}. Прости...");
                        _set.SetTry(0);
                    }
                    else
                    {
                        Console.WriteLine($"Загаданное число больше. Пробуй дальше.");
                        _set.SetTry(_set.GetTry() - 1);
                    }
                }
                else if (guess > TheNum)
                {
                    if (_set.GetTry() == 1)
                    {
                        Console.WriteLine($"К сожалению у тебя закончились попытки и ты не угадал число {TheNum}. Прости...");
                        _set.SetTry(0);
                    }
                    else
                    {
                        Console.WriteLine($"Загаданное число меньше. Пробуй дальше.");
                        _set.SetTry(_set.GetTry() - 1);
                    }
                }
                step++;
            }
        }

        public void SetSettings()
        {
            _set.SetSettings();
        }
    }
}
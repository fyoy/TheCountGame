namespace TheCountGame
{
    public class GameSettingManage : IGameSettingManage
    {
        private int TryNum;
        private int HighBorder;
        private int LowBorder;
        bool IsSetSetting = false;

        public void SetSettings()
        {
            Console.WriteLine("Установите параметры для игры:");

            Console.WriteLine("Укажите первую границу для загадываемого числа: ");
            while (!int.TryParse(Console.ReadLine(), out this.HighBorder))
                Console.WriteLine("Число должно быть целочисленным. Укажите первую границу для загадываемого числа: ");

            Console.WriteLine("Укажите вторую границу для загадываемого числа: ");
            while (!int.TryParse(Console.ReadLine(), out this.LowBorder))
                Console.WriteLine("Число должно быть целочисленным. Укажите вторую границу для загадываемого числа: ");

            Console.WriteLine("Укажите количество попыток: ");
            while (!int.TryParse(Console.ReadLine(), out this.TryNum))
                Console.WriteLine("Число должно быть целочисленным. Укажите количество попыток:");

            if (LowBorder > HighBorder)
                (LowBorder, HighBorder) = (HighBorder, LowBorder);

            if (TryNum == 0)
            {
                Console.WriteLine("0 попыток как-то мало, так что дарю тебе 1 попытку.");
                TryNum = 1;
            }

            IsSetSetting = IsSetSetting == false ? true : IsSetSetting;
        }

        public int GetLowBorder()
        {
            return LowBorder;
        }

        public int GetHighBorder()
        {
            return HighBorder;
        }
        public int GetTry()
        {
            return TryNum;
        }

        public void SetTry(int e)
        {
            this.TryNum = e;
        }
        public bool GetIsSet()
        {
            return IsSetSetting;
        }
    }
}
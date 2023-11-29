namespace TheCountGame
{
    public interface IGameSettingManage : IGameSettingSet
    {
        int GetLowBorder();
        int GetHighBorder();
        int GetTry();
        void SetTry(int e);
        bool GetIsSet();
    }
}
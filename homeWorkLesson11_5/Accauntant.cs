namespace homeWorkLesson11_5
{
    public class Accountant
    {
       public bool AskForBonus(Post worker, int hours)
        {
            return (int)worker < hours;
        }
    }

    public enum Post
    {
        Manager = 250,
        Secretary = 230,
        Accountant = 220
    }
}

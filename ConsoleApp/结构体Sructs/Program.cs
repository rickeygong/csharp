using System;

namespace 结构体Sructs
{
    struct Game
    {
        public string name;
        public string developer;
        public DateTime releaseDate;
        
        //结构体不能有无参数的构造函数
        //public Game()
        //{

        //}

        public Game(string name,string developer,DateTime releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.releaseDate = releaseDate;
        }
        public void GetInfo()
        {
            Console.WriteLine($"游戏name：{name}");
            Console.WriteLine($"游戏developer：{developer}");
            Console.WriteLine($"游戏releaseDate：{releaseDate}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game;
            game.name = "pokemon";
            game.developer = "rickey.gong";
            game.releaseDate = DateTime.Now;
            game.GetInfo();
            Console.ReadKey();
        }
    }
}

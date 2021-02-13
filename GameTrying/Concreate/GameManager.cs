using GameTrying.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrying.Concreate
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " !!!Bu harrika oyun senin için eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "!!!silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "  günceellendi.");
        }
    }
}

using GameTrying.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrying.Abstract_Con
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRFantasy
{
    class GameManager
    {
        private GameManager()
        {
            
        }

        static private GameManager instance;
        static public GameManager Instance => instance ??= new GameManager();


    }
}

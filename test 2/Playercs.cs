using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    public class Player
    {
        public int hp = 100;
        public int at = 10;

        public void ADDAT(int _at)
        {
            //공격력을 _at올려주기 위한 함수
            at += _at;
        }
        
        public void Fight(int monsterAt)
        {
           hp -= monster.At;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMapTool
{
    public enum MonsterAICommand : Int32
    {
        Idle = 0,
        Move_Right = 1,
        Move_Left = 2,
        Jump = 3,
    }

    public enum MonsterType : Int32
    {
        None = 0,
        Zen_chan = 1
    }
    public struct StartPos
    {
        public int X;
        public int Y;
    }

    public class MonsterData
    {
        public List<MonsterAICommand> Commands { get; set; }
        public MonsterType type { get; set; }
        public string MonsterID { get; set; } //고유의 값

        
       public StartPos startPos;

        public MonsterData()
        {
            Commands = new List<MonsterAICommand>();
            startPos = new StartPos();
            type = MonsterType.None;
        }

        public void Clear()
        {
            MonsterID = "";
            type = MonsterType.None;
            startPos.X = 0;
            startPos.Y = 0;
            Commands.Clear();
        }
    }
}

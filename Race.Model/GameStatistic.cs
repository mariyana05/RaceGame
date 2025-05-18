using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Model
{
    public class GameStatistic
    {
        public string UserName { get; set; }    
        public DateTime  CurrentDateTime { get; set; }
        public int Coins { get; set; }
        public int Score { get; set; }

    }
}
